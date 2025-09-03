namespace miPrimerProyectoCsharp
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTserie = new System.Windows.Forms.TextBox();
            this.LBLmedia = new System.Windows.Forms.Label();
            this.LBLtipica = new System.Windows.Forms.Label();
            this.LBLarmonica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERIE :";
            // 
            // TXTserie
            // 
            this.TXTserie.Location = new System.Drawing.Point(118, 84);
            this.TXTserie.Name = "TXTserie";
            this.TXTserie.Size = new System.Drawing.Size(194, 22);
            this.TXTserie.TabIndex = 2;
            // 
            // LBLmedia
            // 
            this.LBLmedia.AutoSize = true;
            this.LBLmedia.Location = new System.Drawing.Point(47, 141);
            this.LBLmedia.Name = "LBLmedia";
            this.LBLmedia.Size = new System.Drawing.Size(55, 16);
            this.LBLmedia.TabIndex = 3;
            this.LBLmedia.Text = "MEDIA :";
            // 
            // LBLtipica
            // 
            this.LBLtipica.AutoSize = true;
            this.LBLtipica.Location = new System.Drawing.Point(47, 188);
            this.LBLtipica.Name = "LBLtipica";
            this.LBLtipica.Size = new System.Drawing.Size(55, 16);
            this.LBLtipica.TabIndex = 4;
            this.LBLtipica.Text = "TIPICA :";
            // 
            // LBLarmonica
            // 
            this.LBLarmonica.AutoSize = true;
            this.LBLarmonica.Location = new System.Drawing.Point(47, 236);
            this.LBLarmonica.Name = "LBLarmonica";
            this.LBLarmonica.Size = new System.Drawing.Size(84, 16);
            this.LBLarmonica.TabIndex = 5;
            this.LBLarmonica.Text = "ARMONICA :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 483);
            this.Controls.Add(this.LBLarmonica);
            this.Controls.Add(this.LBLtipica);
            this.Controls.Add(this.LBLmedia);
            this.Controls.Add(this.TXTserie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ESTADISTICA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTserie;
        private System.Windows.Forms.Label LBLmedia;
        private System.Windows.Forms.Label LBLtipica;
        private System.Windows.Forms.Label LBLarmonica;
    }
}

