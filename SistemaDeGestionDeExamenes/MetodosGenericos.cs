using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeExamenes
{
    public class MetodosGenericos
    {
        public static void MostrarError(String msg)
        {
            MessageBox.Show(
                msg,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
