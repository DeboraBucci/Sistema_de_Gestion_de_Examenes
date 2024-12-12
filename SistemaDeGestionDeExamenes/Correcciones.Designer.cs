namespace SistemaDeGestionDeExamenes
{
    partial class Correcciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCorrecciones = new DataGridView();
            NombreAlumno = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Asignatura = new DataGridViewTextBoxColumn();
            ExamenId = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            CorreccionId = new DataGridViewTextBoxColumn();
            label5 = new Label();
            btnEliminarCorreccion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCorrecciones).BeginInit();
            SuspendLayout();
            // 
            // dgvCorrecciones
            // 
            dgvCorrecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCorrecciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCorrecciones.Columns.AddRange(new DataGridViewColumn[] { NombreAlumno, Apellido, Asignatura, ExamenId, Nota, CorreccionId });
            dgvCorrecciones.Location = new Point(83, 108);
            dgvCorrecciones.Name = "dgvCorrecciones";
            dgvCorrecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCorrecciones.Size = new Size(1251, 548);
            dgvCorrecciones.TabIndex = 0;
            // 
            // NombreAlumno
            // 
            NombreAlumno.FillWeight = 105.96447F;
            NombreAlumno.HeaderText = "Nombre del Alumno";
            NombreAlumno.Name = "NombreAlumno";
            // 
            // Apellido
            // 
            Apellido.FillWeight = 105.96447F;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Asignatura
            // 
            Asignatura.FillWeight = 105.96447F;
            Asignatura.HeaderText = "Asignatura";
            Asignatura.Name = "Asignatura";
            // 
            // ExamenId
            // 
            ExamenId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExamenId.FillWeight = 105.96447F;
            ExamenId.HeaderText = "Examen ID";
            ExamenId.Name = "ExamenId";
            // 
            // Nota
            // 
            Nota.FillWeight = 76.1421356F;
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            // 
            // CorreccionId
            // 
            CorreccionId.HeaderText = "Correccion ID";
            CorreccionId.Name = "CorreccionId";
            CorreccionId.Resizable = DataGridViewTriState.True;
            CorreccionId.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(83, 73);
            label5.Name = "label5";
            label5.Size = new Size(139, 30);
            label5.TabIndex = 19;
            label5.Text = "Correcciones";
            // 
            // btnEliminarCorreccion
            // 
            btnEliminarCorreccion.Location = new Point(1180, 73);
            btnEliminarCorreccion.Name = "btnEliminarCorreccion";
            btnEliminarCorreccion.Size = new Size(154, 29);
            btnEliminarCorreccion.TabIndex = 21;
            btnEliminarCorreccion.Text = "Eliminar Correccion";
            btnEliminarCorreccion.UseVisualStyleBackColor = true;
            btnEliminarCorreccion.Click += btnEliminarCorreccion_Click;
            // 
            // Correcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 702);
            Controls.Add(btnEliminarCorreccion);
            Controls.Add(label5);
            Controls.Add(dgvCorrecciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Correcciones";
            StartPosition = FormStartPosition.Manual;
            Text = "Correcciones";
            Load += Correcciones_Load;
            VisibleChanged += Correcciones_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgvCorrecciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCorrecciones;
        private Label label5;
        private Button btnEliminarCorreccion;
        private DataGridViewTextBoxColumn NombreAlumno;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Asignatura;
        private DataGridViewTextBoxColumn ExamenId;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn CorreccionId;
    }
}