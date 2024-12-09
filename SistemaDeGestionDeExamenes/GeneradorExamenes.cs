using iText.Layout.Element;
using SistemaDeGestionDeExamenes.Clases;
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

        Examen examen;

        public GeneradorExamenes()
        {
            InitializeComponent();

            Menu.ConfigurarColumnasDataGridView(dgvPreguntas);
            dgvPreguntas.Columns["Asignatura"].Visible = false;

            try
            {
                if (ListaAsignaturas.Asignaturas != null && ListaAsignaturas.Asignaturas.Count > 0)
                {
                    foreach (var asignatura in ListaAsignaturas.Asignaturas)
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
            asignaturaElegida = ListaAsignaturas.Asignaturas[cbAsignaturas.SelectedIndex];

            lstUnidades.Items.Clear();

            foreach (Unidad unidad in asignaturaElegida.Unidades)
                lstUnidades.Items.Add(unidad.Nombre);
        }

        private void btnGenerarExamen_Click(object sender, EventArgs e)
        {
            int randomNum = 0;
            Random random = new Random();

            List<string> subUnidadesExcluidas = new List<string>();

            List<Pregunta> preguntasSubunid;

            examen = new Examen();
            examen.Asignatura = asignaturaElegida?.Nombre ?? "";
            lblAsignExamen.Text = asignaturaElegida?.Nombre ?? "";

            // Crea array con nombres de las unidades seleccionadas
            string[] unidadesStr = lstUnidades.SelectedItems.Cast<string>().ToArray();

            if (asignaturaElegida != null)
            {
                foreach (Unidad unidad in asignaturaElegida.Unidades)
                {
                    if (unidadesStr.Contains(unidad.Nombre))
                    {
                        foreach (SubUnidad subUnidad in unidad.SubUnidades)
                        {
                            preguntasSubunid = ListaPreguntas.Preguntas.Where(p =>
                                       p.Asignatura == asignaturaElegida.Nombre
                                       && p.Unidad == unidad.Nombre
                                       && p.SubUnidad == subUnidad.Nombre
                                       ).ToList();

                            if(preguntasSubunid.Count() > 0)
                            {
                                int max = preguntasSubunid.Count();
                                randomNum = random.Next(0, max);

                                examen.AgregarPreguntaId(preguntasSubunid[randomNum].PreguntaId);
                            }

                            else
                            {
                                subUnidadesExcluidas.Add(subUnidad.Nombre);
                            }
                        }

                        MetodosGenericos
                                .MostrarError(
                                $"De la unidad {unidad.Nombre}:\n\nLas unidades {string.Join(", ", subUnidadesExcluidas)} no contienen preguntas, asi que sera excluida del examen actual!"
                                );
                    }
                }
            }

            ListaExamenes.AgregarExamen(examen);
            Menu.MostrarPreguntasDGV(ListaExamenes.ObtenerPreguntasDeExamen(examen), dgvPreguntas);

        }

        private void GeneradorExamenes_Load(object sender, EventArgs e)
        {

        }
    }
}
