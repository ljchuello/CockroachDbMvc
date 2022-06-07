using System.Text.RegularExpressions;
using System.Web;

namespace CockroachDbMvc
{
    public static class Cadena
    {
        /// <summary>
        /// Convierte la primera letra en minuscula
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string PriMin(string cadena)
        {
            string uno = cadena.Substring(0, 1).ToLower();
            cadena = cadena.Substring(1, cadena.Length - 1);
            return $"{uno}{cadena}";
        }

        public static string EliminarCaracteresEspeciales(string a)
        {
            try
            {
                a = Regex.Replace(a, "[^a-zA-Z0-9_.-]+", string.Empty, RegexOptions.Compiled);
                return a;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string Aleatoria(int largo)
        {
            Random random = new Random();
            string combinaciones = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            int longitud = combinaciones.Length;
            string nuevacadena = null;
            for (int i = 0; i < largo; i++)
            {
                char letra = combinaciones[random.Next(longitud)];
                nuevacadena += letra.ToString();
            }
            return nuevacadena;
        }

        public static string Depurar(string cadena)
        {
            cadena = HttpUtility.HtmlDecode(cadena);
            cadena = cadena.Replace("&#160;", string.Empty);
            cadena = cadena.Replace("&nbsp;", string.Empty);
            cadena = cadena.Trim();
            return cadena;
        }

        public static string GenerarIdString()
        {
            return Guid.NewGuid().ToString();
        }

        public static string GenerarToken()
        {
            return Guid.NewGuid().ToString();
        }

        public static bool Vacia(string a)
        {
            try
            {
                // Es nulo??
                if (a == null)
                {
                    return true;
                }

                // Depuramos
                a = Depurar(a);

                // IsNullOrEmpty
                if (string.IsNullOrEmpty(a))
                {
                    return true;
                }

                // IsNullOrWhiteSpace
                if (string.IsNullOrWhiteSpace(a))
                {
                    return true;
                }

                // Vacio
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}