using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Modelo
{
   public  class MUsuario
    {
       CUsuario control = new CUsuario();
       private String idusuario;

       public String Idusuario
       {
           get { return idusuario; }
           set { idusuario = value; }
       }
       private Decimal fkIdDocente;

       public Decimal FkIdDocente
       {
           get { return fkIdDocente; }
           set { fkIdDocente = value; }
       }
       private String rol;

       public String Rol
       {
           get { return rol; }
           set { rol = value; }
       }
       private String contrasena;

       public String Contrasena
       {
           get { return contrasena; }
           set { contrasena = value; }
       }
       public MUsuario() { }
       public int guardar() { 
            return control.guardar(this);
       }
       public List<MUsuario> listarTodos() {
           return control.listarTodos();
       }

    }
}
