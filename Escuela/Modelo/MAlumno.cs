using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *   AUTOR: MARIO PEREZ BAUTISTA
 *  FECHA: 02/07/2014
 */
namespace Escuela.Modelo
{
    public class MAlumno
    {
        CAlumno control = new CAlumno();
        private String matricula;

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public MAlumno() { }
        public int guardar() {
            return control.guardar(this);
        }
        public List<MAlumno> listarTodos() {
            return control.consultaTodo();
        }
        public int modificar() {
            return control.modificar(this);
        }
        public bool consultaExistencia() {
            return control.existe(this);
        }
        public int eliminar() {
            return control.eliminar(this);
        }

    }
}
