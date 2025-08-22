using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp { 

    public partial class Form1 : Form { 
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

        }
        string[][] etiquetas = new string[][]
        {
            new string[]{"Dolar", "pesos Mexicanos", "Quetzat", "Lempira", "Colon SV", "Cordoba", "CR"}, // Monedas 
            new string[]{"Metros", "CM", "Pulgadas", "Pie", "Varas", "Yardas", "KM", "Millas"}, // Longitudes
            new string[]{"LIbras", "Onzas", "Gramos", "Kilogramos", "Quintal", "Tonelada corta"}, // Masa
            new string[]{"Galon", "Litros", "Pintas US", "Mililitrios", }, // Volumen
            new string[]{"GB", "Bit", "Byte", "KB", "MG", "TB",}, // Almacenamiento
            new string[]{"Dia", "Segundos", "Minutos", "Horas", "Semana", "Meses", "Año"} // Tiempo

        };
        double[][] valores = new double[][] {
            new double[]{1, 18.78, 7.66, 26.15, 8.75, 36.78, 504.12, }, // Monedas
            new double[]{1, 100, 39.37, 3.28084, 1.193, 1.09361, 0.001, 0.000621371}, // Longitudes
            new double[]{1, 16, 453.592, 0.453592, 0.01, 0.001, 0.0005}, // Masa  
            new double[]{1, 3.78541, 8, 3785.41}, // Volumen
            new double[]{1, 8e+9, 1e+9, 1e+6, 1000, 0.001}, // Almacenamiento
            new double[]{1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273973}, // Tiempo
        };
        private void BTNconvertir_Click(object sender, EventArgs e) {
            double cantidad = double.Parse(TXTcantidadconversor.Text);

            int tipo = CBOtipoconversor.SelectedIndex;
            int de = CBOdeconversor.SelectedIndex;
            int a = CBOaconversor.SelectedIndex;

            double respuesta= cantidad * valores[tipo][a] / valores[tipo][de];

            LBLrespuestaconversor.Text = "RESPUESTA ?: " + respuesta.ToString("N2");
        }

        private void CBOtipoconversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOdeconversor.Items.Clear();
            CBOaconversor.Items.Clear();

            CBOdeconversor.Items.AddRange(etiquetas[CBOtipoconversor.SelectedIndex]);
            CBOaconversor.Items.AddRange(etiquetas[CBOtipoconversor.SelectedIndex]);
        }
    }
}


