using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 AUTOR: ANTONIO QUINTANAR VIVEROS
 * RANDY GAEL PEREZ MONTOÑA
 * BRENDA GACHUZ SANTIAGO
 * FECHA : 09/07/2014 
 * 
 */
namespace Escuela.Modelo
{
   public class MEvaluar
    {
       CEvaluar control = new CEvaluar();
       private decimal fkidindicador;

       public decimal Fkidindicador
       {
           get { return fkidindicador; }
           set { fkidindicador = value; }
       }

     
       private String fkClaveMateria;

       public String FkClaveMateria
       {
           get { return fkClaveMateria; }
           set { fkClaveMateria = value; }
       }
       private int fkIdPeriodo;

       public int FkIdPeriodo
       {
           get { return fkIdPeriodo; }
           set { fkIdPeriodo = value; }
       }
       private int fkIdCarrera;

       public int FkIdCarrera
       {
           get { return fkIdCarrera; }
           set { fkIdCarrera = value; }
       }
       private decimal unidad;

       public decimal Unidad
       {
           get { return unidad; }
           set { unidad = value; }
       }
       private int parcial;

       public int Parcial
       {
           get { return parcial; }
           set { parcial = value; }
       }
       private decimal porcentaje;

       public decimal Porcentaje
       {
           get { return porcentaje; }
           set { porcentaje = value; }
       }

       public MEvaluar()
       {

       }

       public int guardar()
       {
           return control.guardar(this);
       }
       public List<MEvaluar> listaTodos()
       {
           return control.listaTodos();
       }
       public int modificar()
       {
           return control.modificar(this);
       }
       public int eliminar()
       {
           return control.eliminar(this);
       }
    }
}
