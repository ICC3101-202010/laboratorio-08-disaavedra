namespace Lab8
{
    partial class Agregar
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
            this.Alabel1 = new System.Windows.Forms.Label();
            this.Avolver = new System.Windows.Forms.Button();
            this.Aeleccion1 = new System.Windows.Forms.Button();
            this.Aeleccion2 = new System.Windows.Forms.Button();
            this.Aeleccion4 = new System.Windows.Forms.Button();
            this.Aeleccion3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alabel1
            // 
            this.Alabel1.AutoSize = true;
            this.Alabel1.Location = new System.Drawing.Point(12, 9);
            this.Alabel1.Name = "Alabel1";
            this.Alabel1.Size = new System.Drawing.Size(90, 13);
            this.Alabel1.TabIndex = 0;
            this.Alabel1.Text = "Agregar Locales :";
            // 
            // Avolver
            // 
            this.Avolver.Location = new System.Drawing.Point(702, 12);
            this.Avolver.Name = "Avolver";
            this.Avolver.Size = new System.Drawing.Size(86, 42);
            this.Avolver.TabIndex = 1;
            this.Avolver.Text = "VOLVER";
            this.Avolver.UseVisualStyleBackColor = true;
            this.Avolver.Click += new System.EventHandler(this.Avolver_Click);
            // 
            // Aeleccion1
            // 
            this.Aeleccion1.Location = new System.Drawing.Point(246, 86);
            this.Aeleccion1.Name = "Aeleccion1";
            this.Aeleccion1.Size = new System.Drawing.Size(140, 140);
            this.Aeleccion1.TabIndex = 2;
            this.Aeleccion1.Text = "Tienda";
            this.Aeleccion1.UseVisualStyleBackColor = true;
            this.Aeleccion1.Click += new System.EventHandler(this.Aeleccion1_Click);
            // 
            // Aeleccion2
            // 
            this.Aeleccion2.Location = new System.Drawing.Point(392, 86);
            this.Aeleccion2.Name = "Aeleccion2";
            this.Aeleccion2.Size = new System.Drawing.Size(140, 140);
            this.Aeleccion2.TabIndex = 3;
            this.Aeleccion2.Text = "Restaurante";
            this.Aeleccion2.UseVisualStyleBackColor = true;
            this.Aeleccion2.Click += new System.EventHandler(this.Aeleccion2_Click);
            // 
            // Aeleccion4
            // 
            this.Aeleccion4.Location = new System.Drawing.Point(392, 232);
            this.Aeleccion4.Name = "Aeleccion4";
            this.Aeleccion4.Size = new System.Drawing.Size(140, 140);
            this.Aeleccion4.TabIndex = 4;
            this.Aeleccion4.Text = "Recreacion";
            this.Aeleccion4.UseVisualStyleBackColor = true;
            this.Aeleccion4.Click += new System.EventHandler(this.Aeleccion4_Click);
            // 
            // Aeleccion3
            // 
            this.Aeleccion3.Location = new System.Drawing.Point(246, 232);
            this.Aeleccion3.Name = "Aeleccion3";
            this.Aeleccion3.Size = new System.Drawing.Size(140, 140);
            this.Aeleccion3.TabIndex = 5;
            this.Aeleccion3.Text = "Cine";
            this.Aeleccion3.UseVisualStyleBackColor = true;
            this.Aeleccion3.Click += new System.EventHandler(this.Aeleccion3_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aeleccion3);
            this.Controls.Add(this.Aeleccion4);
            this.Controls.Add(this.Aeleccion2);
            this.Controls.Add(this.Aeleccion1);
            this.Controls.Add(this.Avolver);
            this.Controls.Add(this.Alabel1);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Alabel1;
        private System.Windows.Forms.Button Avolver;
        private System.Windows.Forms.Button Aeleccion1;
        private System.Windows.Forms.Button Aeleccion2;
        private System.Windows.Forms.Button Aeleccion4;
        private System.Windows.Forms.Button Aeleccion3;
    }
}