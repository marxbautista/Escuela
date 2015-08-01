using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* autor: Azhenet Sanchez Oviedo
 * fecha: autor de documentacion:
 * shanary de jesus martinez chacon... 
 * fecha: 07/07/14
 */
namespace Escuela.Modelo
{
   public  class MHorario
    {
      /*Esta es una encapsulacion de las variables idhorario, Dia, inicio, fin, Aula.
      * 
      */ 
       CHorario control= new CHorario ();
       private int idHorario;

       public int IdHorario
       {
           get { return idHorario; }
           set { idHorario = value; }
       }
       
       private String Dia;
     
       public String Dia1
       {
           get { return Dia; }
           set { Dia = value; }
       }



       private TimeSpan inicio;

       public TimeSpan Inicio
       {
           get { return inicio; }
           set { inicio = value; }
       }






       private TimeSpan fin;

       public TimeSpan Fin
       {
           get { return fin; }
           set { fin = value; }
       }


       private String aula;

       public String Aula
       {
           get { return aula; }
           set { aula = value; }
       }

       


        public MHorario() { }
     public int guardar () {
         return control.guardar (this);
     }
   /* En este metodo se enlistan y se retornan los datos que se ingresaron 
    * 
   */ 
     public List<MHorario> listarTodos(){
         return control.consultaTodo();

     }
     public int modificar()  {
         return control.modificar(this);
     }

     public int eliminar() {
         return control.eliminar(this);

     }
     private String horarioGrupo;

     public String HorarioGrupo
     {
         get { return this.inicio + "/" + this.fin + "/" + Dia + "/" + this.aula; }
         //set { horarioGrupo = value; }
     }
     public string checaHorario(string llaveHorario)
     {
         return new CHorario().buscaHorario(llaveHorario);
     }
    }
}
