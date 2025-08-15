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
        private int acum;

        public int Factorizacion { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);

            if (OPTsuma.Checked)
            {
                resultado = num1 + num2;
            }
            else if (OPTresta.Checked)
            {
                resultado = num1 - num2;
            }
            else if (OPTmultiplicacion.Checked)
            {
                resultado = num1 * num2;
            }
            else if (OPTdivicion.Checked)
            {
                resultado = num1 / num2;
            }
            if (OPTexponente.Checked) {
                resultado = Math.Pow(num1, num2);
            } 
            if (OPTfactorizacion.Checked) {
                resultado = (int)num1;
                for (int i =(int)num1 - 1; i > 1; i--)  { //5!=5x4x3x2=120
                    resultado *= i;  
                } 

            }
            lblrespuesta.Text = " respuesta: " + resultado; 

            if (OPTporcentaje.Checked)
            {
                resultado = (num1 * num2) / 100;
            }
            if (OPTprimo.Checked)
            {
                int i = 1;
                while (i<= num1 && acum<3)  {
                    if(num1 % i == 0) {
                        acum++; //acum = acum + 1;
                    }
          
                }
                if (acum <=2)
                {
                    lblrespuesta.Text = "El numero " + num1 + " es primo";  
                } else {
                    lblrespuesta.Text = "El numero " + num1 + " No es primo";
                }
 
            }

        }
            //Factorial. 5! = 5x4x3x2x1= 120. 

          
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNcalcularOpciones_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);

            switch (CBOopciones.SelectedIndex) {
                case 0:
                    resultado = num1 + num2;
                    break;
                case 1:
                    resultado = num1 - num2;
                    break;
                case 2:
                    resultado = num1 * num2;
                    break;
                case 3:
                    resultado = num1 / num2;
                    break; 
                 case 4:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5:
                    resultado = (num1 * num2) / 100;
                    break; 
            }
            lblrespuesta.Text = " respuesta: " + resultado;
        }
    }
}
