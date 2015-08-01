using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autores: Bibiano, Deyanira, Gonzalo
 * Fecha: miercoles 9 de julio 2014
 */
//se inserta una cadena la cual se inserta todos los elentos//
namespace Escuela.Control
{
   public class CGrupo
    {
       public int guardar(MGrupo pGrupo)
       {
           String cadena = String.Format("INSERT INTO GRUPO VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
               pGrupo.ClaveGrupo, pGrupo.FkIdPeriodo, pGrupo.FkIdDocente, pGrupo.FkClaveMateria, pGrupo.FkIdCarrera,
               pGrupo.FkIdHorario);
           if (this.existe(pGrupo))
           {
               return 0;
           }
           else
           {
               return Conexion.inserta(cadena);
           }
       }
       //esta cadena en  el update es la actualizacion de la cadena para modificar el grupo//
       public int modificar(MGrupo pGrupo)
       {
           string cadena = string.Format("UPDATE GRUPO SET GR_FKIDPERIODO={0},GR_FKIDDOCENTE={1},GR_FKCLAVEMATERIA='{2}',GR_FKIDCARRERA={3},GR_FKIDHORARIO={4} WHERE GR_CLAVEGRUPO='{5}'", 
               pGrupo.FkIdPeriodo, pGrupo.FkIdDocente, pGrupo.FkClaveMateria,
               pGrupo.FkIdCarrera, pGrupo.FkIdHorario, pGrupo.ClaveGrupo);
           return Conexion.modifica(cadena);
       }
       //este metodo elimina lo existente en la tabla grupo// 
       public int eliminar(MGrupo PGrupo)
       {
           string cadena = string.Format("DELETE FROM GRUPO WHERE GR_CLAVEGRUPO = '{0}' ", PGrupo.ClaveGrupo);
           if (this.existe(PGrupo))
           {
               return Conexion.elimina(cadena);

           }
           else
           {
               return 0;
           }
       }
       //lee la conexion de la cadena  y remplaza  uno o varios elementos de formato de una cadena especificada//
       private bool existe(MGrupo pGrupo)
       {
           String cadena = String.Format("SELECT * FROM GRUPO WHERE  gr_CLAVEGRUPO ='{0}'", pGrupo.ClaveGrupo);
           SqlDataReader leer = Conexion.consulta(cadena);
           bool resp = leer.HasRows;
           leer.Close();
           return resp;


       }
       //representa una lista de objetos la cual puede buscar o leer la conexion de tipo cadena o de cada atributo y la muestra// 
       public List<MGrupo> listarTodos()
       {
           List<MGrupo> lista = new List<MGrupo>();
           MGrupo nuevo;
           String cadena = "SELECT * FROM GRUPO ";
           SqlDataReader leidos = Conexion.consulta(cadena);
           while (leidos.Read())
           {
              
               nuevo = new MGrupo();
               nuevo.ClaveGrupo = leidos.GetString(0);
               nuevo.FkIdPeriodo = leidos.GetInt32(1);
               nuevo.FkIdDocente = Convert.ToInt32(leidos.GetValue(2));
               nuevo.FkClaveMateria = leidos.GetString(3);
               nuevo.FkIdCarrera = leidos.GetInt32(4);
               nuevo.FkIdHorario = leidos.GetInt32(5);

               lista.Add(nuevo);
           }
           leidos.Close();
           return lista;
       }
    }
}
