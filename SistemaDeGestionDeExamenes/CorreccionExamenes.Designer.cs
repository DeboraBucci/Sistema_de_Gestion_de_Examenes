namespace SistemaDeGestionDeExamenes
{
    partial class CorreccionExamenes
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
            cbExamenesId = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNombreAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            label3 = new Label();
            btnIngresarPreguntas = new Button();
            lblPregunta = new Label();
            lblPreguntaTxt = new Label();
            lblRespuesta = new Label();
            cbRespuestaSeleccionada = new ComboBox();
            gbRespuestas = new GroupBox();
            lblNumPregunta = new Label();
            btnAgregarRespuesta = new Button();
            label5 = new Label();
            label4 = new Label();
            lblNota = new Label();
            dgvRespuestas = new DataGridView();
            Pregunta = new DataGridViewTextBoxColumn();
            RespuestaCorrecta = new DataGridViewTextBoxColumn();
            RespuestaAlumno = new DataGridViewTextBoxColumn();
            EstadoRespuesta = new DataGridViewTextBoxColumn();
            lblRespuestasCorrectas = new Label();
            label7 = new Label();
            btnGuardarCorreccion = new Button();
            gbRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRespuestas).BeginInit();
            SuspendLayout();
            // 
            // cbExamenesId
            // 
            cbExamenesId.FormattingEnabled = true;
            cbExamenesId.Location = new Point(42, 134);
            cbExamenesId.Name = "cbExamenesId";
            cbExamenesId.Size = new Size(421, 23);
            cbExamenesId.TabIndex = 0;
            cbExamenesId.SelectedIndexChanged += cbExamenesId_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 116);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el ID del Examen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 182);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Alumno";
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(42, 200);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(197, 23);
            txtNombreAlumno.TabIndex = 3;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(266, 200);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(197, 23);
            txtApellidoAlumno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 182);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido del Alumno";
            // 
            // btnIngresarPreguntas
            // 
            btnIngresarPreguntas.Location = new Point(42, 248);
            btnIngresarPreguntas.Name = "btnIngresarPreguntas";
            btnIngresarPreguntas.Size = new Size(421, 38);
            btnIngresarPreguntas.TabIndex = 7;
            btnIngresarPreguntas.Text = "Ingresar Preguntas";
            btnIngresarPreguntas.UseVisualStyleBackColor = true;
            btnIngresarPreguntas.Click += btnIngresarPreguntas_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(44, 50);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(58, 15);
            lblPregunta.TabIndex = 10;
            lblPregunta.Text = "Pregunta:";
            // 
            // lblPreguntaTxt
            // 
            lblPreguntaTxt.AutoSize = true;
            lblPreguntaTxt.Location = new Point(117, 50);
            lblPreguntaTxt.Name = "lblPreguntaTxt";
            lblPreguntaTxt.Size = new Size(12, 15);
            lblPreguntaTxt.TabIndex = 11;
            lblPreguntaTxt.Text = "-";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(23, 87);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(200, 15);
            lblRespuesta.TabIndex = 12;
            lblRespuesta.Text = "Numero de la Respuesta del Alumno";
            // 
            // cbRespuestaSeleccionada
            // 
            cbRespuestaSeleccionada.FormattingEnabled = true;
            cbRespuestaSeleccionada.Items.AddRange(new object[] { "Sin responder", "1", "2", "3", "4" });
            cbRespuestaSeleccionada.Location = new Point(245, 84);
            cbRespuestaSeleccionada.Name = "cbRespuestaSeleccionada";
            cbRespuestaSeleccionada.Size = new Size(152, 23);
            cbRespuestaSeleccionada.TabIndex = 13;
            // 
            // gbRespuestas
            // 
            gbRespuestas.Controls.Add(lblNumPregunta);
            gbRespuestas.Controls.Add(btnAgregarRespuesta);
            gbRespuestas.Controls.Add(lblRespuesta);
            gbRespuestas.Controls.Add(cbRespuestaSeleccionada);
            gbRespuestas.Controls.Add(lblPregunta);
            gbRespuestas.Controls.Add(lblPreguntaTxt);
            gbRespuestas.Location = new Point(42, 330);
            gbRespuestas.Name = "gbRespuestas";
            gbRespuestas.Size = new Size(421, 192);
            gbRespuestas.TabIndex = 14;
            gbRespuestas.TabStop = false;
            gbRespuestas.Text = "Respuestas";
            gbRespuestas.Visible = false;
            // 
            // lblNumPregunta
            // 
            lblNumPregunta.AutoSize = true;
            lblNumPregunta.Location = new Point(26, 50);
            lblNumPregunta.Name = "lblNumPregunta";
            lblNumPregunta.Size = new Size(12, 15);
            lblNumPregunta.TabIndex = 16;
            lblNumPregunta.Text = "-";
            // 
            // btnAgregarRespuesta
            // 
            btnAgregarRespuesta.Location = new Point(23, 136);
            btnAgregarRespuesta.Name = "btnAgregarRespuesta";
            btnAgregarRespuesta.Size = new Size(374, 38);
            btnAgregarRespuesta.TabIndex = 15;
            btnAgregarRespuesta.Text = "Agregar Respuesta";
            btnAgregarRespuesta.UseVisualStyleBackColor = true;
            btnAgregarRespuesta.Click += btnAgregarRespuesta_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(503, 84);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 15;
            label5.Text = "Respuestas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(1214, 616);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 17;
            label4.Text = "Nota:";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 16F);
            lblNota.Location = new Point(1285, 616);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(22, 30);
            lblNota.TabIndex = 18;
            lblNota.Text = "-";
            // 
            // dgvRespuestas
            // 
            dgvRespuestas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRespuestas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRespuestas.Columns.AddRange(new DataGridViewColumn[] { Pregunta, RespuestaCorrecta, RespuestaAlumno, EstadoRespuesta });
            dgvRespuestas.Location = new Point(503, 134);
            dgvRespuestas.Name = "dgvRespuestas";
            dgvRespuestas.Size = new Size(854, 457);
            dgvRespuestas.TabIndex = 19;
            // 
            // Pregunta
            // 
            Pregunta.FillWeight = 156.933929F;
            Pregunta.HeaderText = "Pregunta";
            Pregunta.Name = "Pregunta";
            // 
            // RespuestaCorrecta
            // 
            RespuestaCorrecta.FillWeight = 80.97133F;
            RespuestaCorrecta.HeaderText = "Respuesta Correcta";
            RespuestaCorrecta.Name = "RespuestaCorrecta";
            // 
            // RespuestaAlumno
            // 
            RespuestaAlumno.FillWeight = 81.2182846F;
            RespuestaAlumno.HeaderText = "Respuesta del Alumno";
            RespuestaAlumno.Name = "RespuestaAlumno";
            // 
            // EstadoRespuesta
            // 
            EstadoRespuesta.FillWeight = 80.8764954F;
            EstadoRespuesta.HeaderText = "Estado de la Respuesta";
            EstadoRespuesta.Name = "EstadoRespuesta";
            // 
            // lblRespuestasCorrectas
            // 
            lblRespuestasCorrectas.AutoSize = true;
            lblRespuestasCorrectas.Font = new Font("Segoe UI", 16F);
            lblRespuestasCorrectas.Location = new Point(1148, 616);
            lblRespuestasCorrectas.Name = "lblRespuestasCorrectas";
            lblRespuestasCorrectas.Size = new Size(22, 30);
            lblRespuestasCorrectas.TabIndex = 21;
            lblRespuestasCorrectas.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(903, 616);
            label7.Name = "label7";
            label7.Size = new Size(222, 30);
            label7.TabIndex = 20;
            label7.Text = "Respuestas Correctas:";
            // 
            // btnGuardarCorreccion
            // 
            btnGuardarCorreccion.Location = new Point(42, 553);
            btnGuardarCorreccion.Name = "btnGuardarCorreccion";
            btnGuardarCorreccion.Size = new Size(421, 38);
            btnGuardarCorreccion.TabIndex = 17;
            btnGuardarCorreccion.Text = "Guardar Correcion";
            btnGuardarCorreccion.UseVisualStyleBackColor = true;
            btnGuardarCorreccion.Visible = false;
            btnGuardarCorreccion.Click += btnGuardarCorreccion_Click;
            // 
            // CorreccionExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 741);
            Controls.Add(btnGuardarCorreccion);
            Controls.Add(lblRespuestasCorrectas);
            Controls.Add(label7);
            Controls.Add(dgvRespuestas);
            Controls.Add(lblNota);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(gbRespuestas);
            Controls.Add(btnIngresarPreguntas);
            Controls.Add(txtApellidoAlumno);
            Controls.Add(label3);
            Controls.Add(txtNombreAlumno);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbExamenesId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CorreccionExamenes";
            Text = "CorreccionExamenes";
            Load += CorreccionExamenes_Load;
            gbRespuestas.ResumeLayout(false);
            gbRespuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRespuestas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbExamenesId;
        private Label label1;
        private Label label2;
        private TextBox txtNombreAlumno;
        private TextBox txtApellidoAlumno;
        private Label label3;
        private Button btnIngresarPreguntas;
        private Label lblPregunta;
        private Label lblPreguntaTxt;
        private Label lblRespuesta;
        private ComboBox cbRespuestaSeleccionada;
        private GroupBox gbRespuestas;
        private Label lblNumPregunta;
        private Button btnAgregarRespuesta;
        private Label label5;
        private Label label4;
        private Label lblNota;
        private DataGridView dgvRespuestas;
        private Label lblRespuestasCorrectas;
        private Label label7;
        private DataGridViewTextBoxColumn Pregunta;
        private DataGridViewTextBoxColumn RespuestaCorrecta;
        private DataGridViewTextBoxColumn RespuestaAlumno;
        private DataGridViewTextBoxColumn EstadoRespuesta;
        private Button btnGuardarCorreccion;
    }
}