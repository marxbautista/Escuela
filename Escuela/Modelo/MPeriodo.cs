using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  AUTOR: SAIRA KAREN LUGO GARDUÑO
 *  GABRIELA DURAN TREJO
 *  ENRIQUE HERNADEZ IBARRA 
 *  AUTOR DE DOCUMENTACIO: SAIRA KAREN LUGO GARDUÑO 
 *  FECHA:7 JULIO 2014
 */

namespace Escuela.Modelo
{

    /* se crean los set y get de los objetos idPeriodo, mesIncio, mesFin y anio   
     * El metodo get devuelve el valor de un objeto tiene un retorno que se relaciona con el tipo de variable,   
     * generalmente no toman ningun parametro.  
     * El metodo set retorna un void y toma un parametro del tipo adecuado para asignar  a la variable. 
     * En este metodo vamos a crear todas las variables de manera interna de los botones que tenemos en la vista 
     * esto es lo que el usuario no nesecita ver de los botones 
     */
    public class MPeriodo
    {
          CPeriodo control = new CPeriodo();
          private int idPeriodo;

          public int IdPeriodo
          {
              get { return idPeriodo; }
              set { idPeriodo = value; }
          }

        
         
           
          

          private string mesFin;

          public string MesFin
          {
              get { return mesFin; }
              set { mesFin = value; }
          }
          private string mesInicio;

          public string MesInicio
          {
              get { return mesInicio; }
              set { mesInicio = value; }
          }
        
        private string anio;
        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        /*
         * Modificado Deyanira, Gonzalo , Bibiano
         * Fecha: miercoles 9 Julio
         */
        private String periodoCorto;

        public String PeriodoCorto
        {
            get { return this.mesInicio+"-"+this.mesFin+"-"+this.anio; }
            //set { periodoCorto = value; }
        }
        public MPeriodo() { }

        /*         
         * se declara como metodo int entero y       
         * almacena el valor del retorno en una variable del mismo tipo dato.     
         */
        public int guardar() {           
            return control.guardar(this);        
        }
        /*        
         * implementa las listas con los datos que se van agregando.    
         */
        public List<MPeriodo> listarTodos()  {  
            return control.consultaTodo();  
        }
        /* se declara como metodo int entero y almacena el valor de la nueva modificacion del retorno en una variable   
         * del mismo tipo de dato       
         */
        public int modificar() {   
            return control.modificar(this);     
        }
        /* se declara como metodo int entero y almacena el valor del retorno 
         * en una varible del mismo tipo de datos.     
         */
        public int elimnar()
        {
            return control.eliminar(this);
        }
        public string checarPeriodo(string llavePeriodo)
        {
            return new CPeriodo().buscaPeriodo(llavePeriodo);
        }
   

    }
}
