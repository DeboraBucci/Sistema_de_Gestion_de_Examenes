using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography.Xml;
using System.Diagnostics;

namespace SistemaDeGestionDeExamenes
{
    public partial class Form1 : Form
    {
        private List<Asignatura> asignaturas = new List<Asignatura>();
        private List<Pregunta> preguntas = new List<Pregunta>();

        private string archivoExamen = "examen.json";
        private string archivoCorreciones = "correcciones.json";
        private string archivoPreguntas = "preguntas.json";

        public Form1()
        {
            InitializeComponent();

            LeerAsignaturas();
            LeerPreguntas();
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

        private void MostrarEsconderMenu(bool visible)
        {
            btnAdministrarBancoPreguntas.Visible = visible;
            btnGenerarExamenes.Visible = visible;
            btnCorregirExamenes.Visible = visible;
            btnImprimirExamenes.Visible = visible;
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            MostrarEsconderMenu(true);
            MostrarEsconderAdministracionPreguntas(false);

            btnVolverMenu.Visible = false;
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
        }

        // ADMINISTRADOR DE CATEGORIAS


        // ADMINISTRADOR DE PREGUNTAS

        // DROPDOWNS DE: ASIGNATURAS, UNIDADES Y SUBUNIDADES
        static List<Asignatura> LeerJsonDesdeArchivo(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("El archivo no existe.");
                    return new List<Asignatura>();
                }

                // Usar StreamReader para leer el archivo
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string json = reader.ReadToEnd();

                    // Deserializar el JSON a una lista de asignaturas
                    return JsonSerializer.Deserialize<List<Asignatura>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<Asignatura>();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo JSON: {ex.Message}");
                return new List<Asignatura>();
            }
        }
        
        private void LeerAsignaturas()
        {
            asignaturas = LeerJsonDesdeArchivo("asignaturas.txt");

            if (asignaturas != null && asignaturas.Count > 0)
            {
                foreach (var asignatura in asignaturas)
                {
                    cbAsignaturas.Items.Add(asignatura.Nombre);
                }

                cbAsignaturas.SelectedIndex = 0;
                CambiarUnidades();
            }

            else
            {
                Console.WriteLine("El archivo no contiene asignaturas o está vacío.");
            }
        }

        private void CambiarUnidades()
        {
            if (asignaturas.Count > 0)
            {
                Asignatura? asignaturaSeleccionada = asignaturas?[cbAsignaturas.SelectedIndex];

                if (asignaturaSeleccionada != null)
                {
                    cbUnidades.Items.Clear();

                    foreach (var unidad in asignaturaSeleccionada.Unidades)
                    {
                        cbUnidades.Items.Add(unidad.Nombre);
                    }
                }
            }
        }

        private void CambiarSubUnidades()
        {
            if (asignaturas.Count > 0)
            {
                Unidad? unidadSeleccionada = null;

                unidadSeleccionada = asignaturas?[cbAsignaturas.SelectedIndex].
                                     Unidades[cbUnidades.SelectedIndex];

                if (unidadSeleccionada != null)
                {
                    cbSubUnidades.Items.Clear();

                    foreach (var subUnidad in unidadSeleccionada.SubUnidades)
                    {
                        cbSubUnidades.Items.Add(subUnidad.Nombre);
                    }
                }
            }
        }
       
        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubUnidades.Text = "";
            cbUnidades.Items.Clear();

            cbUnidades.Text = "";
            cbSubUnidades.Items.Clear();

