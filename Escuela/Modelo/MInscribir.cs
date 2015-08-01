using System;
using System.Collections.Generic;
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
    /*   
     * El metodo get devuelve el valor de un objeto tiene un retorno que se relaciona con el tipo de variable,   
     * generalmente no toman ningun parametro.  
     * El metodo set retorna un void y toma un parametro del tipo adecuado para asignar  a la variable. 
     * En este metodo vamos a crear todas las variables de manera interna de los botones que tenemos en la vista 
     * esto es lo que el usuario no nesecita ver de los botones 
     */
   public  class MInscribir
    {
       CInscribir control = new CInscribir();



       private int idInscribir;

       public int IdInscribir
       {
           get { return idInscribir; }
           set { idInscribir = value; }
       }


       private string fkMatricula;

       public string FkMatricula
       {
           get { return fkMatricula; }
           set { fkMatricula = value; }
       }


       private string fkClaveGrupo;

       public string FkClaveGrupo
       {
           get { return fkClaveGrupo; }
           set { fkClaveGrupo = value; }
       }



       private int fkIdPeriodo;


       public int FkIdPeriodo
       {
           get { return fkIdPeriodo; }
           set { fkIdPeriodo = value; }
       }


        private string estado;

public string Estado
{
  get { return estado; }
  set { estado = value; }
}
/*         
  * se declara como metodo int entero y       
  * almacena el valor del retorno en una variable del mismo tipo dato.     
  */

public int guardar()
{
    return control.guardar(this);
}
/*        
  * implementa las listas con los datos que se van agregando.    
  */
public List<MInscribir> listarTodos()
{
    return control.listarTodos();
}
/* se declara como metodo int entero y almacena el valor de la nueva modificacion del retorno en una variable   
  * del mismo tipo de dato       
  */
public int modificar()
{
    return control.modificar(this);
}
public bool consultaExistencia()
{
    return control.existe(this);
}
/* se declara como metodo int entero y almacena el valor del retorno 
  * en una varible del mismo tipo de datos.     
  */
public int eliminar()
{
    return control.eliminar(this);
}

    }
}

