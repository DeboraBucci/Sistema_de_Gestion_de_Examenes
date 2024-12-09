using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public static class ListaAsignaturas
    {
        private static string archivoAsignaturas = "asignaturas.json";
        public static List<Asignatura> Asignaturas { get; private set; } = 
            JsonHelper.LeerDesdeArchivo<Asignatura>(archivoAsignaturas);

        public static void AgregarAsignatura(Asignatura asignatura)
        {
            Asignaturas.Add(asignatura);
            GuardarEnArchivo();
        }

        public static void GuardarEnArchivo()
        {
            JsonHelper.GuardarEnArchivo(Asignaturas, archivoAsignaturas);
        }
    }
}
