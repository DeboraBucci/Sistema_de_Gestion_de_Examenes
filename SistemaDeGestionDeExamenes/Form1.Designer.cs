namespace SistemaDeGestionDeExamenes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdministrarBancoPreguntas = new Button();
            btnGenerarExamenes = new Button();
            btnCorregirExamenes = new Button();
            btnImprimirExamenes = new Button();
            btnVolverMenu = new Button();
            lblAsignatura = new Label();
            cbAsignaturas = new ComboBox();
            dgvPreguntas = new DataGridView();
            lblPreguntas = new Label();
            cbUnidades = new ComboBox();
            lblUnidad = new Label();
            lblPregunta = new Label();
            txtPregunta = new TextBox();
            txtOpc1 = new TextBox();
            lblOpc1 = new Label();
            txtOpc2 = new TextBox();
            lblOpc2 = new Label();
            txtOpc3 = new TextBox();
            lblOpc3 = new Label();
            txtOpc4 = new TextBox();
            lblOpc4 = new Label();
            btnAgregarPreg = new Button();
            btnEditarPreg = new Button();
            btnEliminarPreg = new Button();
            gbOpcionCorrecta = new GroupBox();
            rbOpc4 = new RadioButton();
            rbOpc3 = new RadioButton();
            rbOpc2 = new RadioButton();
            rbOpc1 = new RadioButton();
            cbSubUnidades = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblCrearAsignatura = new Label();
            lblCrearUnidad = new Label();
            lblCrearSubunidad = new Label();
            lblSubUnidad = new Label();
            btnAceptarCambios = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            gbOpcionCorrecta.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdministrarBancoPreguntas
            // 
            btnAdministrarBancoPreguntas.Cursor = Cursors.Hand;
            btnAdministrarBancoPreguntas.Font = new Font("Segoe UI", 14F);
            btnAdministrarBancoPreguntas.Location = new Point(468, 170);
            btnAdministrarBancoPreguntas.Name = "btnAdministrarBancoPreguntas";
            btnAdministrarBancoPreguntas.Size = new Size(429, 56);
            btnAdministrarBancoPreguntas.TabIndex = 0;
            btnAdministrarBancoPreguntas.Text = "Administrar Banco de Preguntas";
            btnAdministrarBancoPreguntas.UseVisualStyleBackColor = true;
            btnAdministrarBancoPreguntas.Click += btnAdministrarBancoPreguntas_Click;
            // 
            // btnGenerarExamenes
            // 
            btnGenerarExamenes.Cursor = Cursors.Hand;
            btnGenerarExamenes.Font = new Font("Segoe UI", 14F);
            btnGenerarExamenes.Location = new Point(468, 242);
            btnGenerarExamenes.Name = "btnGenerarExamenes";
            btnGenerarExamenes.Size = new Size(429, 56);
            btnGenerarExamenes.TabIndex = 1;
            btnGenerarExamenes.Text = "Generar Examenes";
            btnGenerarExamenes.UseVisualStyleBackColor = true;
            btnGenerarExamenes.Click += btnGenerarExamenes_Click;
            // 
            // btnCorregirExamenes
            // 
            btnCorregirExamenes.Cursor = Cursors.Hand;
            btnCorregirExamenes.Font = new Font("Segoe UI", 14F);
            btnCorregirExamenes.Location = new Point(468, 316);
            btnCorregirExamenes.Name = "btnCorregirExamenes";
            btnCorregirExamenes.Size = new Size(429, 56);
            btnCorregirExamenes.TabIndex = 2;
            btnCorregirExamenes.Text = "Corregir Examenes";
            btnCorregirExamenes.UseVisualStyleBackColor = true;
            btnCorregirExamenes.Click += btnCorregirExamenes_Click;
            // 
            // btnImprimirExamenes
            // 
            btnImprimirExamenes.Cursor = Cursors.Hand;
            btnImprimirExamenes.Font = new Font("Segoe UI", 14F);
            btnImprimirExamenes.Location = new Point(468, 389);
            btnImprimirExamenes.Name = "btnImprimirExamenes";
            btnImprimirExamenes.Size = new Size(429, 56);
            btnImprimirExamenes.TabIndex = 3;
            btnImprimirExamenes.Text = "Imprimir Examenes";
            btnImprimirExamenes.UseVisualStyleBackColor = true;
            btnImprimirExamenes.Click += btnImprimirExamenes_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackColor = Color.RoyalBlue;
            btnVolverMenu.Cursor = Cursors.Hand;
            btnVolverMenu.FlatAppearance.BorderSize = 0;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolverMenu.ForeColor = SystemColors.ControlLight;
            btnVolverMenu.Location = new Point(31, 23);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(160, 36);
            btnVolverMenu.TabIndex = 4;
            btnVolverMenu.Text = "Volver al Menu";
            btnVolverMenu.UseVisualStyleBackColor = false;
            btnVolverMenu.Visible = false;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(38, 87);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(100, 15);
            lblAsignatura.TabIndex = 5;
            lblAsignatura.Text = "Elija la Asignatura";
            lblAsignatura.Visible = false;
            // 
            // cbAsignaturas
            // 
            cbAsignaturas.FormattingEnabled = true;
            cbAsignaturas.Location = new Point(38, 107);
            cbAsignaturas.Name = "cbAsignaturas";
            cbAsignaturas.Size = new Size(402, 23);
            cbAsignaturas.TabIndex = 6;
            cbAsignaturas.Visible = false;
            cbAsignaturas.SelectedIndexChanged += cbAsignaturas_SelectedIndexChanged;
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreguntas.Location = new Point(468, 114);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPreguntas.Size = new Size(929, 569);
            dgvPreguntas.TabIndex = 7;
            dgvPreguntas.Visible = false;
            // 
            // lblPreguntas
            // 
            lblPreguntas.AutoSize = true;
            lblPreguntas.Location = new Point(468, 94);
            lblPreguntas.Name = "lblPreguntas";
            lblPreguntas.Size = new Size(60, 15);
            lblPreguntas.TabIndex = 8;
            lblPreguntas.Text = "Preguntas";
            lblPreguntas.Visible = false;
            // 
            // cbUnidades
            // 
            cbUnidades.FormattingEnabled = true;
            cbUnidades.Location = new Point(38, 178);
            cbUnidades.Name = "cbUnidades";
            cbUnidades.Size = new Size(402, 23);
            cbUnidades.TabIndex = 10;
            cbUnidades.Visible = false;
            cbUnidades.SelectedIndexChanged += cbUnidades_SelectedIndexChanged;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(38, 158);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(81, 15);
            lblUnidad.TabIndex = 9;
            lblUnidad.Text = "Elija la Unidad";
            lblUnidad.Visible = false;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(38, 300);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(114, 15);
            lblPregunta.TabIndex = 11;
            lblPregunta.Text = "Texto de la Pregunta";
            lblPregunta.Visible = false;
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(38, 318);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(402, 23);
            txtPregunta.TabIndex = 12;
            txtPregunta.Visible = false;
            // 
            // txtOpc1
            // 
            txtOpc1.Location = new Point(38, 375);
            txtOpc1.Name = "txtOpc1";
            txtOpc1.Size = new Size(402, 23);
            txtOpc1.TabIndex = 14;
            txtOpc1.Visible = false;
            // 
            // lblOpc1
            // 
            lblOpc1.AutoSize = true;
            lblOpc1.Location = new Point(38, 357);
            lblOpc1.Name = "lblOpc1";
            lblOpc1.Size = new Size(55, 15);
            lblOpc1.TabIndex = 13;
            lblOpc1.Text = "Opcion 1";
            lblOpc1.Visible = false;
            // 
            // txtOpc2
            // 
            txtOpc2.Location = new Point(38, 424);
            txtOpc2.Name = "txtOpc2";
            txtOpc2.Size = new Size(402, 23);
            txtOpc2.TabIndex = 16;
            txtOpc2.Visible = false;
            // 
            // lblOpc2
            // 
            lblOpc2.AutoSize = true;
            lblOpc2.Location = new Point(38, 406);
            lblOpc2.Name = "lblOpc2";
            lblOpc2.Size = new Size(55, 15);
            lblOpc2.TabIndex = 15;
            lblOpc2.Text = "Opcion 2";
            lblOpc2.Visible = false;
            // 
            // txtOpc3
            // 
            txtOpc3.Location = new Point(38, 474);
            txtOpc3.Name = "txtOpc3";
            txtOpc3.Size = new Size(402, 23);
            txtOpc3.TabIndex = 18;
            txtOpc3.Visible = false;
            // 
            // lblOpc3
            // 
            lblOpc3.AutoSize = true;
            lblOpc3.Location = new Point(38, 456);
            lblOpc3.Name = "lblOpc3";
            lblOpc3.Size = new Size(55, 15);
            lblOpc3.TabIndex = 17;
            lblOpc3.Text = "Opcion 3";
            lblOpc3.Visible = false;
            // 
            // txtOpc4
            // 
            txtOpc4.Location = new Point(38, 519);
            txtOpc4.Name = "txtOpc4";
            txtOpc4.Size = new Size(402, 23);
            txtOpc4.TabIndex = 20;
            txtOpc4.Visible = false;
            // 
            // lblOpc4
            // 
            lblOpc4.AutoSize = true;
            lblOpc4.Location = new Point(38, 501);
            lblOpc4.Name = "lblOpc4";
            lblOpc4.Size = new Size(55, 15);
            lblOpc4.TabIndex = 19;
            lblOpc4.Text = "Opcion 4";
            lblOpc4.Visible = false;
            // 
            // btnAgregarPreg
            // 
            btnAgregarPreg.Cursor = Cursors.Hand;
            btnAgregarPreg.Location = new Point(38, 650);
            btnAgregarPreg.Name = "btnAgregarPreg";
            btnAgregarPreg.Size = new Size(130, 31);
            btnAgregarPreg.TabIndex = 21;
            btnAgregarPreg.Text = "Agregar Pregunta";
            btnAgregarPreg.UseVisualStyleBackColor = true;
            btnAgregarPreg.Visible = false;
            btnAgregarPreg.Click += btnAgregarPreg_Click;
            // 
            // btnEditarPreg
            // 
            btnEditarPreg.Cursor = Cursors.Hand;
            btnEditarPreg.Location = new Point(174, 650);
            btnEditarPreg.Name = "btnEditarPreg";
            btnEditarPreg.Size = new Size(130, 31);
            btnEditarPreg.TabIndex = 22;
            btnEditarPreg.Text = "Editar Seleccionada";
            btnEditarPreg.UseVisualStyleBackColor = true;
            btnEditarPreg.Visible = false;
            btnEditarPreg.Click += btnEditarPreg_Click;
            // 
            // btnEliminarPreg
            // 
            btnEliminarPreg.Cursor = Cursors.Hand;
            btnEliminarPreg.Location = new Point(310, 650);
            btnEliminarPreg.Name = "btnEliminarPreg";
            btnEliminarPreg.Size = new Size(130, 31);
            btnEliminarPreg.TabIndex = 23;
            btnEliminarPreg.Text = "Eliminar Seleccionada";
            btnEliminarPreg.UseVisualStyleBackColor = true;
            btnEliminarPreg.Visible = false;
            btnEliminarPreg.Click += btnEliminarPreg_Click;
            // 
            // gbOpcionCorrecta
            // 
            gbOpcionCorrecta.Controls.Add(rbOpc4);
            gbOpcionCorrecta.Controls.Add(rbOpc3);
            gbOpcionCorrecta.Controls.Add(rbOpc2);
            gbOpcionCorrecta.Controls.Add(rbOpc1);
            gbOpcionCorrecta.Location = new Point(38, 557);
            gbOpcionCorrecta.Name = "gbOpcionCorrecta";
            gbOpcionCorrecta.Size = new Size(402, 75);
            gbOpcionCorrecta.TabIndex = 24;
            gbOpcionCorrecta.TabStop = false;
            gbOpcionCorrecta.Text = "Opcion Correcta";
            gbOpcionCorrecta.Visible = false;
            // 
            // rbOpc4
            // 
            rbOpc4.AutoSize = true;
            rbOpc4.Location = new Point(308, 35);
            rbOpc4.Name = "rbOpc4";
            rbOpc4.Size = new Size(56, 19);
            rbOpc4.TabIndex = 3;
            rbOpc4.Text = "Opc 4";
            rbOpc4.UseVisualStyleBackColor = true;
            // 
            // rbOpc3
            // 
            rbOpc3.AutoSize = true;
            rbOpc3.Location = new Point(214, 35);
            rbOpc3.Name = "rbOpc3";
            rbOpc3.Size = new Size(56, 19);
            rbOpc3.TabIndex = 2;
            rbOpc3.Text = "Opc 3";
            rbOpc3.UseVisualStyleBackColor = true;
            // 
            // rbOpc2
            // 
            rbOpc2.AutoSize = true;
            rbOpc2.Location = new Point(124, 35);
            rbOpc2.Name = "rbOpc2";
            rbOpc2.Size = new Size(56, 19);
            rbOpc2.TabIndex = 1;
            rbOpc2.Text = "Opc 2";
            rbOpc2.UseVisualStyleBackColor = true;
            // 
            // rbOpc1
            // 
            rbOpc1.AutoSize = true;
            rbOpc1.Checked = true;
            rbOpc1.Location = new Point(38, 35);
            rbOpc1.Name = "rbOpc1";
            rbOpc1.Size = new Size(56, 19);
            rbOpc1.TabIndex = 0;
            rbOpc1.TabStop = true;
            rbOpc1.Text = "Opc 1";
            rbOpc1.UseVisualStyleBackColor = true;
            // 
            // cbSubUnidades
            // 
            cbSubUnidades.FormattingEnabled = true;
            cbSubUnidades.Location = new Point(38, 246);
            cbSubUnidades.Name = "cbSubUnidades";
            cbSubUnidades.Size = new Size(402, 23);
            cbSubUnidades.TabIndex = 26;
            cbSubUnidades.Visible = false;
            // 
            // lblCrearAsignatura
            // 
            lblCrearAsignatura.AutoSize = true;
            lblCrearAsignatura.Cursor = Cursors.Hand;
            lblCrearAsignatura.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblCrearAsignatura.ForeColor = Color.DodgerBlue;
            lblCrearAsignatura.Location = new Point(38, 133);
            lblCrearAsignatura.Name = "lblCrearAsignatura";
            lblCrearAsignatura.Size = new Size(128, 15);
            lblCrearAsignatura.TabIndex = 29;
            lblCrearAsignatura.Text = "Crear nueva asignatura";
            lblCrearAsignatura.Visible = false;
            // 
            // lblCrearUnidad
            // 
            lblCrearUnidad.AutoSize = true;
            lblCrearUnidad.Cursor = Cursors.Hand;
            lblCrearUnidad.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblCrearUnidad.ForeColor = Color.DodgerBlue;
            lblCrearUnidad.Location = new Point(38, 204);
            lblCrearUnidad.Name = "lblCrearUnidad";
            lblCrearUnidad.Size = new Size(110, 15);
            lblCrearUnidad.TabIndex = 30;
            lblCrearUnidad.Text = "Crear nueva unidad";
            lblCrearUnidad.Visible = false;
            // 
            // lblCrearSubunidad
            // 
            lblCrearSubunidad.AutoSize = true;
            lblCrearSubunidad.Cursor = Cursors.Hand;
            lblCrearSubunidad.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblCrearSubunidad.ForeColor = Color.DodgerBlue;
            lblCrearSubunidad.Location = new Point(38, 272);
            lblCrearSubunidad.Name = "lblCrearSubunidad";
            lblCrearSubunidad.Size = new Size(129, 15);
            lblCrearSubunidad.TabIndex = 31;
            lblCrearSubunidad.Text = "Crear nueva subunidad";
            lblCrearSubunidad.Visible = false;
            // 
            // lblSubUnidad
            // 
            lblSubUnidad.AutoSize = true;
            lblSubUnidad.Location = new Point(38, 228);
            lblSubUnidad.Name = "lblSubUnidad";
            lblSubUnidad.Size = new Size(104, 15);
            lblSubUnidad.TabIndex = 32;
            lblSubUnidad.Text = "Elija la Sub Unidad";
            lblSubUnidad.Visible = false;
            // 
            // btnAceptarCambios
            // 
            btnAceptarCambios.Cursor = Cursors.Hand;
            btnAceptarCambios.Location = new Point(88, 650);
            btnAceptarCambios.Name = "btnAceptarCambios";
            btnAceptarCambios.Size = new Size(130, 31);
            btnAceptarCambios.TabIndex = 33;
            btnAceptarCambios.Text = "Aceptar Cambios";
            btnAceptarCambios.UseVisualStyleBackColor = true;
            btnAceptarCambios.Visible = false;
            btnAceptarCambios.Click += btnAceptarCambios_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(224, 650);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 31);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 695);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptarCambios);
            Controls.Add(lblSubUnidad);
            Controls.Add(lblCrearSubunidad);
            Controls.Add(lblCrearUnidad);
            Controls.Add(lblCrearAsignatura);
            Controls.Add(cbSubUnidades);
            Controls.Add(gbOpcionCorrecta);
            Controls.Add(btnEliminarPreg);
            Controls.Add(btnEditarPreg);
            Controls.Add(btnAgregarPreg);
            Controls.Add(txtOpc4);
            Controls.Add(lblOpc4);
            Controls.Add(txtOpc3);
            Controls.Add(lblOpc3);
            Controls.Add(txtOpc2);
            Controls.Add(lblOpc2);
            Controls.Add(txtOpc1);
            Controls.Add(lblOpc1);
            Controls.Add(txtPregunta);
            Controls.Add(lblPregunta);
            Controls.Add(cbUnidades);
            Controls.Add(lblUnidad);
            Controls.Add(lblPreguntas);
            Controls.Add(dgvPreguntas);
            Controls.Add(cbAsignaturas);
            Controls.Add(lblAsignatura);
            Controls.Add(btnVolverMenu);
            Controls.Add(btnImprimirExamenes);
            Controls.Add(btnCorregirExamenes);
            Controls.Add(btnGenerarExamenes);
            Controls.Add(btnAdministrarBancoPreguntas);
            Name = "Form1";
            Text = "Sistema de Gestion de Examenes";
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            gbOpcionCorrecta.ResumeLayout(false);
            gbOpcionCorrecta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdministrarBancoPreguntas;
        private Button btnGenerarExamenes;
        private Button btnCorregirExamenes;
        private Button btnImprimirExamenes;
        private Button btnVolverMenu;
        private Label lblAsignatura;
        private ComboBox cbAsignaturas;
        private DataGridView dgvPreguntas;
        private Label lblPreguntas;
        private ComboBox cbUnidades;
        private Label lblUnidad;
        private Label lblPregunta;
        private TextBox txtPregunta;
        private TextBox txtOpc1;
        private Label lblOpc1;
        private TextBox txtOpc2;
        private Label lblOpc2;
        private TextBox txtOpc3;
        private Label lblOpc3;
        private TextBox txtOpc4;
        private Label lblOpc4;
        private Button btnAgregarPreg;
        private Button btnEditarPreg;
        private Button btnEliminarPreg;
        private GroupBox gbOpcionCorrecta;
        private RadioButton rbOpc4;
        private RadioButton rbOpc3;
        private RadioButton rbOpc2;
        private RadioButton rbOpc1;
        private ComboBox cbSubUnidades;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblCrearAsignatura;
        private Label lblCrearUnidad;
        private Label lblCrearSubunidad;
        private Label lblSubUnidad;
        private Button btnAceptarCambios;
        private Button btnCancelar;
    }
}
