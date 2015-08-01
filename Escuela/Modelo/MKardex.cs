using Escuela.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Autores: Hilda Mireya Calva Chavarria
 * Juan Manuel Dorantes Pérez
 * Mónica Yesenia Viveros Bautista
 * Fecha: 09/07/2014
 */
namespace Escuela.Modelo
{
   public class MKardex
    {
       CKardex control = new CKardex();

       private int fkIdinscribir;

       public int FkIdinscribir
       {
           get { return fkIdinscribir; }
           set { fkIdinscribir = value; }
       }
       private int unidad;

       public int Unidad
       {
           get { return unidad; }
           set { unidad = value; }
       }
       private int indicador;

       public int Indicador
       {
           get { return indicador; }
           set { indicador = value; }
       }
       private double calificacion;

       public double Calificacion
       {
           get { return calificacion; }
           set { calificacion = value; }
       }
       public List<MKardex> listarTodos()
       {
           return control.listarTodos();
       }
    }
}
