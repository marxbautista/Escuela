using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Autor: Jennifer Serrano Santiago
 * Brayan Uriel Hernandez Gonzalez
 * 09/07/14
 */

namespace Escuela.Modelo
{
    public class MCarrera
    {
        /*Esto es una encapsulacion de codigo,numero,planes,Nombre, el cual obtiene y regresa los valores
    * 
    */
        CCarrera control = new CCarrera();
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

      
      
        private string planes;

        public string Planes
        {
            get { return planes; }
            set { planes = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /*En este metodo, enlista toda la tabla y Retorna la tabla de la lista Enlistada
  * 
  */
        public  MCarrera() { }
        

        public List<MCarrera> listartodos()
        {

            return control.consultaTodo();

        }
        public int guardar()
        {
            return control.guardar(this);
        }
        public int modificar()
        {
            return control.modificar(this);
        }
         public int eliminar()
         {
             return control.eliminar(this);

         }
         public string checaCarrera(string llaveCarrera)
         {
             return new CCarrera().buscaCarrera(llaveCarrera);
         }

    }
}
