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

        public static Asignatura? BuscarAsignatura(string nombreAsig)
        {
            return Asignaturas.FirstOrDefault(asig => asig.Nombre == nombreAsig);
        }

        public static Unidad? BuscarUnidad(Asignatura asignatura, string nombreUnid)
        {
            return asignatura.Unidades.FirstOrDefault(unid => unid.Nombre == nombreUnid);
        }

        public static SubUnidad? BuscarSubUnidad(Unidad unidad, string nombreSubunid)
        {
            return unidad.SubUnidades.FirstOrDefault(subunid => subunid.Nombre == nombreSubunid);
        }
    }
}
