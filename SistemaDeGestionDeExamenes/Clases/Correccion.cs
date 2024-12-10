namespace SistemaDeGestionDeExamenes.Clases
{
    public class Correccion
    {
        public string CorreccionId { get; set; } = MetodosGenericos.CrearId();
        public string ExamenId { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string Nota { get; set; }

        public List<int> Respuestas { get; set; } = new List<int>();
    }
}
