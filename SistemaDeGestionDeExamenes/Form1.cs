
using System.Collections.Generic;

namespace SistemaDeGestionDeExamenes
{
    public partial class Form1 : Form
    {
        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<Pregunta> preguntasFiltradas = new List<Pregunta>();

        private List<string> filtroAsignaturas = new List<string>();
        private List<string> filtroUnidades = new List<string>();

        private string archivoExamen = "examen.json";
        private string archivoCorreciones = "correcciones.json";
        private string archivoPreguntas = "preguntas.json";
        private string archivoAsignaturas = "asignaturas.json";

        private Pregunta? preguntaAEditar = null;

        public Form1()
        {
            InitializeComponent();

            preguntas = JsonHelper.LeerDesdeArchivo<Pregunta>(archivoPreguntas);

            ConfigurarColumnasDataGridView();
            AgreagarAsignaturasALista();
            MostrarPreguntas(preguntas);
            InicializarFiltroAsignaturas();
        }

        // MENU
        private void btnAdministrarBancoPreguntas_Click(object sender, EventArgs e)
        {
            MostrarEsconderMenu(false);
            MostrarEsconderAdministracionPreguntas(true);

            btnVolverMenu.Visible = true;
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

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MostrarEsconderMenu(true);
            MostrarEsconderAdministracionPreguntas(false);

            btnVolverMenu.Visible = false;
        }

        private void MostrarEsconderMenu(bool visible)
        {
            btnAdministrarBancoPreguntas.Visible = visible;
            btnGenerarExamenes.Visible = visible;
            btnCorregirExamenes.Visible = visible;
            btnImprimirExamenes.Visible = visible;
        }

        private void MostrarEsconderAdministracionPreguntas(bool visible)
        {
            lblAsignatura.Visible = visible;
            cbAsignaturas.Visible = visible;
            lblCrearAsignatura.Visible = visible;

            lblUnidad.Visible = visible;
            cbUnidades.Visible = visible;
            lblCrearUnidad.Visible = visible;

            lblSubUnidad.Visible = visible;
            cbSubUnidades.Visible = visible;
            lblCrearSubunidad.Visible = visible;

            lblPregunta.Visible = visible;
            txtPregunta.Visible = visible;

            lblOpc1.Visible = visible;
            txtOpc1.Visible = visible;

            lblOpc2.Visible = visible;
            txtOpc2.Visible = visible;

            lblOpc3.Visible = visible;
            txtOpc3.Visible = visible;

            lblOpc4.Visible = visible;
            txtOpc4.Visible = visible;

            lblPreguntas.Visible = visible;
            dgvPreguntas.Visible = visible;

            gbOpcionCorrecta.Visible = visible;

            btnAgregarPreg.Visible = visible;
            btnEditarPreg.Visible = visible;
            btnEliminarPreg.Visible = visible;

            lblFiltroAsignatura.Visible = visible;
            cbFiltroAsignatura.Visible = visible;

            lblFiltroUnidad.Visible = visible;
            cbFiltroUnidad.Visible = visible;
        }

        // ADMINISTRADOR DE PREGUNTAS

        // DROPDOWNS DE: ASIGNATURAS, UNIDADES Y SUBUNIDADES
        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarUnidades();
        }

