using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public static class ListaCorrecciones
    {
        private static string archivoCorrecciones = "correcciones.json";

        public static List<Correccion> Correcciones { get; private set; } =
            JsonHelper.LeerDesdeArchivo<Correccion>(archivoCorrecciones);

        public static void GuardarCorreccion (Correccion correccion)
        {
            Correcciones.Add(correccion);
            GuardarEnArchivo();
        }

        public static void GuardarEnArchivo()
        {
            JsonHelper.GuardarEnArchivo(Correcciones, archivoCorrecciones);
        }
    }
}
