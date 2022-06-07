using System.Data;
using Npgsql;

namespace CockroachDbMvc
{
    public class CucarachaDb
    {
        public static string Use(NpgsqlConnectionStringBuilder npgsqlConnectionStringBuilder)
        {
            return $"USE {npgsqlConnectionStringBuilder.Database.Substring(npgsqlConnectionStringBuilder.Database.IndexOf(".") + 1, npgsqlConnectionStringBuilder.Database.Length - npgsqlConnectionStringBuilder.Database.IndexOf(".") - 1)}";
        }
    }
}
