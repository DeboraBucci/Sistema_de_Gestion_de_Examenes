namespace SistemaDeGestionDeExamenes
{
    partial class GeneradorExamenes
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
            cbAsignaturas = new ComboBox();
            lblAsignatura = new Label();
            lstUnidades = new ListBox();
            btnGenerarExamen = new Button();
            label1 = new Label();
            dgvPreguntas = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            lblAsignExamen = new Label();
            lblSubUnidadesSinPreguntasTitulo = new Label();
            lblSubUnidadesSinPreguntas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            SuspendLayout();
            // 
            // cbAsignaturas
            // 
            cbAsignaturas.FormattingEnabled = true;
            cbAsignaturas.Location = new Point(21, 148);
            cbAsignaturas.Name = "cbAsignaturas";
            cbAsignaturas.Size = new Size(402, 23);
            cbAsignaturas.TabIndex = 10;
            cbAsignaturas.SelectedIndexChanged += cbAsignaturas_SelectedIndexChanged;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(24, 149);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(100, 15);
            lblAsignatura.TabIndex = 9;
            lblAsignatura.Text = "Elija la Asignatura";
            // 
            // lstUnidades
            // 
            lstUnidades.FormattingEnabled = true;
            lstUnidades.ItemHeight = 15;
            lstUnidades.Location = new Point(21, 209);
            lstUnidades.Name = "lstUnidades";
            lstUnidades.SelectionMode = SelectionMode.MultiSimple;
            lstUnidades.Size = new Size(402, 154);
            lstUnidades.TabIndex = 11;
            // 
            // btnGenerarExamen
            // 
            btnGenerarExamen.Location = new Point(21, 384);
            btnGenerarExamen.Name = "btnGenerarExamen";
            btnGenerarExamen.Size = new Size(402, 33);
            btnGenerarExamen.TabIndex = 12;
            btnGenerarExamen.Text = "Generar Examen";
            btnGenerarExamen.UseVisualStyleBackColor = true;
            btnGenerarExamen.Click += btnGenerarExamen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 191);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 13;
            label1.Text = "Seleccione las Unidades";
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreguntas.Location = new Point(455, 165);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPreguntas.Size = new Size(929, 532);
            dgvPreguntas.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(455, 74);
            label2.Name = "label2";
            label2.Size = new Size(190, 30);
            label2.TabIndex = 57;
            label2.Text = "Examen Generado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(464, 128);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 58;
            label3.Text = "Asignatura:";
            // 
            // lblAsignExamen
            // 
            lblAsignExamen.AutoSize = true;
            lblAsignExamen.Font = new Font("Segoe UI", 12F);
            lblAsignExamen.Location = new Point(556, 128);
            lblAsignExamen.Name = "lblAsignExamen";
            lblAsignExamen.Size = new Size(16, 21);
            lblAsignExamen.TabIndex = 59;
            lblAsignExamen.Text = "-";
            // 
            // lblSubUnidadesSinPreguntasTitulo
            // 
            lblSubUnidadesSinPreguntasTitulo.AutoSize = true;
            lblSubUnidadesSinPreguntasTitulo.Font = new Font("Segoe UI", 12F);
            lblSubUnidadesSinPreguntasTitulo.Location = new Point(24, 463);
            lblSubUnidadesSinPreguntasTitulo.Name = "lblSubUnidadesSinPreguntasTitulo";
            lblSubUnidadesSinPreguntasTitulo.Size = new Size(207, 21);
            lblSubUnidadesSinPreguntasTitulo.TabIndex = 60;
            lblSubUnidadesSinPreguntasTitulo.Text = "Sub Unidades sin Preguntas:";
            lblSubUnidadesSinPreguntasTitulo.Visible = false;
            // 
            // lblSubUnidadesSinPreguntas
            // 
            lblSubUnidadesSinPreguntas.AutoSize = true;
            lblSubUnidadesSinPreguntas.Location = new Point(34, 505);
            lblSubUnidadesSinPreguntas.Name = "lblSubUnidadesSinPreguntas";
            lblSubUnidadesSinPreguntas.Size = new Size(0, 15);
            lblSubUnidadesSinPreguntas.TabIndex = 61;
            // 
            // GeneradorExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1409, 741);
            Controls.Add(lblSubUnidadesSinPreguntas);
            Controls.Add(lblSubUnidadesSinPreguntasTitulo);
            Controls.Add(lblAsignExamen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvPreguntas);
            Controls.Add(label1);
            Controls.Add(btnGenerarExamen);
            Controls.Add(lstUnidades);
            Controls.Add(cbAsignaturas);
            Controls.Add(lblAsignatura);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneradorExamenes";
            StartPosition = FormStartPosition.Manual;
            Text = "GeneradorExamenes";
            Load += GeneradorExamenes_Load;
            VisibleChanged += GeneradorExamenes_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAsignaturas;
        private Label lblAsignatura;
        private ListBox lstUnidades;
        private Button btnGenerarExamen;
        private Label label1;
        private DataGridView dgvPreguntas;
        private Label label2;
        private Label label3;
        private Label lblAsignExamen;
        private Label lblSubUnidadesSinPreguntasTitulo;
        private Label lblSubUnidadesSinPreguntas;
    }
}