using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes
{
    public class Examen
    {
        public string Id { get; set; }
        public string Fecha { get; set; }
        public string Asignatura { get; set; }

        public List<PreguntaId> IdPreguntas { get; set; }

        private List<Pregunta> Preguntas = new List<Pregunta>();

        public Examen() { }

        public Examen(
            string fecha,
            string asignatura
            )
        {
            Asignatura = asignatura;
            Fecha = fecha;
            Id = Guid.NewGuid().ToString();
        }

        public void addPregunta(Pregunta pregunta)
        {
            Preguntas.Add(pregunta);
        }

        public List<Pregunta> getPreguntas()
        {
            return Preguntas;
        }

    }


    public class PreguntaId
    {
        public string Id { get; set; }
    }
}
