using Escuela.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Autor: Jennifer Serrano Santiago
 * Brayan Uriel Hernandez Gonzalez
 * 09/07/14
 */
namespace Escuela.Control
{
     public  class CCarrera
    {
        /*
        * Descripción: Esté método sirve para que se lleve acabo la inserccion de los datos
        * de una carrera, devolviendo asi un entero en caso de que la insercción allá sido 
        * correcta de caso contrario devolvera un cero.
        * Parámetro: Recibe como parametro un modelo de tipo MCarrera.
        */
         public int guardar(MCarrera pCarrera)
         {
             string cadena = string.Format("INSERT  INTO CARRERA VALUES({0},'{1}','{2}')", pCarrera.Numero, pCarrera.Planes, pCarrera.Nombre);

             if (this.existe(pCarrera))
             {

                 return 0;
             }
             else
             {
                 return Conexion.inserta(cadena);
             }
         }

         /*
          * Descripción: Esté método sirve para comprobar que exista dicha carrera buscandola 
          * por su codigo. Retornara verdadero en caso de que la carrera exista, de caso 
          * contrario retornara falso.
          * Parámetro: Recibe como parametro un modelo de tipo MCarrera.
          */

         public bool existe(MCarrera pCarrera)
         {
             string cadena = string.Format("SELECT * FROM CARRERA WHERE CA_IDCARRERA={0}", pCarrera.Codigo);
             SqlDataReader leer = Conexion.consulta(cadena);
             bool resp = leer.HasRows;
             leer.Close();
             return resp;

         }
         /*
        * Descripción: Esté método sirve para que se lleve acabo la modificación de los datos
        * de una carrera, devolviendo asi un entero en caso de que la modificación allá sido 
        * correcta de caso contrario devolvera un cero.
        * Parámetro: Recibe como parámetro un modelo de tipo MCarrera.
        */
         public int modificar(MCarrera pCarrera)
         {
             string cadena = string.Format("UPDATE CARRERA SET CA_NUMCARRERA={0},CA_PLANEST='{1}',CA_NOMBRECARRERA='{2}' WHERE CA_IDCARRERA={3}", pCarrera.Numero, pCarrera.Planes, pCarrera.Nombre, pCarrera.Codigo);
             return Conexion.modifica(cadena);
         }

         /*
        * Descripción: Esté método sirve para que se lleve acabo la consulta de todos los datos
        * que existan en la tabla carrera, devolviendo asi una lista de todos los datos de dicha tabla.
        */
         public List<MCarrera> consultaTodo()
         {
             List<MCarrera> lista = new List<MCarrera>();
             string cadena = "SELECT * FROM CARRERA";
            SqlDataReader leer = Conexion.consulta(cadena);
             while (leer.Read())
             {
                 MCarrera nuevo = new MCarrera();

                 nuevo.Codigo = leer.GetInt32(0);
                 nuevo.Numero = leer.GetInt32(1);
                 nuevo.Planes = leer.GetString(2);
                 nuevo.Nombre = leer.GetString(3);
                 lista.Add(nuevo);


             }
             return lista;
         }
         /*
        * Descripción: Esté método sirve para que se lleve acabo la eliminación de los datos
        * de una carrera de acuerdo a su codigo (ID), devolviendo asi un entero en caso de que la elimnación allá sido 
        * correcta de caso contrario devolvera un cero.
        * Parámetro: Recibe como parámetro un modelo de tipo MCarrera.
        */
         public int eliminar(MCarrera pCarrera)
         {
             string cadena = string.Format("DELETE FROM CARRERA WHERE CA_IDCARRERA = {0} ", pCarrera.Codigo);
             if (this.existe(pCarrera))
             {
                 return Conexion.elimina(cadena);

             }
             else
             {
                 return 0;
             }
         }
         public string buscaCarrera(string llaveCarrera)
         {
             string cadena = String.Format("SELECT CA_NOMBRECARRERA FROM CARRERA WHERE CA_IDCARRERA= {0}", llaveCarrera);
             SqlDataReader leer = Conexion.consulta(cadena);
             string carrera = "";
             while (leer.Read())
             {
                 carrera = leer.GetString(0);
             }
             return carrera;
         }
       
    }
}
