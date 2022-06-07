using System.Data;
using System.Globalization;
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
    }
}