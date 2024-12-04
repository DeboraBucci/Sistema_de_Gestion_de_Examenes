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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAdministrarBancoPreguntas = new Button();
            btnImprimirExamenes = new Button();
            btnGenerarExamenes = new Button();
            btnCorregirExamenes = new Button();
            SuspendLayout();
            // 
            // btnAdministrarBancoPreguntas
            // 
            btnAdministrarBancoPreguntas.BackColor = SystemColors.HotTrack;
            btnAdministrarBancoPreguntas.Cursor = Cursors.Hand;
            btnAdministrarBancoPreguntas.FlatAppearance.BorderSize = 0;
            btnAdministrarBancoPreguntas.FlatStyle = FlatStyle.Flat;
            btnAdministrarBancoPreguntas.Font = new Font("Segoe UI", 14F);
            btnAdministrarBancoPreguntas.ForeColor = SystemColors.ButtonFace;
            btnAdministrarBancoPreguntas.Location = new Point(27, 12);
            btnAdministrarBancoPreguntas.Name = "btnAdministrarBancoPreguntas";
            btnAdministrarBancoPreguntas.Size = new Size(335, 45);
            btnAdministrarBancoPreguntas.TabIndex = 4;
            btnAdministrarBancoPreguntas.Text = "Administrar Banco de Preguntas";
            btnAdministrarBancoPreguntas.UseVisualStyleBackColor = false;
            btnAdministrarBancoPreguntas.Click += btnAdministrarBancoPreguntas_Click;
            // 
            // btnImprimirExamenes
            // 
            btnImprimirExamenes.BackColor = Color.White;
            btnImprimirExamenes.Cursor = Cursors.Hand;
            btnImprimirExamenes.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnImprimirExamenes.FlatStyle = FlatStyle.Flat;
            btnImprimirExamenes.Font = new Font("Segoe UI", 14F);
            btnImprimirExamenes.ForeColor = Color.Black;
            btnImprimirExamenes.Location = new Point(709, 12);
            btnImprimirExamenes.Name = "btnImprimirExamenes";
            btnImprimirExamenes.Size = new Size(335, 45);
            btnImprimirExamenes.TabIndex = 7;
            btnImprimirExamenes.Text = "Imprimir Examenes";
            btnImprimirExamenes.UseVisualStyleBackColor = false;
            // 
            // btnGenerarExamenes
            // 
            btnGenerarExamenes.BackColor = Color.White;
            btnGenerarExamenes.Cursor = Cursors.Hand;
            btnGenerarExamenes.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnGenerarExamenes.FlatStyle = FlatStyle.Flat;
            btnGenerarExamenes.Font = new Font("Segoe UI", 14F);
            btnGenerarExamenes.ForeColor = Color.Black;
            btnGenerarExamenes.Location = new Point(368, 12);
            btnGenerarExamenes.Name = "btnGenerarExamenes";
            btnGenerarExamenes.Size = new Size(335, 45);
            btnGenerarExamenes.TabIndex = 5;
            btnGenerarExamenes.Text = "Generar Examenes";
            btnGenerarExamenes.UseVisualStyleBackColor = false;
            btnGenerarExamenes.Click += btnGenerarExamenes_Click;
            // 
            // btnCorregirExamenes
            // 
            btnCorregirExamenes.BackColor = Color.White;
            btnCorregirExamenes.Cursor = Cursors.Hand;
            btnCorregirExamenes.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnCorregirExamenes.FlatStyle = FlatStyle.Flat;
            btnCorregirExamenes.Font = new Font("Segoe UI", 14F);
            btnCorregirExamenes.ForeColor = Color.Black;
            btnCorregirExamenes.Location = new Point(1050, 12);
            btnCorregirExamenes.Name = "btnCorregirExamenes";
            btnCorregirExamenes.Size = new Size(335, 45);
            btnCorregirExamenes.TabIndex = 6;
            btnCorregirExamenes.Text = "Corregir Examenes";
            btnCorregirExamenes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 741);
            Controls.Add(btnAdministrarBancoPreguntas);
            Controls.Add(btnImprimirExamenes);
            Controls.Add(btnGenerarExamenes);
            Controls.Add(btnCorregirExamenes);
            Name = "Form1";
            Text = "Sistema de Gestion de Examenes";
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAdministrarBancoPreguntas;
        private Button btnImprimirExamenes;
        private Button btnGenerarExamenes;
        private Button btnCorregirExamenes;
    }
}
