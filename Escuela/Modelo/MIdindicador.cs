using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 AUTOR: ANTONIO QUINTANAR VIVEROS
 * FECHA : 03/07/2014 MODIFICADO: 07/07/2014
 * AUTOR DE COMENTRIO: ANTONIO QUINTANAR VIVEROS
 */
namespace Escuela.Modelo
{
/* En este metodo se indica los metos los cuales se va a utilizar para crear nuestros datos y darles nombre a las columnas los
 * cuales se deveran de mostrar en los datos con su respectivo nombre y asiendole su get y su set lo cual el get retorna un valor y el set
 * es el mismo valor que se le a dado 
 */
  public  class MIdindicador
    {
      CIdindicador control = new CIdindicador();
      private decimal idindicador;

      public decimal Idindicador
      {
          get { return idindicador; }
          set { idindicador = value; }
      }

   /* En este metodo se crea en nombre en el cual se utilizara en la columna y en la cual se vera reflejado en la tabla con el mismo nombre 
    * se le crea su get y su set 
    */
      private String nombre;

      public String Nombre
      {
          get { return nombre; }
          set { nombre = value; }
      }
      /* Se crea el metodo el cual se utilizara en las demas clases y lo cual este retornara el mismo valor que se le a asignado pero este se
       * guardara a su vez
       */
      public int guardar()
      {
          return control.guardar(this);
      }
      /* En este metodo se mostraran los resultados de lo que sea insertado o modificado en a tabla este tambien retornara los datos insertados 
       * o modificdos o borrados mostrando lo que sea echo
       */
      public List<MIdindicador> listaTodos()
      {
          return control.consultaTodo();
      }
      /* En este metodo se declara el nuevo evento en el cual se ara en la modificacion de los dato y el cual se utilizara en las demas clases
       * este tambien retornara el mismo valor modificado en los datos los cuales se mostraran el la tabla
       */
      public int modificar()
      {
          return control.modificar(this);
      }
      /* En este metodo se nombra el boton de la cual se vera reflejada en la frm y este retornara el mismo valor que a borrado mostrando en
       * la tabla lo borrado si se cumple la accion
       */
      public int eliminar()
      {
          return control.eliminar(this);
      }
    }
}
 