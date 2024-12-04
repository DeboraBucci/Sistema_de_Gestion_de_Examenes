
using System.Collections.Generic;

namespace SistemaDeGestionDeExamenes
{
    public partial class Form1 : Form
    {
        public static string archivoExamen = "examen.json";
        public static string archivoCorreciones = "correcciones.json";
        public static string archivoPreguntas = "preguntas.json";
        public static string archivoAsignaturas = "asignaturas.json";

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            AdministradorPreguntas administradorPreguntas = new AdministradorPreguntas();
            administradorPreguntas.MdiParent = this;
            administradorPreguntas.Show();
        }

        // MENU
        private void btnAdministrarBancoPreguntas_Click(object sender, EventArgs e)
        {
            AdministradorPreguntas administradorPreguntas = new AdministradorPreguntas();
            administradorPreguntas.MdiParent = this;
            administradorPreguntas.Show();
        }

        private void btnGenerarExamenes_Click(object sender, EventArgs e)
        {
        }

        private void btnCorregirExamenes_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirExamenes_Click(object sender, EventArgs e)
        {

        }


        // GENERADOR DE PREGUNTAS
        /*private void btnElegirUnidades_Click(object sender, EventArgs e)
        {
            List<string> unidadesSeleccionadas = new List<string>();

            foreach (var item in lstUnidades.SelectedItems)
            {
                if (item != null)
                    unidadesSeleccionadas.Add(item.ToString() + "");
            }

            if (unidadesSeleccionadas.Count > 1)
            {
                MessageBox.Show(unidadesSeleccionadas[0] + " " + unidadesSeleccionadas[1]);
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
