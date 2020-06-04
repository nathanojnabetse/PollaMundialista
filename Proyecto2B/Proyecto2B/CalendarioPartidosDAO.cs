using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    class CalendarioPartidosDAO
    {
        public static List<CalendarioPartidos> obtenerTodoslospartidos()
        {
            List<CalendarioPartidos> lsCalendario = new List<CalendarioPartidos>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select *from vw_Partidos";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    Console.WriteLine("a");
                    int idPartido = datos.GetInt32(0);
                    Console.WriteLine("b");
                    string p1 = datos.GetString(1);
                    Console.WriteLine("c");
                    int pt1 = datos.GetInt32(2);
                    Console.WriteLine("d");
                    string p2 = datos.GetString(3);
                    Console.WriteLine("e");
                    int pt2 = datos.GetInt32(4);
                    Console.WriteLine("f");
                    Console.WriteLine("g");
                    DateTime fecha = datos.GetDateTime(5);
                    Console.WriteLine("h");
                    string estadio = datos.GetString(6);
                    Console.WriteLine("i");

                    CalendarioPartidos calendario = new CalendarioPartidos(idPartido,p1,pt1,p2,pt2,fecha,estadio);

                    lsCalendario.Add(calendario);
                }
            }
            return lsCalendario;
        }

    }
}
