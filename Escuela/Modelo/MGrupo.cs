using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autores: Bibiano, Deyanira, Gonzalo
 * Fecha: miercoles 9 de julio 2014
 */
   //en este metodo generamos el Get y Set el Get no sirve para obtener el valor o dato de la variable 
   //y el set es para asignarle el valor o dato a la variable


namespace Escuela.Modelo
{
    public class MGrupo
    {
        CGrupo control = new CGrupo();

        private String claveGrupo;

        public String ClaveGrupo
        {
            get { return claveGrupo; }
            set { claveGrupo = value; }
        }
        private int fkIdPeriodo;

        public int FkIdPeriodo
        {
            get { return fkIdPeriodo; }
            set { fkIdPeriodo = value; }
        }


        private Decimal fkIdDocente;

        public Decimal FkIdDocente
        {
            get { return fkIdDocente; }
            set { fkIdDocente = value; }
        }
        private String fkClaveMateria;

        public String FkClaveMateria
        {
            get { return fkClaveMateria; }
            set { fkClaveMateria = value; }
        }
        private int fkIdCarrera;

        public int FkIdCarrera
        {
            get { return fkIdCarrera; }
            set { fkIdCarrera = value; }
        }
        private int fkIdHorario;

        public int FkIdHorario
        {
            get { return fkIdHorario; }
            set { fkIdHorario = value; }
        }
        public List<MGrupo> listarTodos()
        {
            return control.listarTodos();
        }
        public int modificar()
        {
            return control.modificar(this);
        }
        public int guardar()
        {
            return control.guardar(this);
        }
        public int eliminar()
        {
            return control.eliminar(this);
        }
       
    }
}

