
using System.Collections.Generic;

namespace SistemaDeGestionDeExamenes
{
    public partial class Form1 : Form
    {
        public static string archivoExamen = "examen.json";
        public static string archivoCorreciones = "correcciones.json";
        public static string archivoPreguntas = "preguntas.json";
        public static string archivoAsignaturas = "asignaturas.json";

        public static List<Pregunta> Preguntas { get; private set; } = JsonHelper.LeerDesdeArchivo<Pregunta>(archivoPreguntas);
        public static List<Asignatura> Asignaturas { get; private set; } = JsonHelper.LeerDesdeArchivo<Asignatura>(archivoAsignaturas);
        public static List<Examen> Examenes { get; private set; } = JsonHelper.LeerDesdeArchivo<Examen>(archivoExamen);

        const string ADMINISTRADOR_PREG = "ADMINISTRADOR_PREGUNTAS";
        const string GENERADOR_EXAM = "GENERADOR_EXAMENES";

        public Form? currOpenedForm = null;
                         
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            AbrirFormBancoPreguntas();
        }

        AdministradorPreguntas administradorPreguntas = new AdministradorPreguntas
        {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
        };

        GeneradorExamenes generadorExamenes = new GeneradorExamenes
        {
            StartPosition = FormStartPosition.Manual,
            Location = new Point(0, 0),
        };


        // MENU
        private void btnAdministrarBancoPreguntas_Click(object sender, EventArgs e)
        {
            AbrirFormBancoPreguntas();
        }

        private void AbrirFormBancoPreguntas()
        {
            ResetearDefaultBtnsUI();

            btnAdministrarBancoPreguntas.BackColor = SystemColors.HotTrack;
            btnAdministrarBancoPreguntas.ForeColor = Color.White;

            CerrarFormularios();
            currOpenedForm = administradorPreguntas;

            administradorPreguntas.MdiParent = this;
            administradorPreguntas.Show();
        }

        private void btnGenerarExamenes_Click(object sender, EventArgs e)
        {
            AbrirFormGenerarExamenes();
        }

        private void AbrirFormGenerarExamenes()
        {
            ResetearDefaultBtnsUI();

            btnGenerarExamenes.BackColor = SystemColors.HotTrack;
            btnGenerarExamenes.ForeColor = Color.White;

            CerrarFormularios();
            currOpenedForm = generadorExamenes;

            generadorExamenes.MdiParent = this;
            generadorExamenes.Show();
        }

        private void btnCorregirExamenes_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirExamenes_Click(object sender, EventArgs e)
        {

        }

        private void ResetearDefaultBtnsUI()
        {
            btnAdministrarBancoPreguntas.BackColor = Color.White;
            btnAdministrarBancoPreguntas.ForeColor = Color.Black;

            btnImprimirExamenes.BackColor = Color.White;
            btnImprimirExamenes.ForeColor = Color.Black;

            btnGenerarExamenes.BackColor = Color.White;
            btnGenerarExamenes.ForeColor = Color.Black;

            btnCorregirExamenes.BackColor = Color.White;
            btnCorregirExamenes.ForeColor = Color.Black;
        }
  
        private void CerrarFormularios()
        {
            if (currOpenedForm != null)
            {
                currOpenedForm.Hide();
                currOpenedForm = null;
            }
        }

        // FUNCIONES DE PREGUNTAS
        public static List<Pregunta> BuscarPreguntas()
        {
            return JsonHelper.LeerDesdeArchivo<Pregunta>(archivoPreguntas);
        }

        public static void AgregarPregunta(Pregunta pregunta)
        {
            Preguntas.Add(pregunta);
            GuardarPreguntasArchivo();
        }

        public static void EliminarPregunta(string id)
        {
            Preguntas = Preguntas
                .Where(pregunta => pregunta.PreguntaId != id)
                .ToList();

            GuardarPreguntasArchivo();
        }

        public static Pregunta? EncontrarPregunta(string id)
        {
            return Preguntas.Find(pregunta => pregunta.PreguntaId == id);
        }

        public static void GuardarPreguntasArchivo()
        {
            JsonHelper.GuardarEnArchivo(Preguntas, archivoPreguntas);
        }

        // FUNCIONES DE ASIGNATURAS
        public static List<Asignatura> BuscarAsignaturas()
        {
            return JsonHelper.LeerDesdeArchivo<Asignatura>(archivoAsignaturas);
        }

        public static void GuardarAsignaturasArchivo()
        {
            JsonHelper.GuardarEnArchivo(Asignaturas, archivoAsignaturas);

        }

        // CONFIGURAR DATA GRID VIEW
        public static void ConfigurarColumnasDataGridView(DataGridView dgv)
        {
            dgv.Columns.Clear(); // Limpia las columnas existentes

            dgv.Columns.Add("Asignatura", "Asignatura");
            dgv.Columns.Add("Unidad", "Unidad");
            dgv.Columns.Add("SubUnidad", "SubUnidad");
            dgv.Columns.Add("TxtPregunta", "Pregunta");
            dgv.Columns.Add("OpcionCorrecta", "Opción Correcta");
            dgv.Columns.Add("PreguntaId", "PreguntaId");

            dgv.Columns.Add("Opcion1", "Opción 1");
            dgv.Columns.Add("Opcion2", "Opción 2");
            dgv.Columns.Add("Opcion3", "Opción 3");
            dgv.Columns.Add("Opcion4", "Opción 4");

            dgv.Columns["PreguntaId"].Visible = false;
        }

        public static void MostrarPreguntasDGV(List<Pregunta> pregs, DataGridView dgv)
        {
            dgv.Rows.Clear(); // Limpia las filas existentes

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

                dgv.Rows.Add(fila);
            }
        }

        public static void AgregarExamen(Examen examen)
        {
            Examenes.Add(examen);

            JsonHelper.GuardarEnArchivo(Examenes, archivoExamen);
        }

        public static List<Pregunta> ObtenerPreguntasDeExamen(string examenId)
        {
            List<Pregunta> preguntasExamen = new List<Pregunta>();
            Examen? examen = Examenes?.Find(e => e.Id == examenId);
            
            if (examen != null)
            {
                preguntasExamen = 
                    Preguntas
                    .FindAll(p =>
                        examen.PreguntasId
                        .Any(pId => pId.Id == p.PreguntaId));
            }

            return preguntasExamen;
        }
    }
}
