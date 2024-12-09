using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes.Clases
{
    public class MetodosGenericos
    {
        public static void MostrarError(string msg)
        {
            MessageBox.Show(
                msg,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static string CrearId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
