using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    public class EquipoDAO
    {

        //Obtener Lsita Equipos
        public static List<Equipo> obtenerEquipo(int idEquipoBUS)
        {
            List<Equipo> listaEquipos = new List<Equipo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblEquipo where idEquipo = " + idEquipoBUS + "";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idEquipo = datos.GetInt32(0);
                    string pais = datos.GetString(1);
                    int posicion = datos.GetInt32(2);
                    int partidosJugados = datos.GetInt32(3);
                    int partidosGanados = datos.GetInt32(4);
                    int partidosPerdidos = datos.GetInt32(5);
                    int partidosEmpatados = datos.GetInt32(6);
                    int golesFavor = datos.GetInt32(7);
                    int goleContra = datos.GetInt32(8);
                    int puntos = datos.GetInt32(9);

                    Equipo equipoAux = new Equipo(idEquipo, pais, posicion, partidosJugados, partidosGanados, partidosPerdidos, partidosEmpatados, golesFavor, goleContra, puntos);
                    listaEquipos.Add(equipoAux);
                }
            }
            return listaEquipos;
        }

        public static List<Equipo> infoEquipo( )
        {
            List<Equipo> listaEquipos = new List<Equipo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblEquipo  ";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idEquipo = datos.GetInt32(0);
                    string pais = datos.GetString(1);
                    int posicion = datos.GetInt32(2);
                    int partidosJugados = datos.GetInt32(3);
                    int partidosGanados = datos.GetInt32(4);
                    int partidosPerdidos = datos.GetInt32(5);
                    int partidosEmpatados = datos.GetInt32(6);
                    int golesFavor = datos.GetInt32(7);
                    int goleContra = datos.GetInt32(8);
                    int puntos = datos.GetInt32(9);

                    Equipo equipoAux = new Equipo(idEquipo, pais, posicion, partidosJugados, partidosGanados, partidosPerdidos, partidosEmpatados, golesFavor, goleContra, puntos);
                    listaEquipos.Add(equipoAux);
                }
            }
            return listaEquipos; 
        }

        //Ingresar Equipo 
        public static void ingresarEquipo(Equipo equip)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "inert into Equipo (idEquipo,pais,posicion, partidosJugados,partidosGanados,partidosPerdidos,partidosEmpatados,golesFavor,golesContra,puntos)" +
                "values(" + equip.Id + ",'" + equip.Pais + "'," + equip.Posicion + "," + equip.PartidosJugados + "," + equip.PartidosGanados + "," + equip.PartidosPerdidos + "," + equip.PartidosEmpatados + "," + equip.GolesFavor + "," + equip.GolesContra + "," + equip.Puntos + ")";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }



      

        internal static void editarEquipo(int partidosJugados1, int partidosGanados1, int partidosPerdidos1, int partidosEmpatados1, int golesFavor1, int goleContra1, int puntos1, int e1)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblEquipo set partidosJugados = '"+partidosJugados1+"', partidosGanados ='"+partidosGanados1+"', partidosPerdidos = '"+partidosPerdidos1+"',partidosEmpatados ='"+partidosEmpatados1+"',golesFavor = '"+golesFavor1+"',golesContra = '"+goleContra1+"',puntos = '"+puntos1+"'  where idEquipo = '"+e1+"'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }


        internal static List<Equipo> buscarEquipoPorID1(Partido partido)
        {
            List<Equipo> lsEquipo1= new List<Equipo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT  * FROM tblEquipo where idEquipo= '" + partido.IdEquipo1 + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idEquipo = datos.GetInt32(0);
                    string pais = datos.GetString(1);
                    int posicion = datos.GetInt32(2);
                    int partidosJugados = datos.GetInt32(3);
                    int partidosGanados = datos.GetInt32(4);
                    int partidosPerdidos = datos.GetInt32(5);
                    int partidosEmpatados = datos.GetInt32(6);
                    int golesFavor = datos.GetInt32(7);
                    int goleContra = datos.GetInt32(8);
                    int puntos = datos.GetInt32(9);

                    Equipo equipoAux = new Equipo(idEquipo, pais, posicion, partidosJugados, partidosGanados, partidosPerdidos, partidosEmpatados, golesFavor, goleContra, puntos);
                    lsEquipo1.Add(equipoAux);
                }
            }
            return lsEquipo1;
        }

        internal static List<Equipo> buscarEquipoPorID2(Partido partido)
        {
            List<Equipo> lsEquipo1 = new List<Equipo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT  * FROM tblEquipo where idEquipo= '" + partido.IdEquipo2 + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idEquipo = datos.GetInt32(0);
                    string pais = datos.GetString(1);
                    int posicion = datos.GetInt32(2);
                    int partidosJugados = datos.GetInt32(3);
                    int partidosGanados = datos.GetInt32(4);
                    int partidosPerdidos = datos.GetInt32(5);
                    int partidosEmpatados = datos.GetInt32(6);
                    int golesFavor = datos.GetInt32(7);
                    int goleContra = datos.GetInt32(8);
                    int puntos = datos.GetInt32(9);

                    Equipo equipoAux = new Equipo(idEquipo, pais, posicion, partidosJugados, partidosGanados, partidosPerdidos, partidosEmpatados, golesFavor, goleContra, puntos);
                    lsEquipo1.Add(equipoAux);
                }
            }
            return lsEquipo1;
        }
    }
}
