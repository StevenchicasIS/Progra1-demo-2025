using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Esta es la libreria que me permite usar comando para trabajar con base de datos
using System.Data.SqlClient; // Esta es la libreria que me permite trabajar con sql server 

namespace miPrimerProyectoCsharp {
    internal class Conexion  {
        //Definir los mienbros de la clase, atributos y metodos. 
        SqlConnection objConexion = new SqlConnection(); //conectarme a la BD.
        SqlCommand objComando = new SqlCommand(); // ejecutar SQL em la BD. lectura, Actualizacion, eliminacion, insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion
        DataSet objds = new DataSet(); //es una representacion de la arquitectura de la BD en memoria.

        public Conexion() //Constructor. Inicializador de los atributos.
        {
            string cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); // abrir la conexion a la BD.
        }
        public DataSet obtenerDatos() {
            objds.Clear(); //limpiar el dataset
            objComando.Connection = objConexion; //Establecerla conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //establecer el comando de seleccion.

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objds, "alumnos");//Tomando los datos de la BD y llenando el dataset.

            return objds;
        
           
        }
    }
}
