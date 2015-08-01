using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Control
{
    public class Conexion
    {
        public static SqlConnection getConexion()
        {
            //Utilizando el archivo app config
            //Asegurarse de agregar la referencia System.Configuration al proyecto y a la clase
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings[@"cadenaConn"].ConnectionString;
            conn.Open();
            return conn;
        }


        //Metodo generico para agregar
        public static int inserta(String cadAgrega)
        {
            String ssql = "";
            int retorno = 0;
            using (SqlConnection conn = getConexion())
            {
                SqlCommand insertar;
                insertar = new SqlCommand();
                ssql = cadAgrega;
                SqlDataAdapter adaptador;
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = insertar;
                insertar.Connection = conn;
                insertar.CommandText = ssql;
                retorno = insertar.ExecuteNonQuery();
                insertar.Dispose();
                conn.Close();
            }
            return retorno;
        }

        public static int modifica(String cadModifica)
        {

            int retorno = 0;
            using (SqlConnection conn = Conexion.getConexion())
            {
                SqlCommand actualizar;
                actualizar = new SqlCommand();
                SqlDataAdapter adaptador;
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = actualizar;
                actualizar.Connection = conn;
                actualizar.CommandText = cadModifica;
                retorno = actualizar.ExecuteNonQuery();
                actualizar.Dispose();
                conn.Close();
            }
            return retorno;
        }
        public static int elimina(String cadEliminar)
        {
            int retorno = 0;
            using (SqlConnection conn = Conexion.getConexion())
            {
                SqlCommand eliminar;
                eliminar = new SqlCommand();
                SqlDataAdapter adaptador;
                adaptador = new SqlDataAdapter();
                adaptador.DeleteCommand = eliminar;
                eliminar.Connection = conn;
                eliminar.CommandText = cadEliminar;
                retorno = eliminar.ExecuteNonQuery();
                eliminar.Dispose();
                conn.Close();
            }
            return retorno;
        }
        public static SqlDataReader consulta(String cadConsulta)
        {
            SqlDataReader resultadoConsulta = null;
            SqlConnection conn = Conexion.getConexion();

            SqlCommand consulta = new SqlCommand(cadConsulta, conn);
            resultadoConsulta = consulta.ExecuteReader();

            return resultadoConsulta;
        }
    }
}
