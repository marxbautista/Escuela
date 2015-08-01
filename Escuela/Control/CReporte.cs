using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Autores: Leidy Laura
 * Shanary de Jesus Martinez Chacon
 * Carlo Ivan Estrada Romero
 * */
namespace Escuela.Control
{
   public class CReporte
    {
        public int guardar(MReporte pReporte)
        {
            String cadena = String.Format("INSERT INTO REPORTE VALUES '{0}','{1}','{2}','{3}','{4}','{5}')", pReporte.Desertor1, pReporte.Dx1, pReporte.Fecha1, pReporte.FkTipo, pReporte.Acciones1, pReporte.FkIdInscribir);
            if (this.existe(pReporte))
            {
                return 0;
            }
            else
            {
                return Conexion.inserta(cadena);
            }
        }
        private bool existe(MReporte pReporte)
        {
            String cadena = String.Format("SELECT * FROM REPORTE WHERE US_IDREPORTE= '{0}')", pReporte.IdReporte);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;

        }
        public List<MReporte> listarTodo()
        {
            List<MReporte> lista = new List<MReporte>();
            MReporte nuevo;
            String cadena = "SELECT * FROM REPORTE ";
            SqlDataReader leidos = Conexion.consulta(cadena);
            while (leidos.Read())
            {
                nuevo = new MReporte();
                nuevo.Desertor1 = leidos.GetInt16(0);
                nuevo.Dx1 = leidos.GetString(1);
                nuevo.Fecha1 = leidos.GetDateTime(2);
                nuevo.FkTipo = leidos.GetInt32(3);
                nuevo.Acciones1 = leidos.GetString(4);
                nuevo.FkIdInscribir = leidos.GetInt32(5);
                lista.Add(nuevo);

            }
            return lista;
        }
    }
}
    
        
