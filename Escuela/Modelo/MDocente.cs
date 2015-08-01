using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Autor: Bibiano Mota Perez, Deyanira Jimenez Hernandez, Gonzalo Aguilar Perez
 Autor de Comentario:Bibiano Mota Perez
   Fecha: 07/07/2014
*/
namespace Escuela.Modelo
{
    
     
    
   public class MDocente
    {
       CDocente control = new CDocente();
       private Decimal idDocente;
       

       /*
        * en este metodo generamos el Get y Set
        * el Get no sirve para obtener el valor o dato de la variable y
        * el set es para asignarle el valor o dato a la variable
        */
       public Decimal IdDocente
       {
           get { return idDocente; }
           set { idDocente = value; }
       }

       private String nombre;

       /*
        * en este metodo generamos el Get y Set
        * el Get no sirve para obtener el valor o dato de la variable y
        * el set es para asignarle el valor o dato a la variable
        */
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
            
        }
       /*
        * Estos metodos son mandados a llamar con la instancia control del metodo control que
        * se creo anteriormente
        * 
        */
       public MDocente() {}
       public int guardar(){
           return control.guardar(this);
       }
       public List<MDocente> listarTodos()
       {
           return control.cosultaTodo();
       }
       public int modificar()
       {
       return control.modificar(this);
       }
       public int eliminar()
       {
           return control.eliminar(this);
       }
       public string checaDocente(string llaveDocente)
       {
           return new CDocente().buscaDocente(llaveDocente);
       }
    }
}
