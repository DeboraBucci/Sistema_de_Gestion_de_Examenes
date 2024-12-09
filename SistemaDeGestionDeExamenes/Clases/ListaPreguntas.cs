using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public static class ListaPreguntas
    {
        private static string archivoPreguntas = "preguntas.json";
        public static List<Pregunta> Preguntas { get; private set; } =
            JsonHelper.LeerDesdeArchivo<Pregunta>(archivoPreguntas);

        public static void AgregarPregunta(Pregunta pregunta)
        {
            Preguntas.Add(pregunta);
            GuardarEnArchivo();
        }

        public static void EliminarPregunta(string id)
        {
            Preguntas = Preguntas
                .Where(pregunta => pregunta.PreguntaId != id)
                .ToList();
            GuardarEnArchivo();
        }

        public static Pregunta? EncontrarPregunta(string id)
        {
            return Preguntas.Find(pregunta => pregunta.PreguntaId == id);
        }

        public static void GuardarEnArchivo()
        {
            JsonHelper.GuardarEnArchivo(Preguntas, archivoPreguntas);
        }
    }
}
