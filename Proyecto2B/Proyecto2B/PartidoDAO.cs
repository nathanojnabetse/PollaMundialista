using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    public class PartidoDAO
    {

        //Obtener Partidos
        public static List<Partido> obtenerPartido()
        {
            List<Partido> listaPartidos = new List<Partido>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblPartido";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {

                    int idPartido = datos.GetInt32(0);
                    Console.WriteLine( idPartido );
                    int idEquipo1 = datos.GetInt32(1);
                    Console.WriteLine(idEquipo1);
                    int idEquipo2 = datos.GetInt32(2);
                    Console.WriteLine(idEquipo2);
                    int idMarcador = datos.GetInt32(3);
                    Console.WriteLine(idMarcador);
                    //DateTime hora = datos.GetDateTime(4);
                    //Console.WriteLine(hora);
                    //DateTime fecha = datos.GetDateTime(5);
                    //Console.WriteLine(fecha);
                    string estadio = datos.GetString(6);
                    Console.WriteLine(estadio);
                    string estado = datos.GetString(7);
                    Console.WriteLine(estado);


                    //Partido partidoAux = new Partido(idPartido, idEquipo1, idEquipo2, idMarcador, hora, fecha, estadio, estado);
                    Partido partidoAux = new Partido(idPartido, idEquipo1, idEquipo2, idMarcador, estadio, estado);
                    listaPartidos.Add(partidoAux);
                }
            }
            return listaPartidos;
        }

        public static List<Partido> buscarPartido(int idbuscarP)
        {
            List<Partido> listaPartidos = new List<Partido>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblPartido where idPartido = "+idbuscarP+"";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {

                    int idPartido = datos.GetInt32(0);
                   // Console.WriteLine(idPartido);
                    int idEquipo1 = datos.GetInt32(1);
                    //Console.WriteLine(idEquipo1);
                    int idEquipo2 = datos.GetInt32(2);
                    //Console.WriteLine(idEquipo2);
                    int idMarcador = datos.GetInt32(3);
                    //Console.WriteLine(idMarcador);
                    //DateTime hora = datos.GetDateTime(4);
                    //Console.WriteLine(hora);
                    //DateTime fecha = datos.GetDateTime(5);
                    //Console.WriteLine(fecha);
                    string estadio = datos.GetString(6);
                    //Console.WriteLine(estadio);
                    string estado = datos.GetString(7);
                    //Console.WriteLine(estado);


                    //Partido partidoAux = new Partido(idPartido, idEquipo1, idEquipo2, idMarcador, hora, fecha, estadio, estado);
                    Partido partidoAux = new Partido(idPartido, idEquipo1, idEquipo2, idMarcador, estadio, estado);
                    listaPartidos.Add(partidoAux);
                }
            }
            return listaPartidos;
        }

        //Eliminar Partido
        public static void eliminarPartido(Partido part)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "delete from Partido where idPartido=" + part.IdPartido + ";";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        //Editar Partido
        public static void jugarPartido(int idPartido)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblPartido set estado = 'j' where idPartido = '" + idPartido + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        public static void EditarPartido(int idEquipo1, int idEquipo2, int idPartido)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblPartido set idEquipo1 = '"+idEquipo1+"', idEquipo2 = '"+idEquipo2+"' where idMarcador='"+idPartido+"'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        public static void EditarPartidoE1(int idEquipo1, int idPartido)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblPartido set idEquipo1 = '"+idEquipo1+"' where idMarcador = '"+idPartido+"'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        public static void EditarPartidoE2( int idEquipo2, int idPartido)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblPartido set idEquipo2 = '" + idEquipo2 + "' where idMarcador = '" + idPartido + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        public static List<Partido> obtenerPartidoID(int idbuscarP)
        {
            List<Partido> listaPartidos = new List<Partido>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblPartido where idPartido = " + idbuscarP + "";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {

                    int idPartido = datos.GetInt32(0);
                    Console.WriteLine(idPartido);
                    int idEquipo1 = datos.GetInt32(1);
                    Console.WriteLine(idEquipo1);
                    int idEquipo2 = datos.GetInt32(2);
                    Console.WriteLine(idEquipo2);
                    int idMarcador = datos.GetInt32(3);
                    Console.WriteLine(idMarcador);
                    //DateTime hora = datos.GetDateTime(4);
                    DateTime fecha = datos.GetDateTime(5);
                    string estadio = datos.GetString(6);
                    string estado = datos.GetString(7);
                    Console.WriteLine(estado);


                    //Partido partidoAux = new Partido(idPartido, idEquipo1, idEquipo2, idMarcador, hora, fecha, estadio, estado);
                    Partido partidoAux = new Partido(idPartido, idEquipo1, idEquipo2, idMarcador, estadio, estado);
                    listaPartidos.Add(partidoAux);
                }
            }
            return listaPartidos;
        }




    }
}
