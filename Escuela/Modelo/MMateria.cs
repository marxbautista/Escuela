using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * AUTOR:MITZEL,RANDY,BRENDA
 * FECHA:03-07-14
 *AUTOR DE DOCUMENTACION: BRENDA GACHUZ SANTIAGO 
 */

namespace Escuela.Modelo
{

    //clase modelo de el proyecto materia, en ella se declaran las variables que recibira el controlador desde frmMateria
    public class MMateria
    {
        CMateria control = new CMateria();
        private String clave;/* Declaracion de variable privada  'Clave'  la cual es la clave de la materia,
        en la base de datos es considerada como llave primaria*/ 

        /*
         * propiedades get y set para obtener y devolver datos  de la variable en este caso 'Clave'
         */
        public String Clave
        {
            get { return clave; } 
            set { clave = value; }
        }
        private String nombreMateria;/*Declaracion de variable privada 'NombreMateria', 
                                      * esta variable solo recibe datos de la caja de texto de frmMateria, solo para asignar un
                                      * nombre a la materia, no es llave primaria */

        /*
         * propiedad get utilizada para  leer el contenido de variable NombreMateria y set para devolver el contenido de ésta 
         */
        public String NombreMateria
        {
            get { return nombreMateria; }
            set { nombreMateria = value; }
        }

        /*
         * constructor vacio que permite establecer valores predeterminados
         */
        public MMateria() {
        } 
        /*
         * metodo guardar que retorna  en invoca  la clase control con su metodo guardar
         */
        public int guardar() { 
            return   control.guardar(this); 
        }
        /*
         * metodo listarTodo: este metodo solo invoca a la clase control en con el metodo consulta todo 
         * su funcion basica es listar y hacer consulta de las tablas de la BD con las modificaciones que se 
         * le hacen desde frmMateria
         */
        public List<MMateria> listarTodos() 
        {             
            return control.consultaTodo();        
        }        
        /*
         * metodo modificar  unicamente hace referencia a control con el metodo modificar, uicamente el nombre de la 
         * materia sin poder modificar la clave s ya que es llave primaria 
         */
        public int modificar() 
       {           
            return control.modificar(this); 
        }

        /*
         * metodo eliminar: retorna  la clase control con el metodo eliminar.
         */
        public int eliminar()
        {
            return control.eliminar(this);
        }
        public string checaMateria(string llaveMateria)
        {
            return new CMateria().buscaMateria(llaveMateria);
        }

    }
}
