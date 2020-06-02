namespace Lab8
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Revisar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.ATvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Revisar
            // 
            this.Revisar.Location = new System.Drawing.Point(237, 60);
            this.Revisar.Name = "Revisar";
            this.Revisar.Size = new System.Drawing.Size(298, 141);
            this.Revisar.TabIndex = 0;
            this.Revisar.Text = "Revisar informacion ";
            this.Revisar.UseVisualStyleBackColor = true;
            this.Revisar.Click += new System.EventHandler(this.Revisar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(237, 207);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(298, 141);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar informacion";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // ATvolver
            // 
            this.ATvolver.Location = new System.Drawing.Point(702, 12);
            this.ATvolver.Name = "ATvolver";
            this.ATvolver.Size = new System.Drawing.Size(86, 42);
            this.ATvolver.TabIndex = 12;
            this.ATvolver.Text = "SALIR";
            this.ATvolver.UseVisualStyleBackColor = true;
            this.ATvolver.Click += new System.EventHandler(this.ATvolver_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ATvolver);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Revisar);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Revisar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button ATvolver;
    }
}

