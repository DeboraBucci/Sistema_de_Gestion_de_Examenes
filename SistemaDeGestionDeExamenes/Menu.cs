using System.Collections.Generic;
using SistemaDeGestionDeExamenes.Clases;

namespace SistemaDeGestionDeExamenes
{
    public partial class Menu : Form
    {
        public Form? currOpenedForm = null;

        AdministradorPreguntas administradorPreguntas = new AdministradorPreguntas();

        GeneradorExamenes generadorExamenes = new GeneradorExamenes();

        ImprimirExamenes imprimirExamenes = new ImprimirExamenes();

        CorreccionExamenes correccionExamenes = new CorreccionExamenes();

        Correcciones correcciones = new Correcciones
        {
            StartPosition = FormStartPosition.Manual,
            Location = new Point(0, 0),
        };

        public Menu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            AbrirForm(administradorPreguntas);
        }

        // MENU STRIP
        private void menuAdministrarBancoPreguntas_Click(object sender, EventArgs e)
        {
            AbrirForm(administradorPreguntas);
        }

        private void menuGenerarExamen_Click(object sender, EventArgs e)
        {
            AbrirForm(generadorExamenes);
        }

        private void menuImprimirExamen_Click(object sender, EventArgs e)
        {
            AbrirForm(imprimirExamenes);
        }

        private void menuCorregirExamen_Click(object sender, EventArgs e)
        {
            AbrirForm(correccionExamenes);
        }

        private void menuCorrecciones_Click(object sender, EventArgs e)
        {
            AbrirForm(correcciones);
        }
        
        private void AbrirForm(Form form)
        {
            EsconderFormulario();
            currOpenedForm = form;

            form.MdiParent = this;
            form.Show();
        }

        private void EsconderFormulario()
        {
            if (currOpenedForm != null)
            {
                currOpenedForm.Hide();
                currOpenedForm = null;
            }
        }

        // CONFIGURAR DATA GRID VIEW
        public static void ConfigurarColumnasDataGridView(DataGridView dgv)
        {
            dgv.Columns.Clear(); // Limpia las columnas existentes

            dgv.Columns.Add("Asignatura", "Asignatura");
            dgv.Columns.Add("Unidad", "Unidad");
            dgv.Columns.Add("SubUnidad", "SubUnidad");
            dgv.Columns.Add("TxtPregunta", "Pregunta");
            dgv.Columns.Add("OpcionCorrecta", "Opción Correcta");
            dgv.Columns.Add("PreguntaId", "PreguntaId");

            dgv.Columns.Add("Opcion1", "Opción 1");
            dgv.Columns.Add("Opcion2", "Opción 2");
            dgv.Columns.Add("Opcion3", "Opción 3");
            dgv.Columns.Add("Opcion4", "Opción 4");

            dgv.Columns["PreguntaId"].Visible = false;
        }

        public static void MostrarPreguntasDGV(List<Pregunta> pregs, DataGridView dgv)
        {
            dgv.Rows.Clear(); // Limpia las filas existentes

            foreach (var pregunta in pregs)
            {
                // Crea una fila para las columnas
                // ASIGNATURA | UNIDAD | SUBUNIDAD | PREGUNTA | OPC CORRECTA | OPC 1 | OPC 2 | OPC 3 | OPC 4
                string[] fila = new string[10];

                fila[0] = pregunta.Asignatura;
                fila[1] = pregunta.Unidad;
                fila[2] = pregunta.SubUnidad;
                fila[3] = pregunta.TxtPregunta;
                fila[4] = pregunta.OpcionCorrecta.ToString();
                fila[5] = pregunta.PreguntaId;

                // Llena las columnas de opciones
                for (int i = 0; i < 4; i++)
                {
                    fila[6 + i] = (i < pregunta.Opciones.Length) ? pregunta.Opciones[i] : "";
                }

                dgv.Rows.Add(fila);
            }
        }
     
    }
}
