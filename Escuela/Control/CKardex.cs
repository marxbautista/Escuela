using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Autores: Hilda Mireya Calva Chavarria
 * Juan Manuel Dorantes Pérez
 * Mónica Yesenia Viveros Bautista
 * Fecha: 09/07/2014
 */
namespace Escuela.Control
{
    public class CKardex
    {
        public int guardar(MKardex pKardex)
        {
            String cadena = String.Format("INSERT INTO KARDEX VALUES('{0}','{1}','{2}','{3}')", pKardex.FkIdinscribir, pKardex.Unidad, pKardex.Indicador, pKardex.Calificacion);
            if (this.existe(pKardex))
            {
                return 0;
            }
            else
            {
                return Conexion.inserta(cadena);
            }
        }
             private bool existe(MKardex pKardex)
            {
            String cadena = String.Format("SELECT * FROM KARDEX WHERE KA_UNIDAD='{0}'AND KA_INDICADOR='{1}' AND KA_CALIFICACION ='{3}'", pKardex.Unidad, pKardex.Indicador, pKardex.Calificacion);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows; // hasrows es como un hay filas?
            leer.Close();
            return resp;

             }
         public List<MKardex> listarTodos()
        {
            List<MKardex> lista = new List<MKardex>();
            MKardex nuevo;
            String cadena = "SELECT * FROM KARDEX";
            SqlDataReader leidos = Conexion.consulta(cadena);
            while(leidos.Read()){
                nuevo= new MKardex();
                nuevo.FkIdinscribir = leidos.GetInt32(0);
                nuevo.Unidad =Convert.ToInt32(leidos.GetValue(1));
                nuevo.Indicador = leidos.GetInt32(2);
                nuevo.Calificacion = leidos.GetDouble(3);
                lista.Add(nuevo);

            }
            return lista;
        
        }
    }
}
