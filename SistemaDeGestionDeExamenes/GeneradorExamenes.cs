using SistemaDeGestionDeExamenes.Clases;
using System.Data;

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
        }

        private void GeneradorExamenes_Load(object sender, EventArgs e)
        {
            RecargarDatos();
        }

        private void GeneradorExamenes_Shown(object sender, EventArgs e)
        {
            RecargarDatos();
        }

        private void GeneradorExamenes_VisibleChanged(object sender, EventArgs e)
        {
            RecargarDatos();
        }

        private void RecargarDatos()
        {
            lblSubUnidadesSinPreguntasTitulo.Visible = false;
            lblSubUnidadesSinPreguntas.Text = "";
            dgvPreguntas.Rows.Clear();
            lstUnidades.Items.Clear();

            cbAsignaturas.Items.Clear();
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
            try
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
                            subUnidadesExcluidas.Clear();

                            foreach (SubUnidad subUnidad in unidad.SubUnidades)
                            {
                                preguntasSubunid = ListaPreguntas.Preguntas.Where(p =>
                                           p.Asignatura == asignaturaElegida.Nombre
                                           && p.Unidad == unidad.Nombre
                                           && p.SubUnidad == subUnidad.Nombre
                                           ).ToList();

                                if (preguntasSubunid.Count() > 0)
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

                            if (subUnidadesExcluidas.Count() > 0)
                            {
                                MetodosGenericos
                                    .MostrarError(
                                    $"De la unidad {unidad.Nombre}:\n\nLas sub unidades {string.Join(", ", subUnidadesExcluidas)} no contienen preguntas, asi que sera excluida del examen actual!"
                                    );

                                lblSubUnidadesSinPreguntas.Text += $"{string.Join(", ", subUnidadesExcluidas)}\n";
                                lblSubUnidadesSinPreguntasTitulo.Visible = true;
                            }
                        }
                    }
                }

                if (examen.PreguntasId.Count >= 4)
                {
                    ListaExamenes.AgregarExamen(examen);
                    Menu.MostrarPreguntasDGV(ListaExamenes.ObtenerPreguntasDeExamen(examen), dgvPreguntas);
                }
                else
                {
                    throw new Exception("No se ha generado el examen:\nNo hay suficientes preguntas sobre los temas elegidos (al menos 4), por favor, agrega mas!");
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }
    }
}
