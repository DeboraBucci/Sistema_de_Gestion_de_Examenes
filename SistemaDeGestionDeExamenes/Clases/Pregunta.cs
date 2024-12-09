using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public class Pregunta
    {
        public string Asignatura { get; set; }
        public string Unidad { get; set; }
        public string SubUnidad { get; set; }
        public string PreguntaId { get; set; }
        public string TxtPregunta { get; set; }
        public string[] Opciones { get; set; } = new string[4];
        public int OpcionCorrecta { get; set; }

        public Pregunta() { }

        public Pregunta(
            string asignatura,
            string unidad,
            string subUnidad,
            string preguntaId,
            string txtPregunta,
            string[] opciones,
            int opcionCorrecta
            )
        {
            Asignatura = asignatura;
            Unidad = unidad;
            SubUnidad = subUnidad;
            PreguntaId = preguntaId;
            TxtPregunta = txtPregunta;
            Opciones = opciones;
            OpcionCorrecta = opcionCorrecta;
        }
    }
}
