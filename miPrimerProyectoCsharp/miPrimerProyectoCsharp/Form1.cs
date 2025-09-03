using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace miPrimerProyectoCsharp { 

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

        }
        //Matrices
        //Funciones
        //LINQ = Lenguaje de consulta integrado

        double media(string[] serie) {
            int n = serie.Length;
            double suma = 0;

            for (int i = 0; i < n; i++) {
                suma += int.Parse(serie[i]);
            }
            return suma / n;
        }
        double tipica(string[] serie, double m) {
            double tipica = 0;
            int n = serie.Length;

            for (int i = 0; i < n; i++) {
                int num = int.Parse(serie[i]);
                tipica += Math.Pow(num - m, 2);
            }
            tipica = Math.Sqrt(tipica / n);
            return tipica;

        }
        double armonica(string[] serie)
        {
            double a = 0;
           double n = serie.Length;
            for (int i =0; i < n; i++) {
                a += 1/double.Parse(serie[i]);  
            }
            return n / a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int[] serie = TXTserie.Text.Split(',').Select(n => int.Parse(n)).ToArray(); //5,8,1,9 => ["5","8","1","9"]
            string[] serie = TXTserie.Text.Split(',');

            double mediaAritmetica = media(serie);
            double deviacionTipica = tipica(serie, mediaAritmetica);
            double mediaArmonica = armonica(serie);

            LBLmedia.Text = "MEDIA : " + mediaAritmetica.ToString();
            LBLtipica.Text = "TIPICA : " + deviacionTipica.ToString();
            LBLarmonica.Text = "ARMONICA : " + mediaArmonica.ToString();
        }
    }
}


