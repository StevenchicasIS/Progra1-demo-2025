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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizards()
        {
            objDs.Clear(); //Limpiar el dataset
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["alumnos"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idAlumno"] };


            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idAlumno.Text = objDt.Rows[posicion]["idAlumno"].ToString();
                TXTCodigoAlumno.Text = objDt.Rows[posicion]["codigo"].ToString();
                TXTnombrealumno.Text = objDt.Rows[posicion]["nombre"].ToString();
                TXTdireccionalumno.Text = objDt.Rows[posicion]["direccion"].ToString();
                TXTtelefonoalumno.Text = objDt.Rows[posicion]["telefono"].ToString();

                LBLnResgistroAlumnos.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actualizards();
        }

        private void btnsiguientealumno_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion = posicion + 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnanterioralumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion = posicion - 1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnultimoalumno_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }
        private void btnPrimeroalumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosalumnos.Enabled = estado;
            grbNavegacionAlumonos.Enabled = !estado;
            BTNeliminaralumno.Enabled = !estado;
        }
        private void limpiarcontroles()
        {
            idAlumno.Text = "";
            TXTCodigoAlumno.Text = "";
            TXTnombrealumno.Text = "";
            TXTdireccionalumno.Text = "";
            TXTtelefonoalumno.Text = "";
        }
        private void BTNnuevoalumno_Click(object sender, EventArgs e)
        {
            if (BTNagregarAlumno.Text == "NUEVO")
            {
                BTNagregarAlumno.Text = "Guardar";
                BTNmodificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "Nuevo";
                limpiarcontroles();
            }
            else
            { //Guardar
                String[] alumnos = {
                    idAlumno.Text, TXTCodigoAlumno.Text, TXTnombrealumno.Text, TXTdireccionalumno.Text,TXTtelefonoalumno.Text
                 };
                String respuesta = objConexion.administrarDatosAlumnos(alumnos, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    BTNagregarAlumno.Text = "NUEVO";
                    BTNmodificarAlumno.Text = "MODIFICAR";
                    actualizards();
                }
            }
        }

        private void BTNmodificaralumno_Click(object sender, EventArgs e)
        {
            if (BTNmodificarAlumno.Text == "MODIFICAR")
            {
                BTNagregarAlumno.Text = "Guardar";
                BTNmodificarAlumno.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            { //Cancelar
                mostrarDatos();
                estadoControles(false);
                BTNagregarAlumno.Text = "NUEVO";
                BTNmodificarAlumno.Text = "MODIFICAR";

            }
        }

        private void BTNeliminaralumno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar a" + TXTnombrealumno.Text,
                    "Eliminar alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] { idAlumno.Text, "", "", "", "" }, "eliminar"
                    );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizards();

                }

            }
        }
    }
}
    

