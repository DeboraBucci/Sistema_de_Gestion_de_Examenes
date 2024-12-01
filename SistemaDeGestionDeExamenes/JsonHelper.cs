using System.Text.Json;

namespace SistemaDeGestionDeExamenes
{
    public class JsonHelper
    {
        public static List<Asignatura> LeerAsignaturas(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string json = reader.ReadToEnd();

                        // Deserializar el JSON a una lista de asignaturas
                        return JsonSerializer.Deserialize<List<Asignatura>>(json, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        }) ?? new List<Asignatura>();
                    }
                }

                return new List<Asignatura>();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo JSON: {ex.Message}");
                return new List<Asignatura>();
            }
        }

        public static List<Pregunta> LeerPreguntas(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string json = reader.ReadToEnd();

                        return JsonSerializer
                            .Deserialize<List<Pregunta>>
                            (json,
                            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                            )
                            ?? new List<Pregunta>(); // caso de que sea null
                    }
                }

                return new List<Pregunta>();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer las preguntas desde el archivo: {ex.Message}");
                return new List<Pregunta>();
            }
        }

        public static void GuardarEnArchivo(List<Pregunta> lista, string path)
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
