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
    public partial class GeneradorExamenes : Form
    {
        private Asignatura? asignaturaElegida;

        List<Pregunta> preguntasFiltradas = new List<Pregunta>();

        public GeneradorExamenes()
        {
            InitializeComponent();

            Form1.ConfigurarColumnasDataGridView(dgvPreguntas);

            try
            {
                if (Form1.Asignaturas != null && Form1.Asignaturas.Count > 0)
                {
                    foreach (var asignatura in Form1.Asignaturas)
                    {
                        cbAsignaturas.Items.Add(asignatura.Nombre);
                    }
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }

        }

        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignaturaElegida = Form1.Asignaturas[cbAsignaturas.SelectedIndex];

            lstUnidades.Items.Clear();

            foreach (Unidad unidad in asignaturaElegida.Unidades)
                lstUnidades.Items.Add(unidad.Nombre);
        }


        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {
            int randomNum = 0;

            Random random = new Random();
            List<Pregunta> preguntas;

            string[] unidadesStr = lstUnidades.SelectedItems.Cast<String>().ToArray();

            preguntasFiltradas.Clear();

            if (asignaturaElegida != null)
            {
                foreach (Unidad unidad in asignaturaElegida?.Unidades)
                {
                    foreach (SubUnidad subUnidad in unidad.SubUnidades)
                    {
                        preguntas = Form1.Preguntas.Where(p =>
                                   p.Asignatura == asignaturaElegida.Nombre
                                   && p.Unidad == unidad.Nombre
                                   && p.SubUnidad == subUnidad.Nombre
                                   ).ToList();

                        int max = preguntas.Count();

                        randomNum = random.Next(0, max);
                        preguntasFiltradas.Add(preguntas[randomNum]);
                    }
                }
            }
                
            Form1.MostrarPreguntasDGV(preguntasFiltradas, dgvPreguntas);
        }
    }
}
