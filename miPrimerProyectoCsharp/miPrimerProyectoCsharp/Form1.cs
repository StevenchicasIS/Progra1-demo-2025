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
        private void Form1_Load(object sender, EventArgs e) {

        }
        string[][] etiquetas = new string[][]
        {
            
            new string[]{"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadra", "Metro cuadrado", "Tareas", "Manzanas", "Hectareas",} // Area

        };
        double[][] valores = new double[][] {
           
            new double[]{ 0.092903, 0.6988, 0.836127, 1, 437.5, 6998.96, 10000 }, // Área
        };  
        private double convertir(int tipo, int de, int a, double cantidad)
        {
            if (cantidad <= 0)
            {
                return 0;
            }
            return cantidad * valores[tipo][a] / valores[tipo][de]; 
        }
        private void BTNconvertir_Click(object sender, EventArgs e) {
            double cantidad = double.Parse(TXTcantidadconversor.Text);
            try
            {
                double cantida = double.Parse(TXTcantidadconversor.Text);
            }catch (Exception er)
            {
                LBLrespuestaconversor.Text = "Error "+ er.Message +" solo valores validos";
            }
                int tipo = CBOtipoconversor.SelectedIndex;
            int de = CBOdeconversor.SelectedIndex;
            int a = CBOaconversor.SelectedIndex;


            double respuesta= cantidad * valores[tipo][a] / valores[tipo][de];

            LBLrespuestaconversor.Text = "RESPUESTA ?: " + respuesta.ToString("N4");
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


