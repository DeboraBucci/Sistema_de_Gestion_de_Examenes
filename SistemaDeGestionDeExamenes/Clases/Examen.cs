namespace SistemaDeGestionDeExamenes.Clases
{
    public class Examen
    {
        public string Id { get; set; } = MetodosGenericos.CrearId();
        public string Fecha { get; set; }
        public string Asignatura { get; set; }

        public List<PreguntaId> PreguntasId { get; set; } = new List<PreguntaId>();

        public void AgregarPreguntaId(string id)
        {
            PreguntasId.Add(new PreguntaId(id));
        }

        public List<PreguntaId> ObtenerPreguntasId()
        {
            return PreguntasId;
        }
    }

    public class PreguntaId
    {
        public string Id { get; set; }

        public PreguntaId(string id)
        {
            Id = id;
        }
    }
}
