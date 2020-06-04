using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
     public class MarcadorDAO
    {

        //Actualizar Marcador
        public static List<Marcador> obtenerMarcador()
        {
            List<Marcador> listaMarcador = new List<Marcador>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblMarcador";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idMarcador = datos.GetInt32(0);
                    int puntosE1 = datos.GetInt32(1);
                    int puntosE2 = datos.GetInt32(2);

                    Marcador MarcadorAux = new Marcador(idMarcador, puntosE1, puntosE2);
                    
                    listaMarcador.Add(MarcadorAux);
                }
            }
           
            return listaMarcador;
        }



        public static void ingresarMarcador(int idMArcador, int p1, int p2)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblMarcador set puntosE1 = '"+p1+"', puntosE2 = '"+p2+"' where idMarcador='"+idMArcador+"'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery(); 
        }

        public static List<Marcador> obtenerMarcadorID(int idMarcador)
        {
            List<Marcador> listaMarcador = new List<Marcador>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblMarcador where idMarcador = " + idMarcador + "";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int puntosE1 = datos.GetInt32(1);
                    int puntosE2 = datos.GetInt32(2);

                    Marcador MarcadorAux = new Marcador(idMarcador, puntosE1, puntosE2);

                    listaMarcador.Add(MarcadorAux);
                }
            }
            return listaMarcador;
        }

     }





}

