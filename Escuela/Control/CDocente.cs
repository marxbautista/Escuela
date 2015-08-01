using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Autor: Bibiano Mota Perez, deyanira jimenez hernandez, Gonzalo Aguilar Perez
 Autor de Comentario:Bibiano Mota Perez
   Fecha: 07/07/2014
*/
namespace Escuela.Control
{
    public class CDocente
    {
        /*
         * Creamos el metodo guardar que le hace un referencia de la clase Mdocente,
         * en donde le creamos una cadena que guarda a los docentes ingresados a la Base de Datos 
         * 
         */
        public int guardar(MDocente pDocente)
        {
            String cadena = String.Format("INSERT INTO DOCENTE VALUES('{0}','{1}')",
                pDocente.IdDocente, pDocente.Nombre);
            if (this.existe(pDocente))
                return 0;
            else
                return Conexion.inserta(cadena);
        }

        /*
         * creamos el Metodo existe que le hace referencia a la clase MDocente,
         * en donde creamos un paramero a MDocente que altera la base de datos de docente en donde 
         * al ingresar un idDocente repetido lo rechaza
         */
        public bool existe(MDocente pDocente)
        {
            String cadena = String.Format("SELECT * FROM DOCENTE WHERE DO_IDDOCENTE='{0}'"
                , pDocente.IdDocente);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            return resp;
        }


        /*
         * este metodo representa una lista de objetos a la que se le puede  obtener acceso por indice
         * proporciona metodos para, Buscar, ordenar y manipular listas
         * de la tabla de Docente de la base de datos
         */
        public List<MDocente> cosultaTodo()
        {
            List<MDocente> lista = new List<MDocente>();
            String cadena = "SELECT * FROM DOCENTE";
            SqlDataReader leer = Conexion.consulta(cadena);
            while (leer.Read())
            {
                MDocente nuevo = new MDocente();
                nuevo.IdDocente = leer.GetDecimal(0);
                nuevo.Nombre = leer.GetString(1);
                lista.Add(nuevo);
            }
            return lista;
        }

        /*
         * creamos el metodo modificar 
         * este se encarga de remplazar loes elemento del formato en la cadena especificada
         */
        public int modificar(MDocente pDocente)
        {
            String cadena = String.Format("UPDATE DOCENTE SET DO_NOMBRE='{0}' WHERE DO_IDDOCENTE='{1}'",
                pDocente.Nombre, pDocente.IdDocente);
            return Conexion.modifica(cadena);
        }

        /*
         * este metodo nos sirve para eliminar objetos de la cadena especificada
         */
        public int eliminar(MDocente pDocente)
        {
            String cadena = String.Format("DELETE FROM DOCENTE WHERE do_IdDocente={0}",
                pDocente.IdDocente);
            if (this.existe(pDocente))
            {
                return Conexion.elimina(cadena);

            }
            else
            {
                return 0;
            }
        }
        public string buscaDocente(string llaveDocente)
        {
            string cadena = String.Format("SELECT do_nombre FROM docente WHERE do_idDocente= '{0}'", llaveDocente);
            SqlDataReader leer = Conexion.consulta(cadena);
            string docente = "";
            while (leer.Read())
            {
                docente = leer.GetString(0);
            }
            return docente;
        }

    }
}
