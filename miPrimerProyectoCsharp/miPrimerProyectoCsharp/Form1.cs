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
        Conexion objConexion = new Conexion(); 
        DataSet objds = new DataSet();
        DataTable DataTable = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


