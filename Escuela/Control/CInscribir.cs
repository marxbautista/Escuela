using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  AUTOR: SAIRA KAREN LUGO GARDUÑO
 *  GABRIELA DURAN TREJO
 *  ENRIQUE HERNADEZ IBARRA 
  *  FECHA: 9 JULIO 2014
 */
namespace Escuela.Control
{
    public class CInscribir
    {
        /*          
         *  A este  metodo lo nombramos guardar, este metodo recibira como parametros   
         *  los datos que tenemos en nuestra clase MInscribir y tendra como nombre pInscribir, lo que ara      
         *  es gurdar los datos que son necesarios para el insert  en una cadena.Y tendra que cumplir        
         *  la condicion de nuestro metodo existe si ya existe ese registro pues que ya no guarde nada,         
         *  de lo contrario si no existe que  nos realize el metodo inserta de la clase Conexion.        
         * */
        public int guardar(MInscribir pInscribir)
        {
            string cadena = string.Format("INSERT INTO INSCRIBIR VALUES({0},'{1}','{2}',{3},'{4}')", pInscribir.IdInscribir, pInscribir.FkMatricula, pInscribir.FkClaveGrupo, pInscribir.FkIdPeriodo,pInscribir.Estado);
            if (this.existe(pInscribir))
            {
                return 0;
            }
            else
            {
                return Conexion.inserta(cadena);
            }
        }
        /*    
       *  A este metodo lo nombramos existe y es de tipo bool, este metodo recibira como parametros    
       *  los datos que tenemos en nuestra clase MInscribir y tendra como nombre pInscribi, este metodo      
       *  lo que ara es mostrar si ya existe un registro y esto lo realizara mediante pe_IdPeriodo.      
       */

        public bool existe(MInscribir pInscribir) {
            String cadena = String.Format("SELECT * FROM INSCRIBIR WHERE IS_IDINSCRIBIR='{0}'",pInscribir.IdInscribir);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;
        }

            /*       
             *  A este  metodo lo nombramos guardar, este metodo recibira como parametros      
             *  los datos que tenemos en nuestra clase MInscribi y tendra como nombre pInscribir, lo que ara     
             *  es gurdar los datos que son necesarios para el insert  en una cadena.Y tendra que cumplir     
             *  la condicion de nuestro metodo existe si ya existe ese registro pues que ya no guarde nada,     
             *   de lo contrario si no existe que  nos realize el metodo inserta de la clase Conexion.        
             */
        public List<MInscribir> listarTodos()
        {
            List<MInscribir> lista = new List<MInscribir>();
            String cadena = "SELECT * FROM INSCRIBIR";
            SqlDataReader leer = Conexion.consulta(cadena);
            while (leer.Read())
            {
                MInscribir nuevo = new MInscribir();
                nuevo.IdInscribir = Convert.ToInt32(leer.GetString(0));
                nuevo.FkMatricula = leer.GetString(1);
                nuevo.FkClaveGrupo = leer.GetString(2);
                nuevo.FkIdPeriodo = Convert.ToInt32(leer.GetString(3));
                nuevo.Estado = leer.GetString(4);

                lista.Add(nuevo);

            }
            return lista;


        }
            /*       
             *  A este metodo lo nombramos modificar y sera de tipo int, este metodo recibira como parametros    
             *  los datos que tenemos en nuestra clase MInscribir y tendra como nombre pInscribir , lo que   
             *  realizara sera modificar cada uno de nuestros campos mediante nuestra cadena de tipo string     
             *  execepto el de Is_idInscribi por que esa es una clave primaria que nunca puede ser modificada.  
             *  y ya lo que regresara sera lo que existe en la clase Conexion en el metodo modifica, y     
             *  modificara lo que existe en la cadena.    
             *  */
            public int modificar(MInscribir pInscribir)
            {
                String cadena = String.Format("UPDATE INSCRIBIR SET Is_idInscribir={0} WHERE Is_FkMatricula	='{1}'AND Is_FkClaveGrupo='{2}'AND Is_FkIdPeriodo= {3} AND Is_Estado='{4}')", pInscribir.IdInscribir, pInscribir.FkMatricula, pInscribir.FkClaveGrupo, pInscribir.FkIdPeriodo, pInscribir.Estado);
                return Conexion.modifica(cadena);

            }
            /*   
             *  Este es un metodo int, al que lo nombramos eliminar, este metodo recibira como parametros
             *  los datos que tenemos en nuestra clase MInscribir y tendra como nombre pInscribi,lo que realizara      
             *  este metodo es eliminar el registro que el usuario desee, y lo ara mediante la cadena almacenanda   
             *  y se llevara acabo la condicion que dice WHERE Is_idInscribir={0},lo que quiere decir      
             *  IdInscribir esta en la posicion 0, si esto existe que elimine el registro deseado de      
             *  lo contrario que no realize ninugun cambio       
             */
            public int eliminar(MInscribir pInscribir){

                String cadena = String.Format("DELETE FROM INSCRIBIR WHERE Is_idInscribir={0}", pInscribir.IdInscribir);
                return Conexion.elimina(cadena);
            }

        }
    }

