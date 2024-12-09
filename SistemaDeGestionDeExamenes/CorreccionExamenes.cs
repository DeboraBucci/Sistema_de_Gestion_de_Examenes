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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                examenPreguntas.Clear();
                examenRespuestas.Clear();
                i = 0;
                nota = 0;
                respuestasCorrectas = 0;

                string nombreAlumno = txtNombreAlumno.Text.Trim();
                string apellidoAlumno = txtApellidoAlumno.Text.Trim();
                string examenId = cbExamenesId?.SelectedItem?.ToString() ?? "";

                if (nombreAlumno.Length <= 0)
                    throw new Exception("Por favor, ingrese un nombre.");

                if (apellidoAlumno.Length <= 0)
                    throw new Exception("Por favor, ingrese un apellido.");

                Examen? examen = ListaExamenes.Examenes.FirstOrDefault(ex => ex.Id == examenId);

                if (examen == null)
                    throw new Exception("Por favor ingrese una ID existente!");

                correccion.ExamenId = examen.Id;
                correccion.NombreAlumno = nombreAlumno;
                correccion.ApellidoAlumno = apellidoAlumno;

                gbRespuestas.Visible = true;

                foreach (PreguntaId pid in examen.PreguntasId)
                {
                    Pregunta? pregunta = ListaPreguntas.Preguntas.FirstOrDefault(p => p.PreguntaId == pid.Id);

                    if (pregunta != null)
                    {
                        examenPreguntas.Add(pregunta);
                    }
                }

                RefrescarRespuestaActual();
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void RefrescarRespuestaActual()
        {
            lblNumPregunta.Text = (i + 1) + ")";
            lblPreguntaTxt.Text = examenPreguntas[i].TxtPregunta;

            if (Convert.ToInt32(cbRespuestaSeleccionada?.SelectedItem?.ToString()) == examenPreguntas[i].OpcionCorrecta)
            {
                respuestasCorrectas++;
            }

            i++;
        }

        private void btnAgregarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                int rspSeleccionada = Convert.ToInt32(cbRespuestaSeleccionada.SelectedItem);
                examenRespuestas.Add(rspSeleccionada);
                correccion.Respuestas.Add(rspSeleccionada);
                MostrarEnLista();

                if (i < examenPreguntas.Count())
                    RefrescarRespuestaActual();

                else
                {
                    gbRespuestas.Visible = false;

                    nota = (100 * respuestasCorrectas) / (examenPreguntas.Count());

                    lblNota.Text = nota.ToString("F2");
                    lblRespuestasCorrectas.Text = respuestasCorrectas + " / " + examenRespuestas.Count();

                    correccion.Nota = nota.ToString();

                    btnGuardarCorreccion.Visible = true;
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void MostrarEnLista()
        {
            dgvRespuestas.Rows.Clear(); // Limpia las filas existentes

            int i = 0;
            foreach (var respuesta in examenRespuestas)
            {
                string[] fila = new string[10];

                fila[0] = examenPreguntas[i].TxtPregunta;
                fila[1] = examenPreguntas[i].OpcionCorrecta.ToString();
                fila[2] = respuesta.ToString();
                fila[3] = examenPreguntas[i].OpcionCorrecta == respuesta ? "Correcta" : "Incorrecta";

                dgvRespuestas.Rows.Add(fila);

                i++;
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
    }
}
