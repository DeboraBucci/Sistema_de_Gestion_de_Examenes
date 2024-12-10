namespace SistemaDeGestionDeExamenes
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            menuAdministrarBancoPreguntas = new ToolStripMenuItem();
            menuExamenes = new ToolStripMenuItem();
            menuGenerarExamen = new ToolStripMenuItem();
            menuImprimirExamen = new ToolStripMenuItem();
            menuCorregirExamen = new ToolStripMenuItem();
            menuCorrecciones = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuAdministrarBancoPreguntas, menuExamenes, menuCorrecciones });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1409, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuAdministrarBancoPreguntas
            // 
            menuAdministrarBancoPreguntas.Name = "menuAdministrarBancoPreguntas";
            menuAdministrarBancoPreguntas.Size = new Size(189, 20);
            menuAdministrarBancoPreguntas.Text = "Administrar Banco de Preguntas";
            menuAdministrarBancoPreguntas.Click += menuAdministrarBancoPreguntas_Click;
            // 
            // menuExamenes
            // 
            menuExamenes.DropDownItems.AddRange(new ToolStripItem[] { menuGenerarExamen, menuImprimirExamen, menuCorregirExamen });
            menuExamenes.Name = "menuExamenes";
            menuExamenes.Size = new Size(72, 20);
            menuExamenes.Text = "Examenes";
            // 
            // menuGenerarExamen
            // 
            menuGenerarExamen.Name = "menuGenerarExamen";
            menuGenerarExamen.Size = new Size(165, 22);
            menuGenerarExamen.Text = "Generar Examen";
            menuGenerarExamen.Click += menuGenerarExamen_Click;
            // 
            // menuImprimirExamen
            // 
            menuImprimirExamen.Name = "menuImprimirExamen";
            menuImprimirExamen.Size = new Size(165, 22);
            menuImprimirExamen.Text = "Imprimir Examen";
            menuImprimirExamen.Click += menuImprimirExamen_Click;
            // 
            // menuCorregirExamen
            // 
            menuCorregirExamen.Name = "menuCorregirExamen";
            menuCorregirExamen.Size = new Size(165, 22);
            menuCorregirExamen.Text = "Corregir Examen";
            menuCorregirExamen.Click += menuCorregirExamen_Click;
            // 
            // menuCorrecciones
            // 
            menuCorrecciones.Name = "menuCorrecciones";
            menuCorrecciones.Size = new Size(88, 20);
            menuCorrecciones.Text = "Correcciones";
            menuCorrecciones.Click += menuCorrecciones_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 741);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.Manual;
            Text = "Sistema de Gestion de Examenes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuAdministrarBancoPreguntas;
        private ToolStripMenuItem menuExamenes;
        private ToolStripMenuItem menuGenerarExamen;
        private ToolStripMenuItem menuImprimirExamen;
        private ToolStripMenuItem menuCorregirExamen;
        private ToolStripMenuItem menuCorrecciones;
    }
}
