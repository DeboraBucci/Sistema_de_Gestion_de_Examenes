using System.Text.Json;

namespace SistemaDeGestionDeExamenes.Clases
{
    public class JsonHelper
    {
        public static List<T> LeerDesdeArchivo<T>(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string json = reader.ReadToEnd();

                        // Deserializar el JSON a una lista de asignaturas
                        return JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        }) ?? new List<T>();
                    }
                }

                return new List<T>();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                return new List<T>();
            }
        }

        public static void GuardarEnArchivo<T>(List<T> lista, string path)
        {
            try
            {
                // Serializar la lista de preguntas a JSON
                string json =
                    JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });

                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar: {ex.Message}");
            }
        }

    }
}