            CambiarUnidades();
        }
        
        private void cbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubUnidades.Text = "";
            cbSubUnidades.Items.Clear();

            CambiarSubUnidades();
        }

        // AGREGAR, ELIMINAR, EDITAR PREGUNTAS:
        private void btnAgregarPreg_Click(object sender, EventArgs e)
        {
            string asignatura = cbAsignaturas?.SelectedItem?.ToString() + "";
            string unidad = cbUnidades?.SelectedItem?.ToString() + "";
            string subunidad = cbSubUnidades?.SelectedItem?.ToString() + "";

            string textPregunta = txtPregunta.Text.Trim();
            string textOpc1 = txtOpc1.Text.Trim();
            string textOpc2 = txtOpc2.Text.Trim();
            string textOpc3 = txtOpc3.Text.Trim();
            string textOpc4 = txtOpc4.Text.Trim();

            string preguntaId = Guid.NewGuid().ToString();

            int opcionCorrecta = 1;

            if (rbOpc1.Checked)
                opcionCorrecta = 1;

            else if (rbOpc2.Checked)
                opcionCorrecta = 2;

            else if (rbOpc3.Checked)
                opcionCorrecta = 3;

            else if (rbOpc4.Checked)
                opcionCorrecta = 4;

            Pregunta pregunta = new Pregunta();

            pregunta.Asignatura = asignatura;
            pregunta.Unidad = unidad;
            pregunta.SubUnidad = subunidad;

            pregunta.TxtPregunta = textPregunta;
            pregunta.Opciones = [textOpc1, textOpc2, textOpc3, textOpc4];
            pregunta.OpcionCorrecta = opcionCorrecta;

            pregunta.PreguntaId = preguntaId;

            preguntas.Add(pregunta);

            GuardarPreguntasEnArchivo();
            LeerPreguntas();
        }

        private void GuardarPreguntasEnArchivo()
        {
            try
            {
                // Serializar la lista de preguntas a JSON
                string json = 
                    JsonSerializer.Serialize(preguntas, new JsonSerializerOptions { WriteIndented = true });

                // Usar StreamWriter para escribir el JSON al archivo
                using (StreamWriter writer = new StreamWriter(archivoPreguntas))
                {
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar las preguntas: {ex.Message}");
            }
        }

        private void btnEditarPreg_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPreg_Click(object sender, EventArgs e)
        {
            if (dgvPreguntas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPreguntas.SelectedRows[0]; // Accedemos a la primera fila seleccionada

                string preguntaId = row.Cells["PreguntaId"].Value.ToString() + "";

                preguntas = preguntas.Where(pregunta => pregunta.PreguntaId != preguntaId).ToList(); // Removemos la ID de la lista

                GuardarPreguntasEnArchivo();
                LeerPreguntas();
            }
        }


        private void LeerPreguntas()
        {
            try
            {
                if (!File.Exists(archivoPreguntas))
                {
                    Console.WriteLine("El archivo no existe.");
                }

                // Leer el archivo JSON
                using (StreamReader reader = new StreamReader(archivoPreguntas))
                {
                    string json = reader.ReadToEnd();

                    preguntas = JsonSerializer.Deserialize<List<Pregunta>>(json, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<Pregunta>(); // Maneja el caso de que sea null
                }

                ConfigurarColumnasDataGridView();
                MostrarPreguntas();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer las preguntas desde el archivo: {ex.Message}");
            }
        }

        private void MostrarPreguntas()
        {
            dgvPreguntas.Rows.Clear(); // Limpia las filas existentes

            foreach (var pregunta in preguntas)
            {
                // Crea una fila para las columnas
                var fila = new object[10];
                fila[0] = pregunta.Asignatura;
                fila[1] = pregunta.Unidad;
                fila[2] = pregunta.SubUnidad;
                fila[3] = pregunta.TxtPregunta;
                fila[4] = pregunta.OpcionCorrecta;
                fila[5] = pregunta.PreguntaId;

                // Llena las columnas de opciones
                for (int i = 0; i < 4; i++)
                {
                    fila[6 + i] = (i < pregunta.Opciones.Length) ? pregunta.Opciones[i] : "";
                }

                dgvPreguntas.Rows.Add(fila);
            }
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgvPreguntas.Columns.Clear(); // Limpia las columnas existentes

            dgvPreguntas.Columns.Add("Asignatura", "Asignatura");
            dgvPreguntas.Columns.Add("Unidad", "Unidad");
            dgvPreguntas.Columns.Add("SubUnidad", "SubUnidad");
            dgvPreguntas.Columns.Add("TxtPregunta", "Pregunta");
            dgvPreguntas.Columns.Add("OpcionCorrecta", "Opción Correcta");
            dgvPreguntas.Columns.Add("PreguntaId", "PreguntaId");

            dgvPreguntas.Columns.Add("Opcion1", "Opción 1");
            dgvPreguntas.Columns.Add("Opcion2", "Opción 2");
            dgvPreguntas.Columns.Add("Opcion3", "Opción 3");
            dgvPreguntas.Columns.Add("Opcion4", "Opción 4");

            dgvPreguntas.Columns["PreguntaId"].Visible = false;
        }
    }
}
