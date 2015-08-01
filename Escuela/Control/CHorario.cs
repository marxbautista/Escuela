using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* autor: Azhenet Sanchez Oviedo.. 
 * autor de documentacion: 
 * carlo ivan estrada romero
 * fecha: 07/07/14
 */

namespace Escuela.Control
{
    public class CHorario
    {
    /* Este metodo es para guardar los datos del horario
     * 
     */ 
        public int guardar(MHorario pHorario)
        {
            String cadena = String.Format("INSERT INTO HORARIO VALUES ('{0}','{1}','{2}','{3}')", pHorario.Dia1,pHorario.Inicio, pHorario.Fin, pHorario.Aula);
        
            

            if(this.existe(pHorario))
                return 0;
            else
                return Conexion.inserta(cadena);
        }
    /*Este metodo Retorna un boleano  existente a Mhorario
     * 
     */ 
        public bool existe(MHorario pHorario)
        {
            String cadena = String.Format("SELECT * FROM HORARIO WHERE Ho_IdHorario ={0}", pHorario.IdHorario);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;
        }

    /* Este metodo sirve para que cada lista de horario sean leidos los datos en la lista
     * 
     */ 

        public List<MHorario> consultaTodo()
        {
            List<MHorario> lista = new List<MHorario>();
            String cadena = "SELECT * FROM HORARIO";
            SqlDataReader leer = Conexion.consulta(cadena);
            while (leer.Read())
            {
                MHorario nuevo = new MHorario();
                //nuevo.Matricula = leer.GetString(0);
                nuevo.IdHorario = leer.GetInt32(0);
                nuevo.Dia1 = leer.GetString(1);
                nuevo.Inicio = leer.GetTimeSpan(2);
                nuevo.Fin = leer.GetTimeSpan(3);
                nuevo.Aula = leer.GetString(4);
                lista.Add(nuevo);
            }
            return lista;
        }
    /* Este metodo modifica los horarios que se ingresaron en nuestra tabla
     * 
     */ 
        public int modificar(MHorario pHorario)
        {
            String cadena = String.Format("UPDATE HORARIO SET Ho_dia='{0}',Ho_Inicio='{1}',Ho_Fin='{2}',Ho_Aula='{3}' WHERE Ho_IdHorario={4}", pHorario.Dia1, pHorario.Inicio, pHorario.Fin, pHorario.Aula, pHorario.IdHorario);
            return Conexion.modifica(cadena);
        }
        /*Este es una Construcción de una cadena y una mezcla con datos de SQL
         * 
         */ 
        public int eliminar(MHorario pHorario) {

            string cadena = String.Format("DELETE FROM HORARIO WHERE Ho_IdHorario= {0}", pHorario.IdHorario);
            if (this.existe(pHorario))
            {
                return Conexion.elimina(cadena);

            }
            else {

                return 0;
            }
        
        }
        public string buscaHorario(string llaveHorario)
        {
            List<MHorario> lista = new List<MHorario>();
            string cadena = String.Format("SELECT * FROM HORARIO WHERE Ho_IdHorario= {0}", llaveHorario);
            SqlDataReader leer = Conexion.consulta(cadena);
            string dia = "";
            string hora2 = "";
            string hora3 = "";
            string fin = "";
            while (leer.Read())
            {
                dia = leer.GetString(1);
                hora2 = leer.GetTimeSpan(2).ToString();
                hora3 = leer.GetTimeSpan(3).ToString();

            }
            fin = hora2 + "/" + hora3 + "/" + dia;
            return fin;
        }
    
    }


}
