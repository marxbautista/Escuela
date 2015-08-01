using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *   AUTOR: MARIO PEREZ BAUTISTA
 *  FECHA: 02/07/2014
 */
namespace Escuela.Control
{
    public class CAlumno
    {
        public int guardar(MAlumno pAlumno) {
            String cadena = String.Format("INSERT INTO ALUMNO VALUES('{0}','{1}')",pAlumno.Matricula,pAlumno.Nombre);
            if (this.existe(pAlumno))
                return 0;
            else
                return Conexion.inserta(cadena);
        
        }
        public bool existe(MAlumno pAlumno) {
            String cadena = String.Format("SELECT * FROM ALUMNO WHERE AL_MATRICULA='{0}'",pAlumno.Matricula);
            SqlDataReader leer = Conexion.consulta(cadena);
            bool resp = leer.HasRows;
            leer.Close();
            return resp;
        }
        public List<MAlumno> consultaTodo() {
            List<MAlumno> lista = new List<MAlumno>();
            String cadena = "SELECT * FROM ALUMNO";
            SqlDataReader leer = Conexion.consulta(cadena);
            while (leer.Read()) {
                MAlumno nuevo = new MAlumno();
                nuevo.Matricula = leer.GetString(0);
                nuevo.Nombre = leer.GetString(1);
                
                lista.Add(nuevo);
            
            }
            return lista;

        
        }
        public int modificar(MAlumno pAlumno) {
            String cadena = String.Format("UPDATE ALUMNO SET AL_NOMBRE='{0}' WHERE AL_MATRICULA='{1}'", pAlumno.Nombre, pAlumno.Matricula);
            return Conexion.modifica(cadena);
        
        }
        public int eliminar(MAlumno pAlumno) {
            String cadena = String.Format("DELETE FROM ALUMNO WHERE AL_MATRICULA='{0}'", pAlumno.Matricula);
            return Conexion.elimina(cadena);
        }

    }
}
