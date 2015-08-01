using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Autor: Hilda Mireya Calva Chavarria
Mónica Yesenia Viveros Bautista
Juan Manuel Dorantes Peréz
 * Autor Documentación: Mónica Yesenia Viveros Bautista
Fecha: 07/07/2014
 */
namespace Escuela.Modelo
{
   public  class MTipoReporte
    //En esta parte se hace la inicialización de la clase principal
    {
        CTipoReporte tr = new CTipoReporte();

        private int idTipo;
        /*Este método es el encargado de hacer los
* get y set de la variable IdTipo
*/
        public int IdTipo
        {
            get { return idTipo; }
            set { idTipo = value; }
        }

        
        private String nombre;
        /*Este método es el encargado de hacer los
         * get y set de la variable nombre
         */
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private DateTime fechaInicio;
        /*Este método es el encargado de hacer los
         * get y set de la variable fechaInicio
         */
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        private DateTime fechaFin;
        /*Este método es el encargado de hacer los
         * get y set de la variable fechaFin
         */

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        //Método vacio
        public MTipoReporte() { }

        /*Método que nos pide que regresemos un dato de tipo entero
         * como respuesta ára guardar un registro
         */
        public int guardar()
        {
            return tr.guardar(this);
        }
        /*Método que nos permite listar registros
         dados desde la base de datos*/
        public List<MTipoReporte> listarTodo2()
        {
            return tr.consultaTodo2();
        }
        /*Este método nos permite llamar a modificar para
         * poder cambiar los datos que se han introducido
         * antes
         */
        public int modificar()
        {
            return tr.modificar(this);
        }

        /*Manda a llamar un metodo que nos permite borrar 
         * registros
         */
        public int eliminar(){
            return tr.eliminar(this);
        }
       

    }
}
