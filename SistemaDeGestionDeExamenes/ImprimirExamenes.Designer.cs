namespace SistemaDeGestionDeExamenes
{
    partial class ImprimirExamenes
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
            label1 = new Label();
            btnImprimirExamen = new Button();
            tvExamenes = new TreeView();
            btnEliminarExamen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(239, 53);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 1;
            label1.Text = "Examenes";
            // 
            // btnImprimirExamen
            // 
            btnImprimirExamen.Location = new Point(423, 650);
            btnImprimirExamen.Name = "btnImprimirExamen";
            btnImprimirExamen.Size = new Size(261, 37);
            btnImprimirExamen.TabIndex = 2;
            btnImprimirExamen.Text = "Imprimir Seleccionado";
            btnImprimirExamen.UseVisualStyleBackColor = true;
            btnImprimirExamen.Click += btnImprimirExamen_Click;
            // 
            // tvExamenes
            // 
            tvExamenes.Location = new Point(239, 86);
            tvExamenes.Name = "tvExamenes";
            tvExamenes.Size = new Size(893, 558);
            tvExamenes.TabIndex = 3;
            // 
            // btnEliminarExamen
            // 
            btnEliminarExamen.Location = new Point(690, 650);
            btnEliminarExamen.Name = "btnEliminarExamen";
            btnEliminarExamen.Size = new Size(261, 37);
            btnEliminarExamen.TabIndex = 4;
            btnEliminarExamen.Text = "Eliminar Seleccionado";
            btnEliminarExamen.UseVisualStyleBackColor = true;
            btnEliminarExamen.Click += btnEliminarExamen_Click;
            // 
            // ImprimirExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 741);
            Controls.Add(btnEliminarExamen);
            Controls.Add(tvExamenes);
            Controls.Add(btnImprimirExamen);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ImprimirExamenes";
            StartPosition = FormStartPosition.Manual;
            Text = "ImprimirExamenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnImprimirExamen;
        private TreeView tvExamenes;
        private Button btnEliminarExamen;
    }
}