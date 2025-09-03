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
            this.label1 = new System.Windows.Forms.Label();
            this.LBLresultado = new System.Windows.Forms.Label();
            this.TXTmonto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNcalcular
            // 
            this.BTNcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcalcular.Location = new System.Drawing.Point(170, 203);
            this.BTNcalcular.Name = "BTNcalcular";
            this.BTNcalcular.Size = new System.Drawing.Size(155, 63);
            this.BTNcalcular.TabIndex = 0;
            this.BTNcalcular.Text = "CALCULAR";
            this.BTNcalcular.UseVisualStyleBackColor = true;
            this.BTNcalcular.Click += new System.EventHandler(this.BTNcalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese monto de actividad economica";
            // 
            // LBLresultado
            // 
            this.LBLresultado.AutoSize = true;
            this.LBLresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLresultado.Location = new System.Drawing.Point(47, 328);
            this.LBLresultado.Name = "LBLresultado";
            this.LBLresultado.Size = new System.Drawing.Size(131, 29);
            this.LBLresultado.TabIndex = 2;
            this.LBLresultado.Text = "Resultado";
            // 
            // TXTmonto
            // 
            this.TXTmonto.Location = new System.Drawing.Point(135, 121);
            this.TXTmonto.Name = "TXTmonto";
            this.TXTmonto.Size = new System.Drawing.Size(200, 22);
            this.TXTmonto.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 483);
            this.Controls.Add(this.TXTmonto);
            this.Controls.Add(this.LBLresultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNcalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLresultado;
        private System.Windows.Forms.TextBox TXTmonto;
    }
}

