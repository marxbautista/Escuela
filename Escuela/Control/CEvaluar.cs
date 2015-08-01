using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 AUTOR: ANTONIO QUINTANAR VIVEROS
 * RANDY GAEL PEREZ MONTOÑA
 * BRENDA GACHUZ SANTIAGO
 * FECHA : 09/07/2014 
 * 
 */
namespace Escuela.Control
{
   public class CEvaluar
    {
       public int guardar(MEvaluar pEvaluar)
       {
           String cadena = String.Format("INSERT INTO EVALUAR VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", pEvaluar.Fkidindicador, pEvaluar.FkClaveMateria, pEvaluar.FkIdPeriodo, pEvaluar.FkIdCarrera, pEvaluar.Unidad, pEvaluar.Parcial, pEvaluar.Porcentaje);
           if (this.existe(pEvaluar))
           {
               return 0;
           }
           else
           {
               return Conexion.inserta(cadena);
           }
       }
           private bool existe(MEvaluar pEvaluar){
              String cadena = String.Format("SELECT * FROM EVALUAR WHERE EV_FKIDINDICADOR ='{0}'", pEvaluar.Fkidindicador);
              SqlDataReader leer = Conexion.consulta(cadena);
              bool resp = leer.HasRows;
              leer.Close();
              return resp;
          }
    public List<MEvaluar> listaTodos(){
        List<MEvaluar> lista = new List<MEvaluar>();
        String cadena = "SELECT * FROM EVALUAR ";
        SqlDataReader leer = Conexion.consulta(cadena);
        while(leer.Read()){
            MEvaluar nuevo = new MEvaluar();
            nuevo.Fkidindicador = leer.GetDecimal(0);
            nuevo.FkClaveMateria = leer.GetString(1);
            nuevo.FkIdPeriodo = leer.GetInt32(2);
            nuevo.FkIdCarrera = leer.GetInt32(3);
            nuevo.Unidad = leer.GetDecimal(4);
            nuevo.Parcial = leer.GetInt32(5);
            nuevo.Porcentaje = leer.GetDecimal(6);
            lista.Add(nuevo);
        }
        return lista;
    }
       public int modificar (MEvaluar pEvaluar){
           String cadena = String.Format("UPDATE EVALUAR SET EV_UNIDAD = '{4}'WHERE EV_PARCIAL='{5}'AND EV_PORCENTAJE'{6}'", pEvaluar.Unidad, pEvaluar.Parcial, pEvaluar.Porcentaje);
           return Conexion.modifica(cadena);
       }
       public int eliminar(MEvaluar pEvaluar){
           String cadena = String.Format("DELETE FROM EVALUAR WHERE EV_UNIDAD='{4}'", pEvaluar.Unidad);
           if (this.existe(pEvaluar)){
                return Conexion.elimina(cadena);
           }
           else{
               return 0;
           }
       }
   }
  }


