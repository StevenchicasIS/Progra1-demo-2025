using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
         double num1, num2, resultado;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);
            resultado = num1 + num2;

            lblrespuesta.Text = "La respuesta es: " + resultado;
        }
    }
}
