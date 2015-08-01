using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 AUTOR: ANTONIO QUINTANAR VIVEROS
 * FECHA : 03/07/2014 MODIFICADO: 07/07/2014
 * AUTOR DE COMENTARIO: ANTONIO QUINTANAR VIVEROS
 */
namespace Escuela.Control
{
    public class CIdindicador
    {
        /*
        * En este metodo se manda a llamar lo que hara el boton guardar y a su ves este insertara los datos en la tabla mostrandolos tambien retornara el valor insertado
         * desde los datos de inserccion
         */
        public int guardar(MIdindicador pIndicador)
        {
            String cadena = String.Format("INSERT INTO INDICADOR VALUES ('{0}','{1}')", pIndicador.Idindicador, pIndicador.Nombre);
            if (this.existe(pIndicador))
                return 0;
            else
                return Conexion.inserta(cadena);
        }
        /*
         * En este metodo se crea la exixtencia de los datos para verificar que estos son reales y no falsos y estos se mostraron enla tabla retornando el mismo
         * valor que se han insertado
         */
        private bool existe(MIdindicador pIndicador)
       {
           String cadena = String.Format("SELECT * FROM INDICADOR WHERE IN_IDINDICADOR = '{0}'", pIndicador.Idindicador);
           SqlDataReader leer = Conexion.consulta(cadena);
           bool resp = leer.HasRows;
           leer.Close();
           return resp;
           }
        /* En este metodo empesaremos a mostrar todos los resultas que hemos insertado es como una consulta en la cual podemos ver nuestros datos
         * ya que esta programada para mostrar los resultados de la tabla en la cual podremos ver nuestros datos insertados o modificados
         */
        public List<MIdindicador> consultaTodo()
        {
            List<MIdindicador> lista = new List<MIdindicador>();
            String cadena = "SELECT * FROM INDICADOR";
            SqlDataReader leer = Conexion.consulta(cadena);
            while (leer.Read())
            {
                MIdindicador nuevo = new MIdindicador();
                nuevo.Idindicador = leer.GetDecimal(0);
                nuevo.Nombre = leer.GetString(1);
                lista.Add(nuevo);
            }
            return lista;
        }
        /* En este metodo se declara las acciones en el boton modificar el cual devera seguir las instrucciones para modificar los datos y estos a su vez se mostraran
         * el la dgv de nuestro frm
         */
        public int modificar(MIdindicador pIndicador)
        {
            String cadena = String.Format("UPDATE INDICADOR SET IN_IDINDICADOR = '{0}', IN_NOMBRE = '{1}' where IN_IDINDICADOR = '{0}' ", pIndicador.Idindicador, pIndicador.Nombre);
            return Conexion.modifica(cadena);
        }
        /*En este metodo eliminaremos los datos insertados en nuestra tabla lo cual este metodo hace que se borren todos los datos y retorne el mismo valor pero si el dato 
         * eliminado tambien si este es 0 no se borrara nada todo quedara igual como estaba
         */
        public int eliminar (MIdindicador pIndicador){
            String cadena = String.Format("DELETE FROM INDICADOR WHERE in_IdIndicador={0}", pIndicador.Idindicador);
            if (this.existe(pIndicador))
            {
                return Conexion.elimina(cadena);
            }
            else
            {
                return 0;
            }
        }
    }
}
    

