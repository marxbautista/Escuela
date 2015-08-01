using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * AUTOR:MITZEL,RANDY,BRENDA
 * FECHA:03-07-14
 */

namespace Escuela.Control
{
    public class CMateria
    {
        public int guardar(MMateria pMateria)
        {
            String cadena = String.Format("INSERT INTO MATERIA VALUES ('{0}','{1}')", pMateria.Clave, pMateria.NombreMateria);
                if(this.existeMateria(pMateria))
                    return 0;
                else 
                    return Conexion.inserta (cadena);            
        }
        public bool existeMateria(MMateria pMateria)
        {
            String cadena = String.Format("Select * from Materia where MA_Clave='{0}'", pMateria.Clave);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;
        }
        public List<MMateria> consultaTodo()
        {
            List<MMateria> lista = new List<MMateria>();
            String cadena = "SELECT * FROM MATERIA ";
            SqlDataReader leer = Conexion.consulta(cadena);
                while (leer.Read())
               {
                    MMateria nuevo = new MMateria();
                    nuevo.Clave = leer.GetString(0);
                    nuevo.NombreMateria = leer.GetString(1);
                    lista.Add(nuevo);
                }
                return lista;
        }
        public int modificar(MMateria pMateria){
            String cadena =String.Format("UPDATE MATERIA SET MA_NombreMateria='{0}'WHERE MA_Clave='{1}'",pMateria.NombreMateria, pMateria.Clave);
            return Conexion.modifica(cadena);

        }
        public int eliminar(MMateria pMateria){
            String cadena = String.Format("DELETE FROM  MATERIA WHERE Ma_Clave='{0}'",pMateria.Clave);
            if (this.existeMateria(pMateria))
            {
                return Conexion.elimina(cadena);
            }
            else
            {
                return 0;
            }
        }
        public string buscaMateria(string llaveMateria)
        {
            string cadena = String.Format("SELECT MA_NOMBREMATERIA FROM MATERIA WHERE MA_CLAVE= '{0}'", llaveMateria);
            SqlDataReader leer = Conexion.consulta(cadena);
            string materia = "";
            while (leer.Read())
            {
                materia = leer.GetString(0);
            }
            return materia;
        }
    }
}

