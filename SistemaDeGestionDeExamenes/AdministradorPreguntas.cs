using System.Data;
using SistemaDeGestionDeExamenes.Clases;

namespace SistemaDeGestionDeExamenes
{
    public partial class AdministradorPreguntas : Form
    {
        private List<Pregunta> preguntasFiltradas = new List<Pregunta>();

        private List<string> filtroAsignaturas = new List<string>();
        private List<string> filtroUnidades = new List<string>();

        private Pregunta? preguntaAEditar = null;

        private const string NUEVA_ASIGNATURA = "NUEVA_ASIGNATURA";
        private const string NUEVA_UNIDAD = "NUEVA_UNIDAD";
        private const string NUEVA_SUB_UNIDAD = "NUEVA_SUB_UNIDAD";

        private string? categoriaAAgregar;

        public AdministradorPreguntas()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            Menu.ConfigurarColumnasDataGridView(dgvPreguntas);
            AgregarAsignaturasADropdown(cbAsignaturas);
            Menu.MostrarPreguntasDGV(ListaPreguntas.Preguntas, dgvPreguntas);
            InicializarFiltroAsignaturas();
        }

        // EVENTOS

        // AGREGAR PREGUNTAS
        private void btnAgregarPreg_Click(object sender, EventArgs e)
        {
            ListaPreguntas.AgregarPregunta(CrearPregunta());
            Menu.MostrarPreguntasDGV(ListaPreguntas.Preguntas, dgvPreguntas);
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
                Pregunta? pregunta = CrearPregunta();

                if (pregunta != null)
                {
                    preguntaAEditar.Asignatura = pregunta.Asignatura;
                    preguntaAEditar.Unidad = pregunta.Unidad;
                    preguntaAEditar.SubUnidad = pregunta.SubUnidad;
                    preguntaAEditar.TxtPregunta = pregunta.TxtPregunta;
                    preguntaAEditar.Opciones[0] = pregunta.Opciones[0];
                    preguntaAEditar.Opciones[1] = pregunta.Opciones[1];
                    preguntaAEditar.Opciones[2] = pregunta.Opciones[2];
                    preguntaAEditar.Opciones[3] = pregunta.Opciones[3];
                    preguntaAEditar.OpcionCorrecta = pregunta.OpcionCorrecta;

                    ListaPreguntas.GuardarEnArchivo();
                    Menu.MostrarPreguntasDGV(ListaPreguntas.Preguntas, dgvPreguntas);

                    VisibilidadBotonesEditar(false);
                    VaciarFormulario();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VaciarFormulario();
            VisibilidadBotonesEditar(false);
        }

        // ELIMINAR PREGUNTAS
        private void btnEliminarPreg_Click(object sender, EventArgs e)
        {
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                string preguntaId = IdPreguntaSeleccionada();

                ListaPreguntas.EliminarPregunta(preguntaId);
                Menu.MostrarPreguntasDGV(ListaPreguntas.Preguntas, dgvPreguntas);

                cbFiltroAsignatura.SelectedIndex = 0;
            }
        }

        // FILTRO
        private void cbFiltroAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarFiltroUnidades();

            List<Pregunta> preguntasFiltradas =
                ListaPreguntas.Preguntas
                .Where(preg =>
                {
                    if (cbFiltroAsignatura.SelectedIndex != 0)
                        return preg.Asignatura == cbFiltroAsignatura?.SelectedItem?.ToString();

                    return true; // devuelve todo si se selecciona el index 0 en el combobox

                }).ToList();

