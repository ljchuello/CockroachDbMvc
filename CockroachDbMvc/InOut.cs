using System.Text;

namespace CockroachDbMvc
{
    public class InOut
    {
        public static string Generar(string tabla, List<Estructura> campos)
        {
            int iteracion = 0;
            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var row in campos)
                {
                    stringBuilder.AppendLine($"oOut.{row.Nombre} = oIn.{row.Nombre};");
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
