using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Control
{
    public class CUsuario
    {
        public int guardar(MUsuario pUsuario) {
            String cadena = String.Format("INSERT INTO USUARIO VALUES('{0}','{1}','{2}','{3}')",pUsuario.Idusuario,pUsuario.FkIdDocente,pUsuario.Rol,pUsuario.Contrasena);
            if (this.existe(pUsuario))
            {
                return 0;
            }
            else {
                return Conexion.inserta(cadena);
            }
        }
        private bool existe(MUsuario pUsuario) {
            String cadena = String.Format("SELECT * FROM USUARIO WHERE US_IDUSUARIO='{0}'", pUsuario.Idusuario);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;
        }
        public List<MUsuario> listarTodos() {
            List<MUsuario> lista = new List<MUsuario>();
            MUsuario nuevo;
            String cadena = "SELECT * FROM USUARIO";
            SqlDataReader leidos = Conexion.consulta(cadena);
            while(leidos.Read()){
                nuevo = new MUsuario();
                nuevo.Idusuario = leidos.GetString(0);
                nuevo.FkIdDocente = Convert.ToInt32(leidos.GetValue(1));
                nuevo.Rol = leidos.GetString(2);
                nuevo.Contrasena = leidos.GetString(3);
                lista.Add(nuevo);

            }
            return lista;




        
        }


    }
}