            Menu.MostrarPreguntasDGV(preguntasFiltradas, dgvPreguntas);
        }

        private void cbFiltroUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Pregunta> preguntasFiltradas =
                ListaPreguntas.Preguntas
                .Where(preg =>
                {
                    if (cbFiltroUnidad.SelectedIndex != 0)
                        return preg.Unidad == cbFiltroUnidad?.SelectedItem?.ToString();

                    return true; // devuelve todo en index 0

                }).ToList();

            Menu.MostrarPreguntasDGV(preguntasFiltradas, dgvPreguntas);
        }

        // CREAR ASIGNATURAS, UNIDADES, SUBUNIDADES
        private void lblCrearAsignatura_Click(object sender, EventArgs e)
        {
            categoriaAAgregar = NUEVA_ASIGNATURA;
            pnlCrearNuevaSubUnidad.Visible = true;

            lblNuevaAsignatura.Visible = true;
            txtNuevaAsig.Visible = true;

            lblNuevaUnidad.Visible = true;
            txtNuevaUnidad.Visible = true;

            cbSeleccionAsig.Visible = false;
            lblElijaAsig.Visible = false;

            cbSeleccionUnidad.Visible = false;
            lblElijaUnid.Visible = false;
        }

        private void lblCrearUnidad_Click(object sender, EventArgs e)
        {
            categoriaAAgregar = NUEVA_UNIDAD;
            pnlCrearNuevaSubUnidad.Visible = true;
            AgregarAsignaturasADropdown(cbSeleccionAsig);

            cbSeleccionAsig.Visible = true;
            lblElijaAsig.Visible = true;

            lblNuevaAsignatura.Visible = false;
            txtNuevaAsig.Visible = false;

            cbSeleccionUnidad.Visible = false;
            lblElijaUnid.Visible = false;

            lblNuevaUnidad.Visible = true;
            txtNuevaUnidad.Visible = true;
        }

        private void lblCrearSubunidad_Click(object sender, EventArgs e)
        {
            categoriaAAgregar = NUEVA_SUB_UNIDAD;
            pnlCrearNuevaSubUnidad.Visible = true;
            AgregarAsignaturasADropdown(cbSeleccionAsig);

            cbSeleccionAsig.Visible = true;
            lblElijaAsig.Visible = true;

            lblNuevaAsignatura.Visible = false;
            txtNuevaAsig.Visible = false;

            cbSeleccionUnidad.Visible = true;
            lblElijaUnid.Visible = true;

            lblNuevaUnidad.Visible = false;
            txtNuevaUnidad.Visible = false;
        }

        private void cbSeleccionAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            Asignatura? asignaturaSeleccionada = ListaAsignaturas.Asignaturas?[cbSeleccionAsig.SelectedIndex];

            if (asignaturaSeleccionada != null)
            {
                cbSeleccionUnidad.Items.Clear();

                foreach (var unidad in asignaturaSeleccionada.Unidades)
                {
                    cbSeleccionUnidad.Items.Add(unidad.Nombre);
                }
            }
        }

        private void btnCrearNueva_Click(object sender, EventArgs e)
        {
            // CREA NUEVA ASIGNATURA
            Asignatura? asignatura = new Asignatura();

            if (categoriaAAgregar == NUEVA_ASIGNATURA)
            {
                string nombreAsig = txtNuevaAsig.Text.Trim();
                asignatura.Nombre = nombreAsig;
            }

            // BUSCA ASIGNATURA EXISTENTE
            else
            {
                string nombreAsig = cbSeleccionAsig?.SelectedItem?.ToString() ?? "";
                asignatura = ListaAsignaturas.Asignaturas.FirstOrDefault(asig => asig.Nombre == nombreAsig);
            }

            // CREA NUEVA UNIDAD
            Unidad? unidad = new Unidad();

            if (categoriaAAgregar == NUEVA_ASIGNATURA || categoriaAAgregar == NUEVA_UNIDAD)
            {
                unidad.Nombre = txtNuevaUnidad.Text.Trim();
                asignatura?.Unidades.Add(unidad);
            }

            // BUSCA UNIDAD EXISTENTE
            else
            {
                string nombreUnidad = cbSeleccionUnidad?.SelectedItem?.ToString() ?? "";
                unidad = asignatura?.Unidades.FirstOrDefault(unid => unid.Nombre == nombreUnidad);
            }

            // CREA NUEVAS SUBUNIDADES
            List<string> nombresSubUnidades = txtNuevasSubUnidades.Text.Trim().Split(",").ToList();

            foreach (string nombreSubUnidad in nombresSubUnidades)
            {
                SubUnidad subunidad = new SubUnidad();
                subunidad.Nombre = nombreSubUnidad.Trim();
                unidad?.SubUnidades.Add(subunidad);
            }

            if (categoriaAAgregar == NUEVA_ASIGNATURA && asignatura != null && asignatura.Nombre != null)
                ListaAsignaturas.AgregarAsignatura(asignatura);

            else
                ListaAsignaturas.GuardarEnArchivo();

            VaciarPanelDeCategorias();
            AgregarAsignaturasADropdown(cbAsignaturas);
            InicializarFiltroAsignaturas();
            pnlCrearNuevaSubUnidad.Visible = false;
        }

        private void btnCancelarNueva_Click(object sender, EventArgs e)
        {
            pnlCrearNuevaSubUnidad.Visible = false;
            VaciarPanelDeCategorias();
        }

        private void VaciarPanelDeCategorias()
        {
            txtNuevaAsig.Text = "";
            txtNuevaUnidad.Text = "";
            txtNuevasSubUnidades.Text = "";
        }

        // METODOS GENERALES
        private Pregunta? CrearPregunta(string? preguntaId = null)
        {
            try
            {
                string nombreAsignatura = cbAsignaturas?.SelectedItem?.ToString() + "";
                Asignatura? asignatura = ListaAsignaturas.BuscarAsignatura(nombreAsignatura);

                if (asignatura == null)
                    throw new Exception("Por favor, seleccione una asignatura correcta.");

                string nombreUnidad = cbUnidades?.SelectedItem?.ToString() + "";
                Unidad? unidad = ListaAsignaturas.BuscarUnidad(asignatura, nombreUnidad);

                if (unidad == null)
                    throw new Exception("Por favor, seleccione una unidad correcta.");

                string nombreSubUnidad = cbSubUnidades?.SelectedItem?.ToString() + "";
                SubUnidad? subUnidad = ListaAsignaturas.BuscarSubUnidad(unidad, nombreSubUnidad);

                if (subUnidad == null)
                    throw new Exception("Por favor, seleccione una sub unidad correcta.");

                string textPregunta = txtPregunta.Text.Trim();

                if (textPregunta.Count() <= 0)
                    throw new Exception("Por favor, escriba una pregunta.");

                string textOpc1 = txtOpc1.Text.Trim();

                if (textOpc1.Count() <= 0)
                    throw new Exception("Por favor, escriba una respuesta para la opcion 1.");

                string textOpc2 = txtOpc2.Text.Trim();

                if (textOpc2.Count() <= 0)
                    throw new Exception("Por favor, escriba una respuesta para la opcion 2.");

                string textOpc3 = txtOpc3.Text.Trim();

                if (textOpc3.Count() <= 0)
                    throw new Exception("Por favor, escriba una respuesta para la opcion 3.");

                string textOpc4 = txtOpc4.Text.Trim();

                if (textOpc4.Count() <= 0)
                    throw new Exception("Por favor, escriba una respuesta para la opcion 4.");

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
                    asignatura.Nombre,
                    unidad.Nombre,
                    subUnidad.Nombre,
                    textPregunta,
                    [textOpc1, textOpc2, textOpc3, textOpc4],
                    opcionCorrecta
                    );

                return pregunta;
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
                return null;
            }
        }

        private string IdPreguntaSeleccionada()
        {
            DataGridViewRow row = dgvPreguntas.SelectedRows[0]; // Accedemos a la primera fila seleccionada
            return row.Cells["PreguntaId"].Value.ToString() + "";
        }

        private void LlenarFormularioConPreguntaSeleccionada(string preguntaId)
        {
            preguntaAEditar = ListaPreguntas.EncontrarPregunta(preguntaId);

            int indexAsignatura =
                ListaAsignaturas.Asignaturas?
                .FindIndex(asig => asig.Nombre.Equals(preguntaAEditar?.Asignatura))
                ?? 0;

            cbAsignaturas.SelectedIndex = indexAsignatura;

            Asignatura? asignaturaSeleccionada = ListaAsignaturas.Asignaturas?[cbAsignaturas.SelectedIndex];

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
                if (ListaAsignaturas.Asignaturas.Count > 0 && cbAsignaturas.SelectedIndex >= 0)
                {
                    Asignatura? asignaturaSeleccionada = ListaAsignaturas.Asignaturas?[cbAsignaturas.SelectedIndex];

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
                if (ListaAsignaturas.Asignaturas.Count > 0 && cbAsignaturas.SelectedIndex >= 0 && cbUnidades.SelectedIndex >= 0)
                {
                    Unidad? unidadSeleccionada = null;

                    unidadSeleccionada = ListaAsignaturas.Asignaturas?[cbAsignaturas.SelectedIndex].
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
                ListaAsignaturas.Asignaturas?.Select(a => a.Nombre).ToList()
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

                foreach (var asignatura in ListaAsignaturas.Asignaturas)
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
                Asignatura? asignatura = ListaAsignaturas.Asignaturas.FirstOrDefault(a => a?.Nombre == asignaturaSelec);

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

        private void AgregarAsignaturasADropdown(ComboBox cb)
        {
            try
            {
                if (ListaAsignaturas.Asignaturas != null && ListaAsignaturas.Asignaturas.Count > 0)
                {
                    cb.Items.Clear();

                    foreach (var asignatura in ListaAsignaturas.Asignaturas)
                    {
                        cb.Items.Add(asignatura.Nombre); // llena dropdown de asignaturas
                    }
                }
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError(ex.Message);
            }
        }
    }
}
