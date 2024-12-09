using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dgvCorrecciones.Rows.Clear();

            foreach(Correccion correccion in ListaCorrecciones.Correcciones)
            {
                string[] fila = new string[5];

                fila[0] = correccion?.NombreAlumno?.ToString() ?? "";
                fila[1] = correccion?.ApellidoAlumno?.ToString() ?? "";

                Examen examen = ListaExamenes.Examenes?.FirstOrDefault(ex => ex.Id == correccion?.ExamenId) ?? new Examen();
                string asignatura = examen?.Asignatura ?? "";
                fila[2] = asignatura;

                fila[3] = correccion?.ExamenId?.ToString() ?? ""; 
                fila[4] = correccion?.Nota ?? "";

                dgvCorrecciones.Rows.Add(fila);
            }
        }
    }
}
