using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionDeExamenes
{
    public partial class ImprimirExamenes : Form
    {
        public ImprimirExamenes()
        {
            InitializeComponent();

            MostrarExamenesEnTreeView();
        }

        public void MostrarExamenesEnTreeView()
        {
            tvExamenes.Nodes.Clear(); // Limpiar el TreeView antes de llenarlo

            foreach (var examen in Form1.Examenes)
            {
                // Crear nodo principal para cada examen
                TreeNode nodoExamen = new TreeNode($"{examen.Asignatura} - {examen.Id}");

                // Añadir subnodos para las preguntas de cada examen
                for (int i = 0; i < examen.PreguntasId.Count; i++)
                {
                    var preguntaId = examen.PreguntasId[i].Id;
                    var pregunta = Form1.Preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);

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

                Examen? examen = Form1.Examenes.FirstOrDefault(ex => ex.Id == examenId);

                if (examen != null)
                {
                    // Llamar al método de impresión
                    ImprimirPdf.GenerarPdf(examen);
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
    }
}
