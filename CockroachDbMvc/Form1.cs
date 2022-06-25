using System.Data;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Npgsql;

namespace CockroachDbMvc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "CockroachDb - Mvc";

            // Deshabilitamos el error multiTask
            CheckForIllegalCrossThreadCalls = false;

            // Cultura chupistica
            var culture = CultureInfo.GetCultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;

            // Existencia
            if (File.Exists(@"D:\CockroachDB.json"))
            {
                NpgsqlConnectionStringBuilder npgsqlConnectionStringBuilder = JsonConvert.DeserializeObject<NpgsqlConnectionStringBuilder>(File.ReadAllText(@"D:\CockroachDB.json")) ?? new NpgsqlConnectionStringBuilder();
                txtUsuario.Text = npgsqlConnectionStringBuilder.Username;
                txtContrasenia.Text = npgsqlConnectionStringBuilder.Password;
                txtBaseDatos.Text = npgsqlConnectionStringBuilder.Database;
                txtServidor.Text = npgsqlConnectionStringBuilder.Host;
                txtPort.Text = $"{npgsqlConnectionStringBuilder.Port}";
            }

            // Set
            lblResumen.Text = string.Empty;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnectionStringBuilder npgsqlConnectionStringBuilder = new NpgsqlConnectionStringBuilder();
                npgsqlConnectionStringBuilder.Host = txtServidor.Text;
                npgsqlConnectionStringBuilder.Port = Convert.ToInt32(txtPort.Text);
                npgsqlConnectionStringBuilder.SslMode = SslMode.Require;
                npgsqlConnectionStringBuilder.Username = txtUsuario.Text;
                npgsqlConnectionStringBuilder.Password = txtContrasenia.Text;
                npgsqlConnectionStringBuilder.Database = txtBaseDatos.Text;
                npgsqlConnectionStringBuilder.TrustServerCertificate = true;

                List<string> tablas = new List<string>();


                using (NpgsqlConnection db = new NpgsqlConnection(npgsqlConnectionStringBuilder.ToString()))
                {
                    db.Open();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                    npgsqlCommand.Connection = db;
                    npgsqlCommand.CommandType = CommandType.Text;
                    npgsqlCommand.CommandText = "SHOW TABLES;";
                    using (NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader())
                    {
                        while (npgsqlDataReader.Read())
                        {
                            tablas.Add(Convert.ToString(npgsqlDataReader["table_name"]));
                        }
                    }
                }

                tablas = tablas.OrderBy(x => x).ToList();

                ddlTabla.DataSource = tablas;

                File.WriteAllText(@"D:\CockroachDB.json", JsonConvert.SerializeObject(npgsqlConnectionStringBuilder));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void ddlTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Estructura> list = new List<Estructura>();

                NpgsqlConnectionStringBuilder npgsqlConnectionStringBuilder = new NpgsqlConnectionStringBuilder();
                npgsqlConnectionStringBuilder.Host = txtServidor.Text;
                npgsqlConnectionStringBuilder.Port = Convert.ToInt32(txtPort.Text);
                npgsqlConnectionStringBuilder.SslMode = SslMode.Require;
                npgsqlConnectionStringBuilder.Username = txtUsuario.Text;
                npgsqlConnectionStringBuilder.Password = txtContrasenia.Text;
                npgsqlConnectionStringBuilder.Database = txtBaseDatos.Text;
                npgsqlConnectionStringBuilder.TrustServerCertificate = true;

                using (NpgsqlConnection db = new NpgsqlConnection(npgsqlConnectionStringBuilder.ToString()))
                {
                    db.Open();
                    NpgsqlCommand npgsqlCommand = new NpgsqlCommand();
                    npgsqlCommand.Connection = db;
                    npgsqlCommand.CommandType = CommandType.Text;
                    npgsqlCommand.CommandText = $"SHOW COLUMNS FROM \"{ddlTabla.SelectedItem}\";";
                    using (NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader())
                    {
                        while (npgsqlDataReader.Read())
                        {
                            Estructura estructura = new Estructura();
                            estructura.Nombre = $"{npgsqlDataReader["column_name"]}";
                            estructura.TipoBd = $"{npgsqlDataReader["data_type"]}";
                            list.Add(estructura);
                        }
                    }
                }

                // Seteamos
                foreach (var row in list)
                {
                    switch (row.TipoBd)
                    {
                        case string a when row.TipoBd.Contains("VARCHAR"):
                        case string b when row.TipoBd.Contains("STRING"):
                            row.TipoDotNet = "string";
                            break;

                        case string a when row.TipoBd.Contains("INT"):
                            row.TipoDotNet = "int";
                            break;

                        case string a when row.TipoBd.Contains("DECIMAL"):
                            row.TipoDotNet = "decimal";
                            break;

                        case string a when row.TipoBd.Contains("TIMESTAMP"):
                            row.TipoDotNet = "DateTime";
                            break;

                        case string a when row.TipoBd.Contains("BOOL"):
                            row.TipoDotNet = "bool";
                            break;

                        default:
                            MessageBox.Show($"El tipo de dato ({row.TipoBd}) no se encuentra ='(");
                            return;
                    }
                }

                string json = JsonConvert.SerializeObject(list, Formatting.Indented);

                txtAux.Text = Auxiliar.Generar($"{ddlTabla.SelectedItem}", list);
                txtVista.Text = Vista.Generar($"{ddlTabla.SelectedItem}", list);
                txtDto.Text = Dto.Generar($"{ddlTabla.SelectedItem}", list);

                // Libre de pecados
                lblResumen.Text = $"Se ha generado {ddlTabla.SelectedItem}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private int iteracion = 0;

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        NpgsqlConnectionStringBuilder npgsqlConnectionStringBuilder = new NpgsqlConnectionStringBuilder();
                        npgsqlConnectionStringBuilder.Host = "127.0.0.1";
                        npgsqlConnectionStringBuilder.Port = 26257;
                        npgsqlConnectionStringBuilder.SslMode = SslMode.Require;
                        npgsqlConnectionStringBuilder.Username = "root";
                        npgsqlConnectionStringBuilder.Password = "";
                        npgsqlConnectionStringBuilder.Database = "defaultdb";
                        npgsqlConnectionStringBuilder.RootCertificate = @"D:\CockroachDb\certs\ca.crt";
                        npgsqlConnectionStringBuilder.TrustServerCertificate = true;

                        StringBuilder stringBuilder = new StringBuilder();

                        NpgsqlConnection mySqlConnection = new NpgsqlConnection(npgsqlConnectionStringBuilder.ToString());

                        mySqlConnection.Open();
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
            });
        }

        private void Convertidor_Click(object sender, EventArgs e)
        {
            string text = txtConverter.Text;
            text = text.Replace("  ", "");
            text = text.Replace("\"", "\\\"");

            var lines = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            StringBuilder stringBuilder = new StringBuilder();

            // $"\n

            for (int i = 0; i < lines.Length; i++)
            {
                // Primero
                if (i == 0)
                {
                    stringBuilder.AppendLine($"$\"{lines[i]}\"+");
                    continue;
                }

                // Ultimo
                if (i == lines.Length-1)
                {
                    stringBuilder.Append($"$\"\\n{lines[i]}\";");
                    continue;
                }

                // Medio
                stringBuilder.AppendLine($"$\"\\n{lines[i]}\"+");
            }

            Clipboard.SetText(stringBuilder.ToString());

            txtConverter.Text = stringBuilder.ToString();
        }
    }
}