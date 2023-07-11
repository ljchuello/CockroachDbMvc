using Newtonsoft.Json;
using Npgsql;

namespace CockroachDbMvc
{
    public class Conexion
    {
        public string Id { set; get; }
        public string Host { set; get; }
        public int Port { set; get; }
        public SslMode SslMode { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Database { set; get; }
        public bool TrustServerCertificate { set; get; }

        public static List<Conexion> Leer()
        {
            try
            {
                // Existencia
                if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\CockroachDB.json"))
                {
                    List<Conexion> list = JsonConvert.DeserializeObject<List<Conexion>>(File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\CockroachDB.json")) ?? new List<Conexion>();
                    return list;
                }
                else
                {
                    return new List<Conexion>();
                }
            }
            catch (Exception e)
            {
                return new List<Conexion>();
            }
        }

        public static void Insert(Conexion sql)
        {
            // Obtenemos
            List<Conexion> list = Leer();

            // Set
            sql.Id = $"{sql.Database}@{sql.Host}";

            // Existe
            // list.Exists(x => x.Id == Base64.Codificar($"{sql.Host.ToLower()}{sql.Database.ToLower()}"))
            if (list.Exists(x => x.Id == $"{sql.Database}@{sql.Host}"))
            {
                // Recorremos
                for (int i = 0; i <= list.Count-1; i++)
                {
                    if (list[i].Id == $"{sql.Database}@{sql.Host}")
                    {
                        list[i] = sql;
                    }
                }
            }
            else
            {
                // Insertamos
                list.Add(sql);
            }

            // Grabamos
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\CockroachDB.json", JsonConvert.SerializeObject(list, Formatting.Indented));
        }
    }
}
