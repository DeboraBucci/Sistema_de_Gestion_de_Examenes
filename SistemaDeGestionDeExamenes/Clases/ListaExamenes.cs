using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public static class ListaExamenes
    {
        private static string archivoExamen = "examen.json";
        public static List<Examen> Examenes { get;  private set; } = 
            JsonHelper.LeerDesdeArchivo<Examen>(archivoExamen);

        public static void AgregarExamen(Examen examen)
        {
            Examenes.Add(examen);
            GuardarEnArchivo();
        }

        public static List<Pregunta> ObtenerPreguntasDeExamen(Examen examen)
        {
            List<Pregunta> preguntasExamen = new List<Pregunta>();

            if (examen != null)
            {
                preguntasExamen =
                    ListaPreguntas.Preguntas
                    .FindAll(p =>
                        examen.PreguntasId
                        .Any(pId => pId.Id == p.PreguntaId));
            }

            return preguntasExamen;
        }

        public static void EliminarExamen(string examenId)
        {
            Examenes = Examenes.Where(ex => ex.Id != examenId).ToList();
            GuardarEnArchivo();
        }

        public static void GuardarEnArchivo()
        {
            JsonHelper.GuardarEnArchivo(Examenes, archivoExamen);
        }
    }
}
