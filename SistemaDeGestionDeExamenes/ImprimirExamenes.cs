using SistemaDeGestionDeExamenes.Clases;

namespace SistemaDeGestionDeExamenes
{
    public partial class ImprimirExamenes : Form
    {
        public ImprimirExamenes()
        {
            InitializeComponent();
            MostrarExamenesEnTreeView();
        }

        private void ImprimirExamenes_VisibleChanged(object sender, EventArgs e)
        {
            MostrarExamenesEnTreeView();
        }

        private void btnImprimirExamen_Click(object sender, EventArgs e)
        {
            if (tvExamenes.SelectedNode == null)
            {
                MetodosGenericos.MostrarError("Por favor, selecciona un examen para imprimir.");
                return;
            }

            // Verificar si el nodo seleccionado es un examen (no una pregunta)
            if (tvExamenes.SelectedNode.Parent == null)
            {
                // Extraer el ID del examen desde el texto del nodo
                string examenInfo = tvExamenes.SelectedNode.Text;
                string examenId = examenInfo.Split(" - ")[1].Trim(); // Extraer la parte después del guion

                Examen? examen = ListaExamenes.Examenes.FirstOrDefault(ex => ex.Id == examenId);

                if (examen != null)
                {
                    // Llamar al método de impresión
                    ImprimirPdf generadorPdf = new ImprimirPdf();
                    generadorPdf.GenerarPdf(examen);
                }
                else
                {
                    MetodosGenericos.MostrarError("Examen no encontrado.");
                }
            }
            else
            {
                MetodosGenericos.MostrarError("Por favor, seleccione un examen (no una pregunta) para imprimir.");
            }
        }

        private void btnEliminarExamen_Click(object sender, EventArgs e)
        {
            if (tvExamenes.SelectedNode != null && tvExamenes.Parent != null)
            {
                DialogResult result =
                MessageBox.Show("¿Estás seguro de que deseas eliminar este examen?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EliminarExamen();
                    MessageBox.Show("Examen Eliminado!", "Exitoso", MessageBoxButtons.OK);
                    MostrarExamenesEnTreeView();
                }
            }

            else
            {
                MetodosGenericos.MostrarError("Por favor, seleccione un examen, no una pregunta, para eliminar.");
            }
        }

        private void EliminarExamen()
        {
            string examenInfo = tvExamenes.SelectedNode.Text;
            string examenId = examenInfo.Split(" - ")[1].Trim();

            ListaExamenes.EliminarExamen(examenId);
        }

        public void MostrarExamenesEnTreeView()
        {
            tvExamenes.Nodes.Clear(); // Limpiar el TreeView antes de llenarlo

            foreach (Examen examen in ListaExamenes.Examenes)
            {
                // Crear nodo principal para cada examen
                TreeNode nodoExamen = new TreeNode($"{examen.Asignatura} - {examen.Id}");

                // Añadir subnodos para las preguntas de cada examen
                for (int i = 0; i < examen.PreguntasId.Count; i++)
                {
                    var preguntaId = examen.PreguntasId[i].Id;
                    var pregunta = ListaPreguntas.EncontrarPregunta(preguntaId);

                    if (pregunta != null)
                    {
                        TreeNode nodoPregunta = new TreeNode($"Pregunta {i + 1}: {pregunta.TxtPregunta}");
                        nodoExamen.Nodes.Add(nodoPregunta); // Añadir la pregunta como subnodo
                    }
                }

                tvExamenes.Nodes.Add(nodoExamen); // Añadir el examen al TreeView
            }

            tvExamenes.ExpandAll();
        }
    }
}
