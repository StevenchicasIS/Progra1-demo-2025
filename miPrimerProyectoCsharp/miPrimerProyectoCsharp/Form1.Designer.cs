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
            this.BTNcalcular = new System.Windows.Forms.Button();
            this.LBLsueldo = new System.Windows.Forms.Label();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.LBLisss = new System.Windows.Forms.Label();
            this.LBLafp = new System.Windows.Forms.Label();
            this.LBLisr = new System.Windows.Forms.Label();
            this.LBLsueldoneto = new System.Windows.Forms.Label();
            this.LBLtotalDeducciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcalcular.Location = new System.Drawing.Point(423, 103);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(159, 80);
            this.BTNcalcular.TabIndex = 0;
            this.BTNcalcular.Text = "Calcular";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // LBLsueldo
            // 
            this.LBLsueldo.AutoSize = true;
            this.LBLsueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsueldo.Location = new System.Drawing.Point(84, 96);
            this.LBLsueldo.Name = "LBLsueldo";
            this.LBLsueldo.Size = new System.Drawing.Size(96, 29);
            this.LBLsueldo.TabIndex = 1;
            this.LBLsueldo.Text = "Sueldo";
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(206, 103);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(134, 22);
            this.txtsueldo.TabIndex = 2;
            // 
            // LBLisss
            // 
            this.LBLisss.AutoSize = true;
            this.LBLisss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLisss.Location = new System.Drawing.Point(84, 153);
            this.LBLisss.Name = "LBLisss";
            this.LBLisss.Size = new System.Drawing.Size(105, 29);
            this.LBLisss.TabIndex = 3;
            this.LBLisss.Text = "ISSS : ?";
            // 
            // LBLafp
            // 
            this.LBLafp.AutoSize = true;
            this.LBLafp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLafp.Location = new System.Drawing.Point(84, 202);
            this.LBLafp.Name = "LBLafp";
            this.LBLafp.Size = new System.Drawing.Size(96, 29);
            this.LBLafp.TabIndex = 4;
            this.LBLafp.Text = "AFP : ?";
            // 
            // LBLisr
            // 
            this.LBLisr.AutoSize = true;
            this.LBLisr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLisr.Location = new System.Drawing.Point(84, 246);
            this.LBLisr.Name = "LBLisr";
            this.LBLisr.Size = new System.Drawing.Size(89, 29);
            this.LBLisr.TabIndex = 5;
            this.LBLisr.Text = "ISR : ?";
            // 
            // LBLsueldoneto
            // 
            this.LBLsueldoneto.AutoSize = true;
            this.LBLsueldoneto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsueldoneto.Location = new System.Drawing.Point(84, 347);
            this.LBLsueldoneto.Name = "LBLsueldoneto";
            this.LBLsueldoneto.Size = new System.Drawing.Size(193, 29);
            this.LBLsueldoneto.TabIndex = 6;
            this.LBLsueldoneto.Text = "Sueldo Neto : ?";
            // 
            // LBLtotalDeducciones
            // 
            this.LBLtotalDeducciones.AutoSize = true;
            this.LBLtotalDeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtotalDeducciones.Location = new System.Drawing.Point(84, 298);
            this.LBLtotalDeducciones.Name = "LBLtotalDeducciones";
            this.LBLtotalDeducciones.Size = new System.Drawing.Size(259, 29);
            this.LBLtotalDeducciones.TabIndex = 7;
            this.LBLtotalDeducciones.Text = "TotalDeducciones : ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 483);
            this.Controls.Add(this.LBLtotalDeducciones);
            this.Controls.Add(this.LBLsueldoneto);
            this.Controls.Add(this.LBLisr);
            this.Controls.Add(this.LBLafp);
            this.Controls.Add(this.LBLisss);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.LBLsueldo);
            this.Controls.Add(this.BTNcalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcalcular;
        private System.Windows.Forms.Label LBLsueldo;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label LBLisss;
        private System.Windows.Forms.Label LBLafp;
        private System.Windows.Forms.Label LBLisr;
        private System.Windows.Forms.Label LBLsueldoneto;
        private System.Windows.Forms.Label LBLtotalDeducciones;
    }
}