        private void cbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarSubUnidades();
        }

        private void AgreagarAsignaturasALista()
        {
            try
            {
                asignaturas = JsonHelper.LeerDesdeArchivo<Asignatura>(archivoAsignaturas);

                if (asignaturas != null && asignaturas.Count > 0)
                {
                    foreach (var asignatura in asignaturas)
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

        private void CambiarUnidades()
        {
            try
            {
                if (asignaturas.Count > 0 && cbAsignaturas.SelectedIndex >= 0)
                {
                    Asignatura? asignaturaSeleccionada = asignaturas?[cbAsignaturas.SelectedIndex];

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

        private void CambiarSubUnidades()
        {
            try
            {
                if (asignaturas.Count > 0 && cbAsignaturas.SelectedIndex >= 0 && cbUnidades.SelectedIndex >= 0)
                {
                    Unidad? unidadSeleccionada = null;

                    unidadSeleccionada = asignaturas?[cbAsignaturas.SelectedIndex].
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

        // ----------------------------------------------------- //

        // AGREGAR, ELIMINAR, EDITAR PREGUNTAS:
        // AGREGAR PREGUNTA
        private void btnAgregarPreg_Click(object sender, EventArgs e)
        {
            preguntas.Add(
                CrearPregunta()
                );

            JsonHelper.GuardarEnArchivo(preguntas, archivoPreguntas);

            MostrarPreguntas(preguntas);
            VaciarFormulario();
        }

        // EDITAR PREGUNTAS
        private void btnEditarPreg_Click(object sender, EventArgs e)
        {
            string preguntaId = IdPreguntaSeleccionada();

            LlenarFormularioConPreguntaSeleccionada(preguntaId);

            VisibilidadBotonesEditar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciarFormulario();
            VisibilidadBotonesEditar(false);
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

                JsonHelper.GuardarEnArchivo(preguntas, archivoPreguntas);

                MostrarPreguntas(preguntas);
                VisibilidadBotonesEditar(false);
                VaciarFormulario();
            }
        }

        private void VisibilidadBotonesEditar(bool visible)
        {
            btnAceptarCambios.Visible = visible;
            btnCancelar.Visible = visible;

            btnAgregarPreg.Visible = !visible;
            btnEditarPreg.Visible = !visible;
            btnEliminarPreg.Visible = !visible;
        }

        private void LlenarFormularioConPreguntaSeleccionada(string preguntaId)
        {
            preguntaAEditar = preguntas.Find(pregunta => pregunta.PreguntaId == preguntaId);

            int indexAsignatura =
                asignaturas?
                .FindIndex(asig => asig.Nombre.Equals(preguntaAEditar?.Asignatura))
                ?? 0;

            cbAsignaturas.SelectedIndex = indexAsignatura;

            Asignatura? asignaturaSeleccionada = asignaturas?[cbAsignaturas.SelectedIndex];

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

        // ELIMINAR PREGUNTA
        private void btnEliminarPreg_Click(object sender, EventArgs e)
        {
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                string preguntaId = IdPreguntaSeleccionada();

                preguntas =
                    preguntas
                    .Where(pregunta => pregunta.PreguntaId != preguntaId)
                    .ToList(); // Removemos la ID de la lista

                JsonHelper.GuardarEnArchivo(preguntas, archivoPreguntas);

                MostrarPreguntas(preguntas);
            }
        }

        // FILTRAR PREGUNTAS
        private void cbFiltroAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarFiltroUnidades();

            List<Pregunta> preguntasFiltradas =
                preguntas.Where(preg =>
                {
                    if (cbFiltroAsignatura.SelectedIndex != 0)
                    {
                        return preg.Asignatura == cbFiltroAsignatura?.SelectedItem?.ToString();
                    }

                    return true;


                }).ToList();

            MostrarPreguntas(preguntasFiltradas);
        }

        private void cbFiltroUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Pregunta> preguntasFiltradas =
                preguntas.Where(preg =>
                {
                    if (cbFiltroUnidad.SelectedIndex != 0)
                    {
                        return preg.Unidad == cbFiltroUnidad?.SelectedItem?.ToString();
                    }

                    return true;

                }).ToList();

            MostrarPreguntas(preguntasFiltradas);
        }

        private void InicializarFiltroAsignaturas()
        {
            cbFiltroAsignatura.Items.Clear();

            filtroAsignaturas =
                asignaturas?.Select(a => a.Nombre).ToList()
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

                foreach (var asignatura in asignaturas)
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
                Asignatura? asignatura = asignaturas.FirstOrDefault(a => a?.Nombre == asignaturaSelec);

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

        // METODOS GENERICOS
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

        private void ConfigurarColumnasDataGridView()
        {
            dgvPreguntas.Columns.Clear(); // Limpia las columnas existentes

            dgvPreguntas.Columns.Add("Asignatura", "Asignatura");
            dgvPreguntas.Columns.Add("Unidad", "Unidad");
            dgvPreguntas.Columns.Add("SubUnidad", "SubUnidad");
            dgvPreguntas.Columns.Add("TxtPregunta", "Pregunta");
            dgvPreguntas.Columns.Add("OpcionCorrecta", "Opci�n Correcta");
            dgvPreguntas.Columns.Add("PreguntaId", "PreguntaId");

            dgvPreguntas.Columns.Add("Opcion1", "Opci�n 1");
            dgvPreguntas.Columns.Add("Opcion2", "Opci�n 2");
            dgvPreguntas.Columns.Add("Opcion3", "Opci�n 3");
            dgvPreguntas.Columns.Add("Opcion4", "Opci�n 4");

            dgvPreguntas.Columns["PreguntaId"].Visible = false;
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

        private void MostrarPreguntas(List<Pregunta> pregs)
        {
            dgvPreguntas.Rows.Clear(); // Limpia las filas existentes

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

                dgvPreguntas.Rows.Add(fila);
            }
        }

        // CREAR ASIGNATURAS
        private void lblCrearAsignatura_Click(object sender, EventArgs e)
        {
            pnlNuevaAsignatura.Visible = true;
        }

        private void btnCrearNuevaAsignatura_Click(object sender, EventArgs e)
        {
            Asignatura asignatura = new Asignatura();
            asignatura.Nombre = txtNombreNuevaAsignatura.Text.Trim();

            asignaturas.Add(asignatura);

            JsonHelper.GuardarEnArchivo(asignaturas, archivoAsignaturas);
            AgreagarAsignaturasALista();

            pnlNuevaAsignatura.Visible = false;

            JsonHelper.GuardarEnArchivo(asignaturas, archivoAsignaturas);
        }

        private void btnCancelarNuevaAsignatura_Click(object sender, EventArgs e)
        {
            pnlNuevaAsignatura.Visible = false;

        }

        // CREAR UNIDADES
        private void lblCrearUnidad_Click(object sender, EventArgs e)
        {
            pnlNuevaUnidad.Visible = true;

            if (asignaturas != null && asignaturas.Count > 0)
            {
                foreach (var asignatura in asignaturas)
                {
                    cbAsignaturasCrearUnidad.Items.Add(asignatura.Nombre);
                }
            }

        }

        private void btnCrearNuevaUnidad_Click(object sender, EventArgs e)
        {
            string? asignaturaTxt = cbAsignaturasCrearUnidad?.SelectedItem?.ToString();

            Unidad nuevaUnidad = new Unidad();
            nuevaUnidad.Nombre = txtNuevaUnidad.Text;

            foreach (Asignatura asig in asignaturas)
            {
                if (asig.Nombre == asignaturaTxt)
                    asig.Unidades.Add(nuevaUnidad);
            }

            pnlNuevaUnidad.Visible = false;
            JsonHelper.GuardarEnArchivo(asignaturas, archivoAsignaturas);

        }

        private void btnCancelarNuevaUnidad_Click(object sender, EventArgs e)
        {
            pnlNuevaUnidad.Visible = false;
        }

        // CREAR SUBUNIDADES
        private void lblCrearSubUnidad_Click(object sender, EventArgs e)
        {
            pnlCrearNuevaSubUnidad.Visible = true;

            if (asignaturas != null && asignaturas.Count > 0)
            {
                foreach (var asignatura in asignaturas)
                {
                    cbAsignaturaNuevaSubUnidad.Items.Add(asignatura.Nombre);
                }
            }
        }

        private void cbAsignaturaNuevaSubUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? asignTxt = cbAsignaturaNuevaSubUnidad?.SelectedItem?.ToString();

            Asignatura? asignatraElegida = asignaturas.FirstOrDefault(asig => asig.Nombre == asignTxt);

                foreach (Unidad unidad in asignatraElegida?.Unidades)
                {
                    cbUnidadesNuevaSubunidad?.Items.Add(unidad.Nombre);
                }
        }

        private void btnCrearNuevaSubUnidad_Click(object sender, EventArgs e)
        {
            string? asignaturaTxt = cbAsignaturaNuevaSubUnidad?.SelectedItem?.ToString();
            string? unidadTxt = cbUnidadesNuevaSubunidad?.SelectedItem?.ToString();

            SubUnidad nuevaSubUnidad = new SubUnidad();
            nuevaSubUnidad.Nombre = txtNuevaSubUnidad.Text;

            foreach (Asignatura asig in asignaturas)
            {
                foreach (Unidad unid in asig.Unidades)
                {
                    lblAsignatura.Text = asig.Nombre + " " + unid.Nombre;
                    if (asig.Nombre == asignaturaTxt && unid.Nombre == unidadTxt)
                        unid.SubUnidades.Add(nuevaSubUnidad);
                }
            }

            pnlCrearNuevaSubUnidad.Visible = false;
            JsonHelper.GuardarEnArchivo(asignaturas, archivoAsignaturas);

        }

        private void btnCancelarNuevaSubUnidad_Click(object sender, EventArgs e)
        {
            pnlCrearNuevaSubUnidad.Visible = false;
        }
    }
}
