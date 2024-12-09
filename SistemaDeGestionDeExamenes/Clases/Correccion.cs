using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public class Correccion
    {
        public string ExamenId { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string Nota { get; set; }

        public List<int> Respuestas { get; set; } = new List<int>();

    }
}
