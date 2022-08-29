using System.Text;
namespace CockroachDbMvc
{
    public class Dto
    {
        public static string Generar(string tabla, List<Estructura> campos)
        {
            int iteracion = 0;
            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var row in campos)
                {
                    stringBuilder.AppendLine($"[JsonProperty(\"{Cadena.PriMin(row.Nombre)}\")]");
                    switch (row.TipoDotNet)
                    {
                        case "int":
                            stringBuilder.AppendLine($"public int {row.Nombre} {{ set; get; }} = 0;\n");
                            break;

                        case "decimal":
                            stringBuilder.AppendLine($"public decimal {row.Nombre} {{ set; get; }} = 0;\n");
                            break;

                        case "bool":
                            stringBuilder.AppendLine($"public bool {row.Nombre} {{ set; get; }} = false;\n");
                            break;

                        case "DateTime":
                            stringBuilder.AppendLine($"public DateTime {row.Nombre} {{ set; get; }} = new DateTime(1900, 01, 01);\n");
                            break;

                        default:
                            stringBuilder.AppendLine($"public string {row.Nombre} {{ set; get; }} = string.Empty;\n");
                            break;
                    }
                    stringBuilder.AppendLine("");
                }

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