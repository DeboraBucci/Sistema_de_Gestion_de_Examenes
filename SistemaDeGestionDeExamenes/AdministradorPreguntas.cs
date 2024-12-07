﻿using System;
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
    public partial class AdministradorPreguntas : Form
    {
        private List<Pregunta> preguntasFiltradas = new List<Pregunta>();

        private List<string> filtroAsignaturas = new List<string>();
        private List<string> filtroUnidades = new List<string>();

        private Pregunta? preguntaAEditar = null;

        public AdministradorPreguntas()
        {
            InitializeComponent();

            InitUI();
        }

        private void InitUI()
        {
            Form1.ConfigurarColumnasDataGridView(dgvPreguntas);
            AgregarAsignaturasADropdown();
            Form1.MostrarPreguntasDGV(Form1.Preguntas, dgvPreguntas);
            InicializarFiltroAsignaturas();
        }

        // EVENTOS

        // AGREGAR PREGUNTAS
        private void btnAgregarPreg_Click(object sender, EventArgs e)
        {
            Form1.AgregarPregunta(CrearPregunta());

            Form1.MostrarPreguntasDGV(Form1.Preguntas, dgvPreguntas);
            VaciarFormulario();
        }
        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarUnidadesDropdown();
        }

        private void cbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarSubUnidadesDropdown();
        }


        // EDITAR PREGUNTA
        private void btnEditarPreg_Click(object sender, EventArgs e)
        {
            string preguntaId = IdPreguntaSeleccionada();

            LlenarFormularioConPreguntaSeleccionada(preguntaId);
            VisibilidadBotonesEditar(true);
        }

        private void btnAceptarCambios_Click(object sender, EventArgs e)
        {
            if (preguntaAEditar != null)
            {
                Pregunta pregunta = CrearPregunta();

                preguntaAEditar.Asignatura = pregunta.Asignatura;
                preguntaAEditar.Unidad = pregunta.Unidad;
                preguntaAEditar.SubUnidad = pregunta.SubUnidad;
                preguntaAEditar.TxtPregunta = pregunta.TxtPregunta;
                preguntaAEditar.Opciones[0] = pregunta.Opciones[0];
                preguntaAEditar.Opciones[1] = pregunta.Opciones[1];
                preguntaAEditar.Opciones[2] = pregunta.Opciones[2];
                preguntaAEditar.Opciones[3] = pregunta.Opciones[3];
                preguntaAEditar.OpcionCorrecta = pregunta.OpcionCorrecta;

                Form1.GuardarPreguntasArchivo();
                Form1.MostrarPreguntasDGV(Form1.Preguntas, dgvPreguntas);

                VisibilidadBotonesEditar(false);
                VaciarFormulario();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciarFormulario();
        }

        // ELIMINAR PREGUNTAS
        private void btnEliminarPreg_Click(object sender, EventArgs e)
        {
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                string preguntaId = IdPreguntaSeleccionada();

                Form1.EliminarPregunta(preguntaId);
                Form1.MostrarPreguntasDGV(Form1.Preguntas, dgvPreguntas);
            }
        }

        // FILTRO
        private void cbFiltroAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarFiltroUnidades();

            List<Pregunta> preguntasFiltradas =
                Form1
                .Preguntas
                .Where(preg =>
                {
                    if (cbFiltroAsignatura.SelectedIndex != 0)
                        return preg.Asignatura == cbFiltroAsignatura?.SelectedItem?.ToString();

                    return true; // devuelve todo si se selecciona el index 0 en el combobox

                }).ToList();

            Form1.MostrarPreguntasDGV(preguntasFiltradas, dgvPreguntas);
        }

        private void cbFiltroUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Pregunta> preguntasFiltradas =
                Form1
                .Preguntas
                .Where(preg =>
                {
                    if (cbFiltroUnidad.SelectedIndex != 0)
                        return preg.Unidad == cbFiltroUnidad?.SelectedItem?.ToString();

                    return true; // devuelve todo en index 0

                }).ToList();

            Form1.MostrarPreguntasDGV(preguntasFiltradas, dgvPreguntas);
        }

        // CREAR ASIGNATURAS, UNIDADES, SUBUNIDADES
        private void lblCrearAsignatura_Click(object sender, EventArgs e)
        {
        }

        private void lblCrearUnidad_Click(object sender, EventArgs e)
        {
        }

        private void lblCrearSubunidad_Click(object sender, EventArgs e)
        {
            pnlCrearNuevaSubUnidad.Visible = true;

            if (Form1.Preguntas != null && Form1.Preguntas.Count > 0)
            {
                foreach (Asignatura asignatura in Form1.Asignaturas)
                {
                    cbAsignaturaNuevaSubUnidad.Items.Add(asignatura.Nombre);
                }
            }
        }

        private void btnCancelarNuevaSubUnidad_Click(object sender, EventArgs e)
        {
            pnlCrearNuevaSubUnidad.Visible = false;
        }

        private void btnCrearNuevaSubUnidad_Click(object sender, EventArgs e)
        {
            string? asignaturaTxt = cbAsignaturaNuevaSubUnidad?.SelectedItem?.ToString();
            string? unidadTxt = cbUnidadesNuevaSubunidad?.SelectedItem?.ToString();

            SubUnidad nuevaSubUnidad = new SubUnidad();
            nuevaSubUnidad.Nombre = txtNuevaSubUnidad.Text;

            foreach (Asignatura asig in Form1.Asignaturas)
            {
                foreach (Unidad unid in asig.Unidades)
                {
                    lblAsignatura.Text = asig.Nombre + " " + unid.Nombre;
                    if (asig.Nombre == asignaturaTxt && unid.Nombre == unidadTxt)
                        unid.SubUnidades.Add(nuevaSubUnidad);
                }
            }

            pnlCrearNuevaSubUnidad.Visible = false;
            Form1.GuardarAsignaturasArchivo();
        }

        private void cbAsignaturaNuevaSubUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? asignTxt = cbAsignaturaNuevaSubUnidad?.SelectedItem?.ToString();

            Asignatura? asignatraElegida = 
                Form1.Asignaturas
                     .FirstOrDefault(asig => asig.Nombre == asignTxt);

            foreach (Unidad unidad in asignatraElegida?.Unidades ?? [])
            {
                cbUnidadesNuevaSubunidad?.Items.Add(unidad.Nombre);
            }
        }
        
        private void cbUnidadesNuevaSubunidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // METODOS GENERALES
        private Pregunta CrearPregunta(string? preguntaId = null)
        {
            if (preguntaId == null)
                preguntaId = Guid.NewGuid().ToString();

            string asignatura = cbAsignaturas?.SelectedItem?.ToString() + "";
            string unidad = cbUnidades?.SelectedItem?.ToString() + "";
            string subunidad = cbSubUnidades?.SelectedItem?.ToString() + "";

            string textPregunta = txtPregunta.Text.Trim();
            string textOpc1 = txtOpc1.Text.Trim();
            string textOpc2 = txtOpc2.Text.Trim();
            string textOpc3 = txtOpc3.Text.Trim();
            string textOpc4 = txtOpc4.Text.Trim();

            int opcionCorrecta = 1;

            if (rbOpc1.Checked)
                opcionCorrecta = 1;

            else if (rbOpc2.Checked)
                opcionCorrecta = 2;

            else if (rbOpc3.Checked)
                opcionCorrecta = 3;

            else if (rbOpc4.Checked)
                opcionCorrecta = 4;

            Pregunta pregunta = new Pregunta(
                asignatura,
                unidad,
                subunidad,
                preguntaId,
                textPregunta,
                [textOpc1, textOpc2, textOpc3, textOpc4],
                opcionCorrecta
                );

            return pregunta;
        }

  

        private string IdPreguntaSeleccionada()
        {
            DataGridViewRow row = dgvPreguntas.SelectedRows[0]; // Accedemos a la primera fila seleccionada

            return row.Cells["PreguntaId"].Value.ToString() + "";
        }

        private void LlenarFormularioConPreguntaSeleccionada(string preguntaId)
        {
            preguntaAEditar = Form1.EncontrarPregunta(preguntaId);

            int indexAsignatura =
                Form1.Asignaturas?
                .FindIndex(asig => asig.Nombre.Equals(preguntaAEditar?.Asignatura))
                ?? 0;

            cbAsignaturas.SelectedIndex = indexAsignatura;

            Asignatura? asignaturaSeleccionada = Form1.Asignaturas?[cbAsignaturas.SelectedIndex];

            int indexUnidad = asignaturaSeleccionada?
                .Unidades
                .FindIndex(unid => unid.Nombre.Equals(preguntaAEditar?.Unidad))
                ?? 0;

            cbUnidades.SelectedIndex = indexUnidad;

            Unidad? unidadSeleccionada = asignaturaSeleccionada?.Unidades?[cbUnidades.SelectedIndex];

            int indexSubUnidad =
                unidadSeleccionada?
                .SubUnidades
                .FindIndex(subUni => subUni.Nombre.Equals(preguntaAEditar?.SubUnidad))
                ?? 0;

            cbSubUnidades.SelectedIndex = indexSubUnidad;

            txtPregunta.Text = preguntaAEditar?.TxtPregunta;
            txtOpc1.Text = preguntaAEditar?.Opciones[0];
            txtOpc2.Text = preguntaAEditar?.Opciones[1];
            txtOpc3.Text = preguntaAEditar?.Opciones[2];
            txtOpc4.Text = preguntaAEditar?.Opciones[3];

            if (preguntaAEditar?.OpcionCorrecta == 1)
                rbOpc1.Checked = true;

            else if (preguntaAEditar?.OpcionCorrecta == 2)
                rbOpc2.Checked = true;

            else if (preguntaAEditar?.OpcionCorrecta == 3)
                rbOpc3.Checked = true;
        }

        private void AgregarAsignaturasADropdown()
        {
            try
            {
                if (Form1.Asignaturas != null && Form1.Asignaturas.Count > 0)
                {
                    foreach (var asignatura in Form1.Asignaturas)
                    {
                        cbAsignaturas.Items.Add(asignatura.Nombre); // llena dropdown de asignaturas
                    }
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void VaciarFormulario()
        {
            cbAsignaturas.SelectedIndex = -1;
            cbUnidades.SelectedIndex = -1;
            cbSubUnidades.SelectedIndex = -1;

            txtPregunta.Text = "";

            txtOpc1.Text = "";
            txtOpc2.Text = "";
            txtOpc3.Text = "";
            txtOpc4.Text = "";

            rbOpc1.Checked = true;
            rbOpc2.Checked = false;
            rbOpc3.Checked = false;
            rbOpc4.Checked = false;
        }

        private void VisibilidadBotonesEditar(bool visible)
        {
            btnAceptarCambios.Visible = visible;
            btnCancelar.Visible = visible;

            btnAgregarPreg.Visible = !visible;
            btnEditarPreg.Visible = !visible;
            btnEliminarPreg.Visible = !visible;
        }

        private void CambiarUnidadesDropdown()
        {
            try
            {
                if (Form1.Asignaturas.Count > 0 && cbAsignaturas.SelectedIndex >= 0)
                {
                    Asignatura? asignaturaSeleccionada = Form1.Asignaturas?[cbAsignaturas.SelectedIndex];

                    if (asignaturaSeleccionada != null)
                    {
                        cbUnidades.Items.Clear();
                        cbUnidades.Text = "";

                        cbSubUnidades.Items.Clear();
                        cbSubUnidades.Text = "";

                        foreach (var unidad in asignaturaSeleccionada.Unidades)
                        {
                            cbUnidades.Items.Add(unidad.Nombre); // llena el dropdown de unidades
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void CambiarSubUnidadesDropdown()
        {
            try
            {
                if (Form1.Asignaturas.Count > 0 && cbAsignaturas.SelectedIndex >= 0 && cbUnidades.SelectedIndex >= 0)
                {
                    Unidad? unidadSeleccionada = null;

                    unidadSeleccionada = Form1.Asignaturas?[cbAsignaturas.SelectedIndex].
                                         Unidades[cbUnidades.SelectedIndex];

                    if (unidadSeleccionada != null)
                    {
                        cbSubUnidades.Items.Clear();
                        cbSubUnidades.Text = "";

                        foreach (var subUnidad in unidadSeleccionada.SubUnidades)
                        {
                            cbSubUnidades.Items.Add(subUnidad.Nombre);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }

        private void InicializarFiltroAsignaturas()
        {
            cbFiltroAsignatura.Items.Clear();

            filtroAsignaturas =
                Form1.Asignaturas?.Select(a => a.Nombre).ToList()
                ?? new List<string>();

            cbFiltroAsignatura.Items.Add("Todas las Asignaturas");

            if (filtroAsignaturas?.Count > 0)
            {
                foreach (var asignatura in filtroAsignaturas)
                {
                    cbFiltroAsignatura.Items.Add(asignatura);
                }
            }

            cbFiltroAsignatura.SelectedIndex = 0;
        }

        private void LlenarFiltroUnidades()
        {
            cbFiltroUnidad.Items.Clear();
            cbFiltroUnidad.Text = "";

            if (cbFiltroAsignatura.SelectedIndex == 0)
            {
                cbFiltroUnidad?.Items.Add("Todas las Unidades");

                foreach (var asignatura in Form1.Asignaturas)
                {
                    foreach (var unidad in asignatura.Unidades)
                    {
                        cbFiltroUnidad?.Items.Add(unidad.Nombre);
                    }
                }
            }

            if (cbFiltroAsignatura.SelectedIndex != 0)
            {
                string asignaturaSelec = cbFiltroAsignatura?.SelectedItem?.ToString() + "";
                Asignatura? asignatura = Form1.Asignaturas.FirstOrDefault(a => a?.Nombre == asignaturaSelec);

                filtroUnidades =
                    asignatura?.Unidades?.Select(u => u?.Nombre ?? "")?.ToList()
                    ?? new List<string>();

                cbFiltroUnidad?.Items.Add("Todas las Unidades");

                if (filtroAsignaturas?.Count > 0)
                {
                    foreach (var unidad in filtroUnidades)
                    {
                        cbFiltroUnidad?.Items.Add(unidad);
                    }
                }

                if (cbFiltroUnidad?.Items?.Count > 0)
                    cbFiltroUnidad.SelectedIndex = 0;
            }
        }
 
    }
}
