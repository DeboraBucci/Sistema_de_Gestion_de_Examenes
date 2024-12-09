namespace SistemaDeGestionDeExamenes
{
    partial class AdministradorPreguntas
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
            lblCrearSubunidad = new Label();
            lblSubUnidad = new Label();
            lblCrearUnidad = new Label();
            lblCrearAsignatura = new Label();
            cbSubUnidades = new ComboBox();
            cbUnidades = new ComboBox();
            lblUnidad = new Label();
            lblFiltroUnidad = new Label();
            cbFiltroUnidad = new ComboBox();
            lblFiltroAsignatura = new Label();
            cbFiltroAsignatura = new ComboBox();
            lblPreguntas = new Label();
            dgvPreguntas = new DataGridView();
            gbOpcionCorrecta = new GroupBox();
            rbOpc4 = new RadioButton();
            rbOpc3 = new RadioButton();
            rbOpc2 = new RadioButton();
            rbOpc1 = new RadioButton();
            txtOpc4 = new TextBox();
            lblOpc4 = new Label();
            txtOpc3 = new TextBox();
            lblOpc3 = new Label();
            txtOpc2 = new TextBox();
            lblOpc2 = new Label();
            txtOpc1 = new TextBox();
            lblOpc1 = new Label();
            txtPregunta = new TextBox();
            lblPregunta = new Label();
            btnEliminarPreg = new Button();
            btnEditarPreg = new Button();
            btnAgregarPreg = new Button();
            btnCancelar = new Button();
            btnAceptarCambios = new Button();
            pnlCrearNuevaSubUnidad = new Panel();
            cbSeleccionUnidad = new ComboBox();
            lblElijaUnid = new Label();
            cbSeleccionAsig = new ComboBox();
            lblElijaAsig = new Label();
            txtNuevaUnidad = new TextBox();
            lblNuevaUnidad = new Label();
            txtNuevaAsig = new TextBox();
            lblNuevaAsignatura = new Label();
            txtNuevaSubUnidad = new TextBox();
            lblNuevaSubUnidad = new Label();
            btnCancelarNueva = new Button();
            btnCrearNueva = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).BeginInit();
            gbOpcionCorrecta.SuspendLayout();
            pnlCrearNuevaSubUnidad.SuspendLayout();
            SuspendLayout();
            // 
            // cbAsignaturas
            // 
            cbAsignaturas.FormattingEnabled = true;
            cbAsignaturas.Location = new Point(23, 86);
            cbAsignaturas.Name = "cbAsignaturas";
            cbAsignaturas.Size = new Size(402, 23);
            cbAsignaturas.TabIndex = 8;
            cbAsignaturas.SelectedIndexChanged += cbAsignaturas_SelectedIndexChanged;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(23, 66);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(100, 15);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Elija la Asignatura";
            // 
            // lblCrearSubunidad
            // 
            lblCrearSubunidad.AutoSize = true;
            lblCrearSubunidad.Cursor = Cursors.Hand;
            lblCrearSubunidad.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblCrearSubunidad.ForeColor = Color.DodgerBlue;
            lblCrearSubunidad.ImageAlign = ContentAlignment.TopLeft;
            lblCrearSubunidad.Location = new Point(23, 252);
            lblCrearSubunidad.Name = "lblCrearSubunidad";
            lblCrearSubunidad.Size = new Size(132, 15);
            lblCrearSubunidad.TabIndex = 54;
            lblCrearSubunidad.Text = "Crear nueva sub unidad";
            lblCrearSubunidad.Click += lblCrearSubunidad_Click;
            // 
            // lblSubUnidad
            // 
            lblSubUnidad.AutoSize = true;
            lblSubUnidad.Location = new Point(23, 208);
            lblSubUnidad.Name = "lblSubUnidad";
            lblSubUnidad.Size = new Size(104, 15);
            lblSubUnidad.TabIndex = 53;
            lblSubUnidad.Text = "Elija la Sub Unidad";
            // 
            // lblCrearUnidad
            // 
            lblCrearUnidad.AutoSize = true;
            lblCrearUnidad.Cursor = Cursors.Hand;
            lblCrearUnidad.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblCrearUnidad.ForeColor = Color.DodgerBlue;
            lblCrearUnidad.Location = new Point(23, 184);
            lblCrearUnidad.Name = "lblCrearUnidad";
            lblCrearUnidad.Size = new Size(110, 15);
            lblCrearUnidad.TabIndex = 52;
            lblCrearUnidad.Text = "Crear nueva unidad";
            lblCrearUnidad.Click += lblCrearUnidad_Click;
            // 
            // lblCrearAsignatura
            // 
            lblCrearAsignatura.AutoSize = true;
            lblCrearAsignatura.Cursor = Cursors.Hand;
            lblCrearAsignatura.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            lblCrearAsignatura.ForeColor = Color.DodgerBlue;
            lblCrearAsignatura.Location = new Point(23, 113);
            lblCrearAsignatura.Name = "lblCrearAsignatura";
            lblCrearAsignatura.Size = new Size(128, 15);
            lblCrearAsignatura.TabIndex = 51;
            lblCrearAsignatura.Text = "Crear nueva asignatura";
            lblCrearAsignatura.Click += lblCrearAsignatura_Click;
            // 
            // cbSubUnidades
            // 
            cbSubUnidades.FormattingEnabled = true;
            cbSubUnidades.Location = new Point(23, 226);
            cbSubUnidades.Name = "cbSubUnidades";
            cbSubUnidades.Size = new Size(402, 23);
            cbSubUnidades.TabIndex = 50;
            // 
            // cbUnidades
            // 
            cbUnidades.FormattingEnabled = true;
            cbUnidades.Location = new Point(23, 158);
            cbUnidades.Name = "cbUnidades";
            cbUnidades.Size = new Size(402, 23);
            cbUnidades.TabIndex = 49;
            cbUnidades.SelectedIndexChanged += cbUnidades_SelectedIndexChanged;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(23, 138);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(81, 15);
            lblUnidad.TabIndex = 48;
            lblUnidad.Text = "Elija la Unidad";
            // 
            // lblFiltroUnidad
            // 
            lblFiltroUnidad.AutoSize = true;
            lblFiltroUnidad.Location = new Point(1129, 64);
            lblFiltroUnidad.Name = "lblFiltroUnidad";
            lblFiltroUnidad.Size = new Size(99, 15);
            lblFiltroUnidad.TabIndex = 60;
            lblFiltroUnidad.Text = "Filtrar por Unidad";
            // 
            // cbFiltroUnidad
            // 
            cbFiltroUnidad.FormattingEnabled = true;
            cbFiltroUnidad.Location = new Point(1234, 61);
            cbFiltroUnidad.Name = "cbFiltroUnidad";
            cbFiltroUnidad.Size = new Size(147, 23);
            cbFiltroUnidad.TabIndex = 59;
            cbFiltroUnidad.SelectedIndexChanged += cbFiltroUnidad_SelectedIndexChanged;
            // 
            // lblFiltroAsignatura
            // 
            lblFiltroAsignatura.AutoSize = true;
            lblFiltroAsignatura.Location = new Point(852, 64);
            lblFiltroAsignatura.Name = "lblFiltroAsignatura";
            lblFiltroAsignatura.Size = new Size(118, 15);
            lblFiltroAsignatura.TabIndex = 58;
            lblFiltroAsignatura.Text = "Filtrar por Asignatura";
            // 
            // cbFiltroAsignatura
            // 
            cbFiltroAsignatura.FormattingEnabled = true;
            cbFiltroAsignatura.Location = new Point(976, 61);
            cbFiltroAsignatura.Name = "cbFiltroAsignatura";
            cbFiltroAsignatura.Size = new Size(147, 23);
            cbFiltroAsignatura.TabIndex = 57;
            cbFiltroAsignatura.SelectedIndexChanged += cbFiltroAsignatura_SelectedIndexChanged;
            // 
            // lblPreguntas
            // 
            lblPreguntas.AutoSize = true;
            lblPreguntas.Font = new Font("Segoe UI", 16F);
            lblPreguntas.Location = new Point(452, 57);
            lblPreguntas.Name = "lblPreguntas";
            lblPreguntas.Size = new Size(109, 30);
            lblPreguntas.TabIndex = 56;
            lblPreguntas.Text = "Preguntas";
            // 
            // dgvPreguntas
            // 
            dgvPreguntas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreguntas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreguntas.Location = new Point(472, 90);
            dgvPreguntas.Name = "dgvPreguntas";
            dgvPreguntas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPreguntas.Size = new Size(929, 569);
            dgvPreguntas.TabIndex = 55;
            // 
            // gbOpcionCorrecta
            // 
            gbOpcionCorrecta.Controls.Add(rbOpc4);
            gbOpcionCorrecta.Controls.Add(rbOpc3);
            gbOpcionCorrecta.Controls.Add(rbOpc2);
            gbOpcionCorrecta.Controls.Add(rbOpc1);
            gbOpcionCorrecta.Location = new Point(23, 541);
            gbOpcionCorrecta.Name = "gbOpcionCorrecta";
            gbOpcionCorrecta.Size = new Size(402, 75);
            gbOpcionCorrecta.TabIndex = 71;
            gbOpcionCorrecta.TabStop = false;
            gbOpcionCorrecta.Text = "Opcion Correcta";
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
            // txtOpc4
            // 
            txtOpc4.Location = new Point(23, 503);
            txtOpc4.Name = "txtOpc4";
            txtOpc4.Size = new Size(402, 23);
            txtOpc4.TabIndex = 70;
            // 
            // lblOpc4
            // 
            lblOpc4.AutoSize = true;
            lblOpc4.Location = new Point(23, 485);
            lblOpc4.Name = "lblOpc4";
            lblOpc4.Size = new Size(55, 15);
            lblOpc4.TabIndex = 69;
            lblOpc4.Text = "Opcion 4";
            // 
            // txtOpc3
            // 
            txtOpc3.Location = new Point(23, 458);
            txtOpc3.Name = "txtOpc3";
            txtOpc3.Size = new Size(402, 23);
            txtOpc3.TabIndex = 68;
            // 
            // lblOpc3
            // 
            lblOpc3.AutoSize = true;
            lblOpc3.Location = new Point(23, 440);
            lblOpc3.Name = "lblOpc3";
            lblOpc3.Size = new Size(55, 15);
            lblOpc3.TabIndex = 67;
            lblOpc3.Text = "Opcion 3";
            // 
            // txtOpc2
            // 
            txtOpc2.Location = new Point(23, 408);
            txtOpc2.Name = "txtOpc2";
            txtOpc2.Size = new Size(402, 23);
            txtOpc2.TabIndex = 66;
            // 
            // lblOpc2
            // 
            lblOpc2.AutoSize = true;
            lblOpc2.Location = new Point(23, 390);
            lblOpc2.Name = "lblOpc2";
            lblOpc2.Size = new Size(55, 15);
            lblOpc2.TabIndex = 65;
            lblOpc2.Text = "Opcion 2";
            // 
            // txtOpc1
            // 
            txtOpc1.Location = new Point(23, 359);
            txtOpc1.Name = "txtOpc1";
            txtOpc1.Size = new Size(402, 23);
            txtOpc1.TabIndex = 64;
            // 
            // lblOpc1
            // 
            lblOpc1.AutoSize = true;
            lblOpc1.Location = new Point(23, 341);
            lblOpc1.Name = "lblOpc1";
            lblOpc1.Size = new Size(55, 15);
            lblOpc1.TabIndex = 63;
            lblOpc1.Text = "Opcion 1";
            // 
            // txtPregunta
            // 
            txtPregunta.Location = new Point(23, 302);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(402, 23);
            txtPregunta.TabIndex = 62;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(23, 284);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(114, 15);
            lblPregunta.TabIndex = 61;
            lblPregunta.Text = "Texto de la Pregunta";
            // 
            // btnEliminarPreg
            // 
            btnEliminarPreg.Cursor = Cursors.Hand;
            btnEliminarPreg.Location = new Point(297, 639);
            btnEliminarPreg.Name = "btnEliminarPreg";
            btnEliminarPreg.Size = new Size(130, 31);
            btnEliminarPreg.TabIndex = 74;
            btnEliminarPreg.Text = "Eliminar Seleccionada";
            btnEliminarPreg.UseVisualStyleBackColor = true;
            btnEliminarPreg.Click += btnEliminarPreg_Click;
            // 
            // btnEditarPreg
            // 
            btnEditarPreg.Cursor = Cursors.Hand;
            btnEditarPreg.Location = new Point(161, 639);
            btnEditarPreg.Name = "btnEditarPreg";
            btnEditarPreg.Size = new Size(130, 31);
            btnEditarPreg.TabIndex = 73;
            btnEditarPreg.Text = "Editar Seleccionada";
            btnEditarPreg.UseVisualStyleBackColor = true;
            btnEditarPreg.Click += btnEditarPreg_Click;
            // 
            // btnAgregarPreg
            // 
            btnAgregarPreg.Cursor = Cursors.Hand;
            btnAgregarPreg.Location = new Point(25, 639);
            btnAgregarPreg.Name = "btnAgregarPreg";
            btnAgregarPreg.Size = new Size(130, 31);
            btnAgregarPreg.TabIndex = 72;
            btnAgregarPreg.Text = "Agregar Pregunta";
            btnAgregarPreg.UseVisualStyleBackColor = true;
            btnAgregarPreg.Click += btnAgregarPreg_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(237, 639);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 31);
            btnCancelar.TabIndex = 76;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptarCambios
            // 
            btnAceptarCambios.Cursor = Cursors.Hand;
            btnAceptarCambios.Location = new Point(86, 639);
            btnAceptarCambios.Name = "btnAceptarCambios";
            btnAceptarCambios.Size = new Size(130, 31);
            btnAceptarCambios.TabIndex = 75;
            btnAceptarCambios.Text = "Aceptar Cambios";
            btnAceptarCambios.UseVisualStyleBackColor = true;
            btnAceptarCambios.Visible = false;
            btnAceptarCambios.Click += btnAceptarCambios_Click;
            // 
            // pnlCrearNuevaSubUnidad
            // 
            pnlCrearNuevaSubUnidad.Controls.Add(cbSeleccionUnidad);
            pnlCrearNuevaSubUnidad.Controls.Add(lblElijaUnid);
            pnlCrearNuevaSubUnidad.Controls.Add(cbSeleccionAsig);
            pnlCrearNuevaSubUnidad.Controls.Add(lblElijaAsig);
            pnlCrearNuevaSubUnidad.Controls.Add(txtNuevaUnidad);
            pnlCrearNuevaSubUnidad.Controls.Add(lblNuevaUnidad);
            pnlCrearNuevaSubUnidad.Controls.Add(txtNuevaAsig);
            pnlCrearNuevaSubUnidad.Controls.Add(lblNuevaAsignatura);
            pnlCrearNuevaSubUnidad.Controls.Add(txtNuevaSubUnidad);
            pnlCrearNuevaSubUnidad.Controls.Add(lblNuevaSubUnidad);
            pnlCrearNuevaSubUnidad.Controls.Add(btnCancelarNueva);
            pnlCrearNuevaSubUnidad.Controls.Add(btnCrearNueva);
            pnlCrearNuevaSubUnidad.Location = new Point(469, 117);
            pnlCrearNuevaSubUnidad.Name = "pnlCrearNuevaSubUnidad";
            pnlCrearNuevaSubUnidad.Size = new Size(410, 288);
            pnlCrearNuevaSubUnidad.TabIndex = 79;
            pnlCrearNuevaSubUnidad.Visible = false;
            // 
            // cbSeleccionUnidad
            // 
            cbSeleccionUnidad.FormattingEnabled = true;
            cbSeleccionUnidad.Location = new Point(33, 121);
            cbSeleccionUnidad.Name = "cbSeleccionUnidad";
            cbSeleccionUnidad.Size = new Size(346, 23);
            cbSeleccionUnidad.TabIndex = 81;
            // 
            // lblElijaUnid
            // 
            lblElijaUnid.AutoSize = true;
            lblElijaUnid.Location = new Point(33, 96);
            lblElijaUnid.Name = "lblElijaUnid";
            lblElijaUnid.Size = new Size(81, 15);
            lblElijaUnid.TabIndex = 80;
            lblElijaUnid.Text = "Elija la Unidad";
            lblElijaUnid.Visible = false;
            // 
            // cbSeleccionAsig
            // 
            cbSeleccionAsig.FormattingEnabled = true;
            cbSeleccionAsig.Location = new Point(33, 56);
            cbSeleccionAsig.Name = "cbSeleccionAsig";
            cbSeleccionAsig.Size = new Size(346, 23);
            cbSeleccionAsig.TabIndex = 81;
            cbSeleccionAsig.SelectedIndexChanged += cbSeleccionAsig_SelectedIndexChanged;
            // 
            // lblElijaAsig
            // 
            lblElijaAsig.AutoSize = true;
            lblElijaAsig.Location = new Point(33, 36);
            lblElijaAsig.Name = "lblElijaAsig";
            lblElijaAsig.Size = new Size(100, 15);
            lblElijaAsig.TabIndex = 80;
            lblElijaAsig.Text = "Elija la Asignatura";
            lblElijaAsig.Visible = false;
            // 
            // txtNuevaUnidad
            // 
            txtNuevaUnidad.Location = new Point(33, 121);
            txtNuevaUnidad.Name = "txtNuevaUnidad";
            txtNuevaUnidad.PlaceholderText = "Ejemplo: Ecuaciones";
            txtNuevaUnidad.Size = new Size(346, 23);
            txtNuevaUnidad.TabIndex = 45;
            // 
            // lblNuevaUnidad
            // 
            lblNuevaUnidad.AutoSize = true;
            lblNuevaUnidad.Location = new Point(33, 98);
            lblNuevaUnidad.Name = "lblNuevaUnidad";
            lblNuevaUnidad.Size = new Size(157, 15);
            lblNuevaUnidad.TabIndex = 46;
            lblNuevaUnidad.Text = "Nombre de la Nueva Unidad";
            // 
            // txtNuevaAsig
            // 
            txtNuevaAsig.Location = new Point(33, 56);
            txtNuevaAsig.Name = "txtNuevaAsig";
            txtNuevaAsig.PlaceholderText = "Ejemplo: Matematicas";
            txtNuevaAsig.Size = new Size(346, 23);
            txtNuevaAsig.TabIndex = 43;
            // 
            // lblNuevaAsignatura
            // 
            lblNuevaAsignatura.AutoSize = true;
            lblNuevaAsignatura.Location = new Point(33, 33);
            lblNuevaAsignatura.Name = "lblNuevaAsignatura";
            lblNuevaAsignatura.Size = new Size(176, 15);
            lblNuevaAsignatura.TabIndex = 44;
            lblNuevaAsignatura.Text = "Nombre de la Nueva Asignatura";
            // 
            // txtNuevaSubUnidad
            // 
            txtNuevaSubUnidad.Location = new Point(33, 191);
            txtNuevaSubUnidad.Name = "txtNuevaSubUnidad";
            txtNuevaSubUnidad.PlaceholderText = "Ejemplo: Limites,Derivadas,Integrales...";
            txtNuevaSubUnidad.Size = new Size(346, 23);
            txtNuevaSubUnidad.TabIndex = 41;
            // 
            // lblNuevaSubUnidad
            // 
            lblNuevaSubUnidad.AutoSize = true;
            lblNuevaSubUnidad.Location = new Point(33, 168);
            lblNuevaSubUnidad.Name = "lblNuevaSubUnidad";
            lblNuevaSubUnidad.Size = new Size(180, 15);
            lblNuevaSubUnidad.TabIndex = 41;
            lblNuevaSubUnidad.Text = "Nombre de la Nueva Sub Unidad";
            // 
            // btnCancelarNueva
            // 
            btnCancelarNueva.Cursor = Cursors.Hand;
            btnCancelarNueva.Location = new Point(202, 234);
            btnCancelarNueva.Name = "btnCancelarNueva";
            btnCancelarNueva.Size = new Size(130, 31);
            btnCancelarNueva.TabIndex = 42;
            btnCancelarNueva.Text = "Cancelar";
            btnCancelarNueva.UseVisualStyleBackColor = true;
            btnCancelarNueva.Click += btnCancelarNueva_Click;
            // 
            // btnCrearNueva
            // 
            btnCrearNueva.Cursor = Cursors.Hand;
            btnCrearNueva.Location = new Point(66, 234);
            btnCrearNueva.Name = "btnCrearNueva";
            btnCrearNueva.Size = new Size(130, 31);
            btnCrearNueva.TabIndex = 41;
            btnCrearNueva.Text = "Crear";
            btnCrearNueva.UseVisualStyleBackColor = true;
            btnCrearNueva.Click += btnCrearNueva_Click;
            // 
            // AdministradorPreguntas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1409, 741);
            Controls.Add(pnlCrearNuevaSubUnidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptarCambios);
            Controls.Add(btnEliminarPreg);
            Controls.Add(btnEditarPreg);
            Controls.Add(btnAgregarPreg);
            Controls.Add(gbOpcionCorrecta);
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
            Controls.Add(lblFiltroUnidad);
            Controls.Add(cbFiltroUnidad);
            Controls.Add(lblFiltroAsignatura);
            Controls.Add(cbFiltroAsignatura);
            Controls.Add(lblPreguntas);
            Controls.Add(lblCrearSubunidad);
            Controls.Add(lblSubUnidad);
            Controls.Add(lblCrearUnidad);
            Controls.Add(lblCrearAsignatura);
            Controls.Add(cbSubUnidades);
            Controls.Add(cbUnidades);
            Controls.Add(lblUnidad);
            Controls.Add(cbAsignaturas);
            Controls.Add(lblAsignatura);
            Controls.Add(dgvPreguntas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministradorPreguntas";
            StartPosition = FormStartPosition.Manual;
            Text = "AdministradorPreguntas";
            ((System.ComponentModel.ISupportInitialize)dgvPreguntas).EndInit();
            gbOpcionCorrecta.ResumeLayout(false);
            gbOpcionCorrecta.PerformLayout();
            pnlCrearNuevaSubUnidad.ResumeLayout(false);
            pnlCrearNuevaSubUnidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAsignaturas;
        private Label lblAsignatura;
        private Label lblCrearSubunidad;
        private Label lblSubUnidad;
        private Label lblCrearUnidad;
        private Label lblCrearAsignatura;
        private ComboBox cbSubUnidades;
        private ComboBox cbUnidades;
        private Label lblUnidad;
        private Label lblFiltroUnidad;
        private ComboBox cbFiltroUnidad;
        private Label lblFiltroAsignatura;
        private ComboBox cbFiltroAsignatura;
        private Label lblPreguntas;
        private DataGridView dgvPreguntas;
        private GroupBox gbOpcionCorrecta;
        private RadioButton rbOpc4;
        private RadioButton rbOpc3;
        private RadioButton rbOpc2;
        private RadioButton rbOpc1;
        private TextBox txtOpc4;
        private Label lblOpc4;
        private TextBox txtOpc3;
        private Label lblOpc3;
        private TextBox txtOpc2;
        private Label lblOpc2;
        private TextBox txtOpc1;
        private Label lblOpc1;
        private TextBox txtPregunta;
        private Label lblPregunta;
        private Button btnEliminarPreg;
        private Button btnEditarPreg;
        private Button btnAgregarPreg;
        private Button btnCancelar;
        private Button btnAceptarCambios;
        private Panel pnlCrearNuevaSubUnidad;
        private TextBox txtNuevaSubUnidad;
        private Label lblNuevaSubUnidad;
        private Button btnCancelarNueva;
        private Button btnCrearNueva;
        private TextBox txtNuevaUnidad;
        private Label lblNuevaUnidad;
        private TextBox txtNuevaAsig;
        private Label lblNuevaAsignatura;
        private ComboBox cbSeleccionUnidad;
        private Label lblElijaUnid;
        private ComboBox cbSeleccionAsig;
        private Label lblElijaAsig;
    }
}