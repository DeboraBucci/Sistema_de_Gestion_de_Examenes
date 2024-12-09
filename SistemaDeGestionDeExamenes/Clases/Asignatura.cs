using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public List<Unidad> Unidades { get; set; } = new List<Unidad>();
    }

    public class Unidad
    {
        public string Nombre { set; get; }
        public List<SubUnidad> SubUnidades { get; set; } = new List<SubUnidad>();

    }

    public class SubUnidad
    {
        public string Nombre { set; get; }

    }
}
