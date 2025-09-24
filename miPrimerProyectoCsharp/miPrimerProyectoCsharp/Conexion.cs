using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Esta es la libreria que me permite usar comando para trabajar con base de datos
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Windows.Forms; // Esta es la libreria que me permite trabajar con sql server 

namespace miPrimerProyectoCsharp
{
    internal class Conexion
    {
        //Definir los mienbros de la clase, atributos y metodos. 
        SqlConnection objConexion = new SqlConnection(); //conectarme a la BD.
        SqlCommand objComando = new SqlCommand(); // ejecutar SQL em la BD. lectura, Actualizacion, eliminacion, insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion
        DataSet objds = new DataSet(); //es una representacion de la arquitectura de la BD en memoria.

        public Conexion() //Constructor. Inicializador de los atributos.
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica6.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // abrir la conexion a la BD.
        }
        public DataSet obtenerDatos()
        {
            objds.Clear(); //limpiar el dataset
            objComando.Connection = objConexion; //Establecerla conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //establecer el comando de seleccion.

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objds, "alumnos");//Tomando los datos de la BD y llenando el dataset.

            return objds;


        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo") {
                sql = "INSERT INTO alumnos(codigo,nombre, direccion, telefono) VALUES (@codigo, @nombre, @direccion, @telefono)";
            } else if (accion == "modificar") {
                sql = "UPDATE alumnos SET codigo=@codigo, nombre=@nombre, direccion=@direccion, telefono=@telefono WHERE idAlumno=@idAlumno";
            } else if (accion == "eliminar") {
                sql = "DELETE FROM alumnos WHERE idAlumno=@idAlumno";
            }
            return ejecutarSQL(sql, datos);
        }
        private String ejecutarSQL(String sql, String[] datos)  {
            try {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idAlumno",datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();    
            } catch (Exception ex) {
                return ex.Message;


            }
        }

    }
}