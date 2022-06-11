using System.Text;

namespace CockroachDbMvc
{
    public class Vista
    {
        public static string Generar(string tabla, List<Estructura> campos)
        {
            int iteracion = 0;
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"// {tabla}.cs");
                stringBuilder.AppendLine("using System.Text;");
                stringBuilder.AppendLine("using Npgsql;");
                stringBuilder.AppendLine("");
                stringBuilder.AppendLine("// ReSharper disable once CheckNamespace");
                stringBuilder.AppendLine("namespace DataCloud");
                stringBuilder.AppendLine("{");

                stringBuilder.AppendLine($"    /// <summary>");
                stringBuilder.AppendLine($"    /// Clase de {tabla}");
                stringBuilder.AppendLine($"    /// Generado automaticamente");
                stringBuilder.AppendLine($"    /// Leonardo Chuello (ljchuello@gmail.com)");
                stringBuilder.AppendLine($"    /// {DateTime.Now:yyyy-MM-dd}");
                stringBuilder.AppendLine($"    /// </summary>");

                stringBuilder.AppendLine($"    public class {tabla}");
                stringBuilder.AppendLine("    {");

                stringBuilder.AppendLine($"        public const string Select = \"SELECT {string.Join(", ", campos.Select(x => $"\\\"{x.Nombre}\\\""))} FROM \\\"{tabla}\\\"\";");
                stringBuilder.AppendLine("");

                #region Campos

                stringBuilder.AppendLine("        #region Field\n");
                stringBuilder.AppendLine("       ");
                foreach (var row in campos)
                {
                    switch (row.TipoDotNet)
                    {
                        case "int":
                            stringBuilder.AppendLine($"        public int {row.Nombre} {{ set; get; }} = 0;\n");
                            break;

                        case "decimal":
                            stringBuilder.AppendLine($"        public decimal {row.Nombre} {{ set; get; }} = 0;\n");
                            break;

                        case "bool":
                            stringBuilder.AppendLine($"        public bool {row.Nombre} {{ set; get; }} = false;\n");
                            break;

                        case "DateTime":
                            stringBuilder.AppendLine($"        public DateTime {row.Nombre} {{ set; get; }} = new DateTime(1900, 01, 01);\n");
                            break;

                        default:
                            stringBuilder.AppendLine($"        public string {row.Nombre} {{ set; get; }} = string.Empty;\n");
                            break;
                    }
                }
                stringBuilder.AppendLine("        #endregion");

                #endregion

                #region Methods

                stringBuilder.AppendLine("");
                stringBuilder.AppendLine("        #region Methods");
                stringBuilder.AppendLine("");
                stringBuilder.AppendLine("");
                stringBuilder.AppendLine("");
                stringBuilder.AppendLine("        #endregion");

                #endregion

                stringBuilder.AppendLine("");

                #region Maker

                stringBuilder.AppendLine("\n        #region Maker");

                stringBuilder.AppendLine($"");
                stringBuilder.AppendLine($"        public {tabla} Maker(NpgsqlDataReader dtReader)");
                stringBuilder.AppendLine($"        {{");
                stringBuilder.AppendLine($"            " +
                                         $"{tabla} {Cadena.PriMin(tabla)} = new {tabla}();");

                foreach (var row in campos)
                {
                    switch (row.TipoDotNet)
                    {
                        case "int":
                            stringBuilder.AppendLine($"            {Cadena.PriMin(tabla)}.{row.Nombre} = dtReader.IsDBNull(dtReader.GetOrdinal(\"{row.Nombre}\")) ? 0 : dtReader.GetInt32(dtReader.GetOrdinal(\"{row.Nombre}\"));");
                            break;

                        case "decimal":
                            stringBuilder.AppendLine($"            {Cadena.PriMin(tabla)}.{row.Nombre} = dtReader.IsDBNull(dtReader.GetOrdinal(\"{row.Nombre}\")) ? 0 : dtReader.GetDecimal(dtReader.GetOrdinal(\"{row.Nombre}\"));");
                            break;

                        case "bool":
                            stringBuilder.AppendLine($"            {Cadena.PriMin(tabla)}.{row.Nombre} = !dtReader.IsDBNull(dtReader.GetOrdinal(\"{row.Nombre}\")) && dtReader.GetBoolean(dtReader.GetOrdinal(\"{row.Nombre}\"));");
                            break;

                        case "DateTime":
                            stringBuilder.AppendLine($"            {Cadena.PriMin(tabla)}.{row.Nombre} = dtReader.IsDBNull(dtReader.GetOrdinal(\"{row.Nombre}\")) ? new DateTime(1900, 01, 01) : dtReader.GetDateTime(dtReader.GetOrdinal(\"{row.Nombre}\"));");
                            break;

                        default:
                            stringBuilder.AppendLine($"            {Cadena.PriMin(tabla)}.{row.Nombre} = dtReader.IsDBNull(dtReader.GetOrdinal(\"{row.Nombre}\")) ? string.Empty : dtReader.GetString(dtReader.GetOrdinal(\"{row.Nombre}\"));");
                            break;
                    }
                }

                stringBuilder.AppendLine($"            return {Cadena.PriMin(tabla)};");
                stringBuilder.AppendLine($"        }}");
                stringBuilder.AppendLine($"");

                stringBuilder.AppendLine("        #endregion");

                #endregion

                stringBuilder.AppendLine("    }");
                stringBuilder.AppendLine("}");
                return stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ah ocurridoun error; {ex.Message}");
                return string.Empty;
            }
        }
    }
}