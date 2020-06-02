namespace Lab8
{
    partial class Revisar
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
            this.Rlabel1 = new System.Windows.Forms.Label();
            this.Rvolver = new System.Windows.Forms.Button();
            this.Releccion3 = new System.Windows.Forms.Button();
            this.Releccion4 = new System.Windows.Forms.Button();
            this.Releccion2 = new System.Windows.Forms.Button();
            this.Releccion1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rlabel1
            // 
            this.Rlabel1.AutoSize = true;
            this.Rlabel1.Location = new System.Drawing.Point(12, 9);
            this.Rlabel1.Name = "Rlabel1";
            this.Rlabel1.Size = new System.Drawing.Size(89, 13);
            this.Rlabel1.TabIndex = 0;
            this.Rlabel1.Text = "Revisar Locales :";
            // 
            // Rvolver
            // 
            this.Rvolver.Location = new System.Drawing.Point(702, 12);
            this.Rvolver.Name = "Rvolver";
            this.Rvolver.Size = new System.Drawing.Size(86, 42);
            this.Rvolver.TabIndex = 2;
            this.Rvolver.Text = "VOLVER";
            this.Rvolver.UseVisualStyleBackColor = true;
            this.Rvolver.Click += new System.EventHandler(this.Rvolver_Click);
            // 
            // Releccion3
            // 
            this.Releccion3.Location = new System.Drawing.Point(257, 228);
            this.Releccion3.Name = "Releccion3";
            this.Releccion3.Size = new System.Drawing.Size(140, 140);
            this.Releccion3.TabIndex = 9;
            this.Releccion3.Text = "Cine";
            this.Releccion3.UseVisualStyleBackColor = true;
            // 
            // Releccion4
            // 
            this.Releccion4.Location = new System.Drawing.Point(403, 228);
            this.Releccion4.Name = "Releccion4";
            this.Releccion4.Size = new System.Drawing.Size(140, 140);
            this.Releccion4.TabIndex = 8;
            this.Releccion4.Text = "Recreacion";
            this.Releccion4.UseVisualStyleBackColor = true;
            this.Releccion4.Click += new System.EventHandler(this.Releccion4_Click);
            // 
            // Releccion2
            // 
            this.Releccion2.Location = new System.Drawing.Point(403, 82);
            this.Releccion2.Name = "Releccion2";
            this.Releccion2.Size = new System.Drawing.Size(140, 140);
            this.Releccion2.TabIndex = 7;
            this.Releccion2.Text = "Restaurante";
            this.Releccion2.UseVisualStyleBackColor = true;
            // 
            // Releccion1
            // 
            this.Releccion1.Location = new System.Drawing.Point(257, 82);
            this.Releccion1.Name = "Releccion1";
            this.Releccion1.Size = new System.Drawing.Size(140, 140);
            this.Releccion1.TabIndex = 6;
            this.Releccion1.Text = "Tienda";
            this.Releccion1.UseVisualStyleBackColor = true;
            this.Releccion1.Click += new System.EventHandler(this.Releccion1_Click);
            // 
            // Revisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Releccion3);
            this.Controls.Add(this.Releccion4);
            this.Controls.Add(this.Releccion2);
            this.Controls.Add(this.Releccion1);
            this.Controls.Add(this.Rvolver);
            this.Controls.Add(this.Rlabel1);
            this.Name = "Revisar";
            this.Text = "Revisar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rlabel1;
        private System.Windows.Forms.Button Rvolver;
        private System.Windows.Forms.Button Releccion3;
        private System.Windows.Forms.Button Releccion4;
        private System.Windows.Forms.Button Releccion2;
        private System.Windows.Forms.Button Releccion1;
    }
}