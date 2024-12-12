using SistemaDeGestionDeExamenes.Clases;

namespace SistemaDeGestionDeExamenes
{
    public partial class CorreccionExamenes : Form
    {
        List<Pregunta> examenPreguntas = new List<Pregunta>();
        List<int> examenRespuestas = new List<int>();

        Correccion correccion = new Correccion();

        double nota = 0;
        int i = 0;
        int respuestasCorrectas = 0;

        public CorreccionExamenes()
        {
            InitializeComponent();
        }

        private void CorreccionExamenes_Load(object sender, EventArgs e)
        {
            RefrescarInformacion();
        }

        private void CorreccionExamenes_VisibleChanged(object sender, EventArgs e)
        {
            RefrescarInformacion();
        }

        private void RefrescarInformacion()
        {
            VaciarInformacion();
            cbExamenesId.Items.Clear();

            foreach (Examen examen in ListaExamenes.Examenes)
            {
                cbExamenesId.Items.Add(examen.Id);
            }
        }

        private void btnIngresarPreguntas_Click(object sender, EventArgs e)
        {
            try
            {
                VaciarInformacion();

                string nombreAlumno = txtNombreAlumno.Text.Trim();
                string apellidoAlumno = txtApellidoAlumno.Text.Trim();

                if (nombreAlumno.Length <= 0)
                    throw new Exception("Por favor, ingrese un nombre.");

                if (apellidoAlumno.Length <= 0)
                    throw new Exception("Por favor, ingrese un apellido.");

                // Buscar examen
                string examenId = cbExamenesId?.SelectedItem?.ToString() ?? "";
                Examen? examen = ListaExamenes.Examenes.FirstOrDefault(ex => ex.Id == examenId);

                if (examen == null)
                    throw new Exception("Por favor ingrese una ID existente!");

                // Llenar informacion en correcion
                correccion.ExamenId = examen.Id;
                correccion.NombreAlumno = nombreAlumno;
                correccion.ApellidoAlumno = apellidoAlumno;

                // Llenar respuestas
                gbRespuestas.Visible = true;
                foreach (PreguntaId pid in examen.PreguntasId)
                {
                    Pregunta? pregunta = ListaPreguntas.Preguntas.FirstOrDefault(p => p.PreguntaId == pid.Id);

                    if (pregunta != null)
                    {
                        examenPreguntas.Add(pregunta);
                    }
                }

                MostrarPreguntaYRespuestaActual();
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void btnAgregarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                string rspSeleccionadaStr = cbRespuestaSeleccionada?.SelectedItem?.ToString() ?? "";

                if (!int.TryParse(rspSeleccionadaStr, out int rspSeleccionada))
                {
                    rspSeleccionadaStr = "0";
                }

                if (rspSeleccionada == examenPreguntas[i - 1].OpcionCorrecta)
                    respuestasCorrectas++;

                examenRespuestas.Add(rspSeleccionada);
                correccion.Respuestas.Add(rspSeleccionada);
                MostrarEnLista();

                if (i < examenPreguntas.Count())
                    MostrarPreguntaYRespuestaActual();

                else
                {
                    gbRespuestas.Visible = false;

                    nota = (100.0 * respuestasCorrectas) / examenPreguntas.Count();

                    lblNota.Text = nota.ToString("F2");
                    correccion.Nota = nota.ToString("F2");

                    btnGuardarCorreccion.Visible = true;
                }

                lblRespuestasCorrectas.Text = respuestasCorrectas + " / " + examenPreguntas.Count();
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void btnGuardarCorreccion_Click(object sender, EventArgs e)
        {
            ListaCorrecciones.GuardarCorreccion(correccion);

            txtApellidoAlumno.Text = "";
            txtNombreAlumno.Text = "";

            btnGuardarCorreccion.Visible = false;

            dgvRespuestas.Rows.Clear();

            MessageBox.Show("Correccion guardada exitosamente!", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbExamenesId_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbRespuestas.Visible = false;
        }

        // METODOS  
        private void MostrarEnLista()
        {
            dgvRespuestas.Rows.Clear();

            int i = 0;
            foreach (var respuesta in examenRespuestas)
            {
                string[] fila = new string[10];

                fila[0] = examenPreguntas[i].TxtPregunta;
                fila[1] = examenPreguntas[i].OpcionCorrecta.ToString();
                fila[2] = respuesta.ToString();
                fila[3] = examenPreguntas[i].OpcionCorrecta == respuesta ? "Correcta" : respuesta == 0 ? "Sin Responder" : "Incorrecta";

                dgvRespuestas.Rows.Add(fila);

                i++;
            }
        }

        private void MostrarPreguntaYRespuestaActual()
        {
            lblNumPregunta.Text = (i + 1) + ")";
            lblPreguntaTxt.Text = examenPreguntas[i].TxtPregunta;

            i++;
        }

        private void VaciarInformacion()
        {
            examenPreguntas.Clear();
            examenRespuestas.Clear();

            i = 0;
            nota = 0;
            respuestasCorrectas = 0;

            correccion = new Correccion();
        }
    }
}
