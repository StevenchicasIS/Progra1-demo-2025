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

        Conexion objconexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";


        private void ActualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet.
            objDs = objconexion.obtenerDatos();
            objDt = objDs.Tables["usuario"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["id_Usuario"] };

            grdUsuarios.DataSource = objDt.DefaultView;

            mostrarDatos();

        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idUsuario.Text = objDt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = objDt.Rows[posicion]["usuario"].ToString();
                txtClaveUsuario.Text = objDt.Rows[posicion]["clave"].ToString();
                txtNombreUsuario.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionUsuario.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoUsuario.Text = objDt.Rows[posicion]["telefono"].ToString();


                lblResgistroUsuarios.Text = (posicion + 1) + " de " + objDt.Rows.Count;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDs();
        }


        private void estadoControles(Boolean estado)
        {
            grbDatosusuarios.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btneliminarusuario.Enabled = !estado;


            grdUsuarios.Enabled = !estado;
        }

        private void limpiarControles()
        {
            idUsuario.Text = "";
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
        }

      

        private void txtbuscaraUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarUsuarios.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '" + valor + "%'";
                grdUsuarios.DataSource = objDv;
                seleccionarUsuario();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void seleccionarUsuario()
        {
            try
            {
                if (grdUsuarios.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdUsuarios.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
        
}



