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
            this.label1 = new System.Windows.Forms.Label();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OPTprimo = new System.Windows.Forms.RadioButton();
            this.OPTfactorizacion = new System.Windows.Forms.RadioButton();
            this.OPTporcentaje = new System.Windows.Forms.RadioButton();
            this.OPTexponente = new System.Windows.Forms.RadioButton();
            this.OPTdivicion = new System.Windows.Forms.RadioButton();
            this.OPTmultiplicacion = new System.Windows.Forms.RadioButton();
            this.OPTresta = new System.Windows.Forms.RadioButton();
            this.OPTsuma = new System.Windows.Forms.RadioButton();
            this.CBOopciones = new System.Windows.Forms.ComboBox();
            this.BTNcalcularOpciones = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 0;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(64, 118);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(54, 16);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Num1 :";
            // 
            // btncalcular
            // 
            this.btncalcular.ForeColor = System.Drawing.Color.Blue;
            this.btncalcular.Location = new System.Drawing.Point(150, 214);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(127, 61);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(125, 112);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(240, 22);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(125, 156);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(240, 22);
            this.txtnum2.TabIndex = 5;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum2.Location = new System.Drawing.Point(64, 162);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(58, 16);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Num 2 :";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.ForeColor = System.Drawing.Color.Red;
            this.lblrespuesta.Location = new System.Drawing.Point(173, 313);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(80, 16);
            this.lblrespuesta.TabIndex = 6;
            this.lblrespuesta.Text = "Respuesta?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OPTprimo);
            this.groupBox1.Controls.Add(this.OPTfactorizacion);
            this.groupBox1.Controls.Add(this.OPTporcentaje);
            this.groupBox1.Controls.Add(this.OPTexponente);
            this.groupBox1.Controls.Add(this.OPTdivicion);
            this.groupBox1.Controls.Add(this.OPTmultiplicacion);
            this.groupBox1.Controls.Add(this.OPTresta);
            this.groupBox1.Controls.Add(this.OPTsuma);
            this.groupBox1.Location = new System.Drawing.Point(384, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 372);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // OPTprimo
            // 
            this.OPTprimo.AutoSize = true;
            this.OPTprimo.Location = new System.Drawing.Point(14, 271);
            this.OPTprimo.Name = "OPTprimo";
            this.OPTprimo.Size = new System.Drawing.Size(63, 20);
            this.OPTprimo.TabIndex = 8;
            this.OPTprimo.TabStop = true;
            this.OPTprimo.Text = "Primo";
            this.OPTprimo.UseVisualStyleBackColor = true;
            // 
            // OPTfactorizacion
            // 
            this.OPTfactorizacion.AutoSize = true;
            this.OPTfactorizacion.Location = new System.Drawing.Point(14, 311);
            this.OPTfactorizacion.Name = "OPTfactorizacion";
            this.OPTfactorizacion.Size = new System.Drawing.Size(103, 20);
            this.OPTfactorizacion.TabIndex = 6;
            this.OPTfactorizacion.TabStop = true;
            this.OPTfactorizacion.Text = "factorizacion";
            this.OPTfactorizacion.UseVisualStyleBackColor = true;
            // 
            // OPTporcentaje
            // 
            this.OPTporcentaje.AutoSize = true;
            this.OPTporcentaje.Location = new System.Drawing.Point(14, 230);
            this.OPTporcentaje.Name = "OPTporcentaje";
            this.OPTporcentaje.Size = new System.Drawing.Size(93, 20);
            this.OPTporcentaje.TabIndex = 5;
            this.OPTporcentaje.TabStop = true;
            this.OPTporcentaje.Text = "Porcentaje";
            this.OPTporcentaje.UseVisualStyleBackColor = true;
            // 
            // OPTexponente
            // 
            this.OPTexponente.AutoSize = true;
            this.OPTexponente.Location = new System.Drawing.Point(14, 191);
            this.OPTexponente.Name = "OPTexponente";
            this.OPTexponente.Size = new System.Drawing.Size(92, 20);
            this.OPTexponente.TabIndex = 4;
            this.OPTexponente.TabStop = true;
            this.OPTexponente.Text = "Exponente";
            this.OPTexponente.UseVisualStyleBackColor = true;
            // 
            // OPTdivicion
            // 
            this.OPTdivicion.AutoSize = true;
            this.OPTdivicion.Location = new System.Drawing.Point(14, 154);
            this.OPTdivicion.Name = "OPTdivicion";
            this.OPTdivicion.Size = new System.Drawing.Size(76, 20);
            this.OPTdivicion.TabIndex = 3;
            this.OPTdivicion.TabStop = true;
            this.OPTdivicion.Text = "Divicion";
            this.OPTdivicion.UseVisualStyleBackColor = true;
            // 
            // OPTmultiplicacion
            // 
            this.OPTmultiplicacion.AutoSize = true;
            this.OPTmultiplicacion.Location = new System.Drawing.Point(14, 113);
            this.OPTmultiplicacion.Name = "OPTmultiplicacion";
            this.OPTmultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.OPTmultiplicacion.TabIndex = 2;
            this.OPTmultiplicacion.TabStop = true;
            this.OPTmultiplicacion.Text = "Multiplicacion";
            this.OPTmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // OPTresta
            // 
            this.OPTresta.AutoSize = true;
            this.OPTresta.Location = new System.Drawing.Point(14, 72);
            this.OPTresta.Name = "OPTresta";
            this.OPTresta.Size = new System.Drawing.Size(64, 20);
            this.OPTresta.TabIndex = 1;
            this.OPTresta.TabStop = true;
            this.OPTresta.Text = "Resta";
            this.OPTresta.UseVisualStyleBackColor = true;
            // 
            // OPTsuma
            // 
            this.OPTsuma.AutoSize = true;
            this.OPTsuma.Location = new System.Drawing.Point(14, 32);
            this.OPTsuma.Name = "OPTsuma";
            this.OPTsuma.Size = new System.Drawing.Size(63, 20);
            this.OPTsuma.TabIndex = 0;
            this.OPTsuma.TabStop = true;
            this.OPTsuma.Text = "Suma";
            this.OPTsuma.UseVisualStyleBackColor = true;
            // 
            // CBOopciones
            // 
            this.CBOopciones.FormattingEnabled = true;
            this.CBOopciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Divicion",
            "Exponente",
            "Porcentaje"});
            this.CBOopciones.Location = new System.Drawing.Point(669, 145);
            this.CBOopciones.Name = "CBOopciones";
            this.CBOopciones.Size = new System.Drawing.Size(176, 24);
            this.CBOopciones.TabIndex = 8;
            // 
            // BTNcalcularOpciones
            // 
            this.BTNcalcularOpciones.ForeColor = System.Drawing.Color.Blue;
            this.BTNcalcularOpciones.Location = new System.Drawing.Point(687, 214);
            this.BTNcalcularOpciones.Name = "BTNcalcularOpciones";
            this.BTNcalcularOpciones.Size = new System.Drawing.Size(127, 61);
            this.BTNcalcularOpciones.TabIndex = 9;
            this.BTNcalcularOpciones.Text = "Calcular";
            this.BTNcalcularOpciones.UseVisualStyleBackColor = true;
            this.BTNcalcularOpciones.Click += new System.EventHandler(this.BTNcalcularOpciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 483);
            this.Controls.Add(this.BTNcalcularOpciones);
            this.Controls.Add(this.CBOopciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OPTdivicion;
        private System.Windows.Forms.RadioButton OPTmultiplicacion;
        private System.Windows.Forms.RadioButton OPTresta;
        private System.Windows.Forms.RadioButton OPTsuma;
        private System.Windows.Forms.RadioButton OPTexponente;
        private System.Windows.Forms.RadioButton OPTporcentaje;
        private System.Windows.Forms.ComboBox CBOopciones;
        private System.Windows.Forms.Button BTNcalcularOpciones;
        private System.Windows.Forms.RadioButton OPTfactorizacion;
        private System.Windows.Forms.RadioButton OPTprimo;
    }
}

