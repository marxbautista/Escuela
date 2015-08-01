using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Autor: Hilda Mireya Calva Chavarria
Mónica Yesenia Viveros Bautista
Juan Manuel Dorantes Peréz
 * Autor Documentación: Juan Manuel Dorantes Peréz
Fecha: 07/07/2014
 */
namespace Escuela.Control
{
     public class CTipoReporte
    {
        /*Este método de Guardar nos permite insertar los datos que solicitamos para la tabla tipo reporte
         */
        public int guardar(MTipoReporte pTReporte)
        {
            String cadena = String.Format("Insert into TipoReporte values('{0}','{1}','{2}')",
                pTReporte.Nombre, pTReporte.FechaInicio.ToShortDateString(), pTReporte.FechaFin.ToShortDateString());
            
            if (this.existe(pTReporte))
                return 0;
            else
                return Conexion.inserta(cadena);
        }

        /*El método de existe valida los datos que insertamos para saber si alguno de ellos ya esta en la base de datos, de ser esto falso nos dejará insertar
         */
        public bool existe(MTipoReporte pTReporte)
        {
            string cadena = string.Format("select * from tiporeporte where ti_idTipo = '{0}'", pTReporte.IdTipo);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;
        }
        /*El método de List nos ayuda hacer una cadena con la consulta de los datos que tenemos en la base de datos donde nos agrega la nueva lista y así poder consultarlos en el formulario
         */
        public List<MTipoReporte> consultaTodo2()
        {
            List<MTipoReporte> lista2 = new List<MTipoReporte>();
            String cadena = "select * from TipoReporte";
            SqlDataReader leer = Conexion.consulta(cadena);
            while (leer.Read())
            {
                MTipoReporte nuevo = new MTipoReporte();
                nuevo.IdTipo = leer.GetInt32(0);
                nuevo.Nombre = leer.GetString(1);
                nuevo.FechaInicio = leer.GetDateTime(2);
                nuevo.FechaFin = leer.GetDateTime(3);
                lista2.Add(nuevo);
            }
            return lista2;
        }
        /*El método de modificar nos permite hacer modifiacciones sonbre los datos ya existentes de la tabla tipo reporte en la base de datos 
         */
        public int modificar(MTipoReporte pTReporte)
        {
            String cadena = String.Format
                ("update tiporeporte set ti_nombre= '{0}',ti_FechaInicio = '{1}', ti_FechaTermino = '{2}' where ti_idTipo = '{3}'",
                pTReporte.Nombre, pTReporte.FechaInicio,pTReporte.FechaFin, pTReporte.IdTipo);

            return Conexion.modifica(cadena);
        }
        /*En el método de eliminar nos hace la eliminación de datos existentes en la tabla de nuestra base de datos
         */
        public int eliminar(MTipoReporte pTReporte)
        {
            string cadena = String.Format("DELETE FROM TIPOREPORTE WHERE TI_IDTIPO={0}", pTReporte.IdTipo);
            if(this.existe(pTReporte)){
                return Conexion.elimina(cadena);
            }
            else{
                return 0;
            }
        }
    }
}
