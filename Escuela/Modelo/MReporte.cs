using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Autores: Leidy Laura
 * Shanary de Jesus Martinez Chacon
 * Carlo Ivan Estrada Romero
 * */
namespace Escuela.Modelo
{
   public class MReporte
    {
        CReporte control = new CReporte();

        private int idReporte;

        public int IdReporte
        {
            get { return idReporte; }
            set { idReporte = value; }
        }

        private Int16 Desertor;

        public Int16 Desertor1
        {
            get { return Desertor; }
            set { Desertor = value; }
        }
        private String Dx;

        public String Dx1
        {
            get { return Dx; }
            set { Dx = value; }
        }
        private DateTime Fecha;

        public DateTime Fecha1
        {
            get { return Fecha; }
            set { Fecha = value; }
        }
        private int fkTipo;

        public int FkTipo
        {
            get { return fkTipo; }
            set { fkTipo = value; }
        }
        private String Acciones;

        public String Acciones1
        {
            get { return Acciones; }
            set { Acciones = value; }
        }
        private int fkIdInscribir;

        public int FkIdInscribir
        {
            get { return fkIdInscribir; }
            set { fkIdInscribir = value; }
        }

        public MReporte() { }

        public int guardar()
        {
            return control.guardar(this);
        }
        public List<MReporte> listarTodos()
        {
            return control.listarTodo();
        }
    }
}
