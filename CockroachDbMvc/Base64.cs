using System.Text;

namespace CockroachDbMvc
{
    public class Base64
    {
        public static string Codificar(string plainText)
        {
            try
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                return Convert.ToBase64String(plainTextBytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string Decodificar(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
                return Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}