using SistemaDeGestionDeExamenes.Clases;

namespace SistemaDeGestionDeExamenes
{
    public partial class Correcciones : Form
    {
        public Correcciones()
        {
            InitializeComponent();
        }

        private void Correcciones_Load(object sender, EventArgs e)
        {
            LlenarListaCorrecciones();
        }

        private void btnEliminarCorreccion_Click(object sender, EventArgs e)
        {
            string correccionId = dgvCorrecciones.SelectedRows[0]?.Cells["CorreccionId"].Value.ToString() ?? "";

            ListaCorrecciones.EliminarCorreccion(correccionId);
            LlenarListaCorrecciones();
        }

        private void btnRefrescarCorrecciones_Click(object sender, EventArgs e)
        {
            LlenarListaCorrecciones();
        }

        private void LlenarListaCorrecciones()
        {
            dgvCorrecciones.Rows.Clear();

            foreach (Correccion correccion in ListaCorrecciones.Correcciones)
            {
                string[] fila = new string[6];

                fila[0] = correccion?.NombreAlumno?.ToString() ?? "";
                fila[1] = correccion?.ApellidoAlumno?.ToString() ?? "";

                Examen examen = ListaExamenes.Examenes?.FirstOrDefault(ex => ex.Id == correccion?.ExamenId) ?? new Examen();
                string asignatura = examen?.Asignatura ?? "";
                fila[2] = asignatura;

                fila[3] = correccion?.ExamenId?.ToString() ?? "";
                fila[4] = correccion?.Nota ?? "";
                fila[5] = correccion?.CorreccionId ?? "";

                dgvCorrecciones.Rows.Add(fila);
            }
        }
    }
}
