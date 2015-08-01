using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * AUTOR: SAIRA KAREN LUGO GARDUÑO
 * GABRIELA DURAN TREJO
 * ENRIQUE HERNADEZ IBARRA
 * FECHA:7 JULIO 2014
 * AUTOR DE DOCUMENTACION: GABRIELA DURAN TREJO
 */

namespace Escuela.Control
{
     public class CPeriodo
    {
        /*          
         *  A este  metodo lo nombramos guardar, este metodo recibira como parametros   
         *  los datos que tenemos en nuestra clase MPeriodo y tendra como nombre pPeriodo, lo que ara      
         *  es gurdar los datos que son necesarios para el insert  en una cadena.Y tendra que cumplir        
         *  la condicion de nuestro metodo existe si ya existe ese registro pues que ya no guarde nada,         
         *  de lo contrario si no existe que  nos realize el metodo inserta de la clase Conexion.        
         * */
        public int guardar(MPeriodo pPeriodo) {  
            string cadena = string.Format("INSERT INTO Periodo VALUES('{0}','{1}','{2}')", pPeriodo.MesInicio,pPeriodo.MesFin,pPeriodo.Anio);
            if (this.existe (pPeriodo))      
                return 0; 
            else           
                return Conexion.inserta(cadena);
        }

        /*    
         *  A este metodo lo nombramos existe y es de tipo bool, este metodo recibira como parametros    
         *  los datos que tenemos en nuestra clase MPeriodo y tendra como nombre pPeriodo, este metodo      
         *  lo que ara es mostrar si ya existe un registro y esto lo realizara mediante pe_IdPeriodo.      
         */
       
        public bool existe(MPeriodo pPeriodo)
        { 
             string cadena = string.Format("SELECT * from Periodo WHERE pe_IdPeriodo={0}", pPeriodo.IdPeriodo); 
             SqlDataReader leer = Conexion.consulta(cadena);
             bool resp = leer.HasRows;
             leer.Close();
            return resp;
        }
          

        /*       
         *  A este  metodo lo nombramos guardar, este metodo recibira como parametros      
         *  los datos que tenemos en nuestra clase MPeriodo y tendra como nombre pPeriodo, lo que ara     
         *  es gurdar los datos que son necesarios para el insert  en una cadena.Y tendra que cumplir     
         *  la condicion de nuestro metodo existe si ya existe ese registro pues que ya no guarde nada,     
         *   de lo contrario si no existe que  nos realize el metodo inserta de la clase Conexion.        
         */      
   

        public List<MPeriodo> consultaTodo()
        {
            List<MPeriodo> lista = new List<MPeriodo>(); 
            string cadena = "select * from Periodo";
            SqlDataReader leer = Conexion.consulta(cadena);
            while(leer.Read())
            {
                MPeriodo nuevo = new MPeriodo();
                nuevo.IdPeriodo = leer.GetInt32(0);
                nuevo.MesInicio = leer.GetString(1);
                nuevo.MesFin = leer.GetString(2);
                nuevo.Anio = leer.GetString(3); 
                lista.Add(nuevo);
            } 
            return lista;
        }
        /*       
         *  A este metodo lo nombramos modificar y sera de tipo int, este metodo recibira como parametros    
         *  los datos que tenemos en nuestra clase MPeriodo y tendra como nombre pPeriodo , lo que   
         *  realizara sera modificar cada uno de nuestros campos mediante nuestra cadena de tipo string     
         *  execepto el de idPerido por que esa es una clave primaria que nunca puede ser modificada.  
         *  y ya lo que regresara sera lo que existe en la clase Conexion en el metodo modifica, y     
         *  modificara lo que existe en la cadena.    
         *  */

        public int modificar(MPeriodo pPeriodo)
        {
            string cadena = string.Format("UPDATE Periodo SET pe_mesInicio='{1}' , pe_mesFin='{2}', pe_anio='{3}' WHERE pe_IdPeriodo = {0}", pPeriodo.IdPeriodo, pPeriodo.MesInicio, pPeriodo.MesFin, pPeriodo.Anio);
            return Conexion.modifica(cadena); 
        }
        /*   
         *  Este es un metodo int, al que lo nombramos eliminar, este metodo recibira como parametros
         *  los datos que tenemos en nuestra clase MPeriodo y tendra como nombre pPeriodo,lo que realizara      
         *  este metodo es eliminar el registro que el usuario desee, y lo ara mediante la cadena almacenanda   
         *  y se llevara acabo la condicion que dice WHERE pe_IdPeriodo={0},lo que quiere decir      
         *  pe_IdPeriodo esta en la posicion 0, si esto existe que elimine el registro deseado de      
         *  lo contrario que no realize ninugun cambio       
         */
        
        public int eliminar(MPeriodo pPeriodo)
        {
            String cadena = string.Format("DELETE FROM Periodo WHERE pe_IdPeriodo={0}",pPeriodo.IdPeriodo);
            if (this.existe(pPeriodo))
            {
                return Conexion.elimina(cadena);
            }
            else
            {
                return 0;
            }
        }
        public string buscaPeriodo(string llaveHorario)
        {

            string cadena = String.Format("SELECT * FROM PERIODO WHERE PE_IDPERIODO= {0}", llaveHorario);
            SqlDataReader leer = Conexion.consulta(cadena);
            string mes1 = "";
            string mes2 = "";
            string anio = "";
            string resultado = "";
            while (leer.Read())
            {
                mes1 = leer.GetString(1);
                mes2 = leer.GetString(2);
                anio = leer.GetString(3);

            }
            resultado = mes1 + "-" + mes2 + "-" + anio;
            return resultado;
        }

        }
     
    }


