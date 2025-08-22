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
            this.LBLtipoconversor = new System.Windows.Forms.Label();
            this.LBLdeconversor = new System.Windows.Forms.Label();
            this.LBLcantidadcoversor = new System.Windows.Forms.Label();
            this.CBOtipoconversor = new System.Windows.Forms.ComboBox();
            this.CBOdeconversor = new System.Windows.Forms.ComboBox();
            this.CBOaconversor = new System.Windows.Forms.ComboBox();
            this.LBLaconversor = new System.Windows.Forms.Label();
            this.TXTcantidadconversor = new System.Windows.Forms.ComboBox();
            this.LBLrespuestaconversor = new System.Windows.Forms.Label();
            this.BTNconvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLtipoconversor
            // 
            this.LBLtipoconversor.AutoSize = true;
            this.LBLtipoconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtipoconversor.Location = new System.Drawing.Point(82, 64);
            this.LBLtipoconversor.Name = "LBLtipoconversor";
            this.LBLtipoconversor.Size = new System.Drawing.Size(68, 22);
            this.LBLtipoconversor.TabIndex = 0;
            this.LBLtipoconversor.Text = "TIPO :";
            // 
            // LBLdeconversor
            // 
            this.LBLdeconversor.AutoSize = true;
            this.LBLdeconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLdeconversor.Location = new System.Drawing.Point(91, 121);
            this.LBLdeconversor.Name = "LBLdeconversor";
            this.LBLdeconversor.Size = new System.Drawing.Size(49, 22);
            this.LBLdeconversor.TabIndex = 1;
            this.LBLdeconversor.Text = "DE :";
            // 
            // LBLcantidadcoversor
            // 
            this.LBLcantidadcoversor.AutoSize = true;
            this.LBLcantidadcoversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLcantidadcoversor.Location = new System.Drawing.Point(28, 238);
            this.LBLcantidadcoversor.Name = "LBLcantidadcoversor";
            this.LBLcantidadcoversor.Size = new System.Drawing.Size(122, 22);
            this.LBLcantidadcoversor.TabIndex = 3;
            this.LBLcantidadcoversor.Text = "CANTIDAD :";
            // 
            // CBOtipoconversor
            // 
            this.CBOtipoconversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOtipoconversor.FormattingEnabled = true;
            this.CBOtipoconversor.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo"});
            this.CBOtipoconversor.Location = new System.Drawing.Point(156, 62);
            this.CBOtipoconversor.Name = "CBOtipoconversor";
            this.CBOtipoconversor.Size = new System.Drawing.Size(160, 24);
            this.CBOtipoconversor.TabIndex = 5;
            this.CBOtipoconversor.SelectedIndexChanged += new System.EventHandler(this.CBOtipoconversor_SelectedIndexChanged);
            // 
            // CBOdeconversor
            // 
            this.CBOdeconversor.FormattingEnabled = true;
            this.CBOdeconversor.Location = new System.Drawing.Point(156, 119);
            this.CBOdeconversor.Name = "CBOdeconversor";
            this.CBOdeconversor.Size = new System.Drawing.Size(160, 24);
            this.CBOdeconversor.TabIndex = 6;
            // 
            // CBOaconversor
            // 
            this.CBOaconversor.FormattingEnabled = true;
            this.CBOaconversor.Location = new System.Drawing.Point(156, 171);
            this.CBOaconversor.Name = "CBOaconversor";
            this.CBOaconversor.Size = new System.Drawing.Size(160, 24);
            this.CBOaconversor.TabIndex = 8;
            // 
            // LBLaconversor
            // 
            this.LBLaconversor.AutoSize = true;
            this.LBLaconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLaconversor.Location = new System.Drawing.Point(91, 173);
            this.LBLaconversor.Name = "LBLaconversor";
            this.LBLaconversor.Size = new System.Drawing.Size(35, 22);
            this.LBLaconversor.TabIndex = 7;
            this.LBLaconversor.Text = "A :";
            // 
            // TXTcantidadconversor
            // 
            this.TXTcantidadconversor.FormattingEnabled = true;
            this.TXTcantidadconversor.Location = new System.Drawing.Point(156, 236);
            this.TXTcantidadconversor.Name = "TXTcantidadconversor";
            this.TXTcantidadconversor.Size = new System.Drawing.Size(160, 24);
            this.TXTcantidadconversor.TabIndex = 9;
            // 
            // LBLrespuestaconversor
            // 
            this.LBLrespuestaconversor.AutoSize = true;
            this.LBLrespuestaconversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLrespuestaconversor.Location = new System.Drawing.Point(91, 326);
            this.LBLrespuestaconversor.Name = "LBLrespuestaconversor";
            this.LBLrespuestaconversor.Size = new System.Drawing.Size(146, 22);
            this.LBLrespuestaconversor.TabIndex = 10;
            this.LBLrespuestaconversor.Text = "RESPUESTA ?";
            // 
            // BTNconvertir
            // 
            this.BTNconvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNconvertir.ForeColor = System.Drawing.Color.Red;
            this.BTNconvertir.Location = new System.Drawing.Point(407, 148);
            this.BTNconvertir.Name = "BTNconvertir";
            this.BTNconvertir.Size = new System.Drawing.Size(185, 71);
            this.BTNconvertir.TabIndex = 11;
            this.BTNconvertir.Text = "CONVERTIR";
            this.BTNconvertir.UseVisualStyleBackColor = true;
            this.BTNconvertir.Click += new System.EventHandler(this.BTNconvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 483);
            this.Controls.Add(this.BTNconvertir);
            this.Controls.Add(this.LBLrespuestaconversor);
            this.Controls.Add(this.TXTcantidadconversor);
            this.Controls.Add(this.CBOaconversor);
            this.Controls.Add(this.LBLaconversor);
            this.Controls.Add(this.CBOdeconversor);
            this.Controls.Add(this.CBOtipoconversor);
            this.Controls.Add(this.LBLcantidadcoversor);
            this.Controls.Add(this.LBLdeconversor);
            this.Controls.Add(this.LBLtipoconversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLtipoconversor;
        private System.Windows.Forms.Label LBLdeconversor;
        private System.Windows.Forms.Label LBLcantidadcoversor;
        private System.Windows.Forms.ComboBox CBOtipoconversor;
        private System.Windows.Forms.ComboBox CBOdeconversor;
        private System.Windows.Forms.ComboBox CBOaconversor;
        private System.Windows.Forms.Label LBLaconversor;
        private System.Windows.Forms.ComboBox TXTcantidadconversor;
        private System.Windows.Forms.Label LBLrespuestaconversor;
        private System.Windows.Forms.Button BTNconvertir;
    }
}

