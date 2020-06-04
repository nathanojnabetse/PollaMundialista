using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proyecto2B
{
    class UserGrupoDAO
    {
        //public static List<UserGrupo> gruposAlosQuePertenezco(int _idUsuario)
        //{
        //    List<UserGrupo> lsGrupos = new List<UserGrupo>();
        //    SqlConnection conexion = BaseDatos.obtenerConexion();
        //    string query = "select * from tblUser_Grupo  where idUsuario = " + _idUsuario + " ";
        //    SqlCommand command = new SqlCommand(query, conexion);
        //    SqlDataReader datos = command.ExecuteReader();

        //    if (datos.HasRows)
        //    {
        //        while (datos.Read())
        //        {
        //            int idUser_Grupo = datos.GetInt32(0);
        //            int idUsuario = datos.GetInt32(1);
        //            int idGrupo = datos.GetInt32(2);

        //            UserGrupo auxuser = new UserGrupo(idUser_Grupo, idUsuario, idGrupo);
        //            lsGrupos.Add(auxuser);
        //        }
        //    }

        //    Console.WriteLine();
        //    return lsGrupos;
        //}
        public static List<UserGrupo> gruposAlosQuePertenezco(Usuario usuario)
        {
            List<UserGrupo> lsGrupos = new List<UserGrupo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblUser_Grupo  where idUsuario = " + usuario.Id + " ";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idUser_Grupo = datos.GetInt32(0);
                    int idUsuario = datos.GetInt32(1);
                    int idGrupo = datos.GetInt32(2);

                    UserGrupo auxuser = new UserGrupo(idUser_Grupo, idUsuario, idGrupo);
                    lsGrupos.Add(auxuser);
                }
            }

            return lsGrupos;
        }

        public static List<UserGrupo> PersonasDelGrupo(Grupo grupo)
        {
            List<UserGrupo> lsMiembros = new List<UserGrupo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblUser_Grupo  where idGrupo = " + grupo.Id + " ";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idUser_Grupo = datos.GetInt32(0);
                    int idUsuario = datos.GetInt32(1);
                    int idGrupo = datos.GetInt32(2);

                    UserGrupo auxuser = new UserGrupo(idUser_Grupo, idUsuario, idGrupo);
                    lsMiembros.Add(auxuser);
                }
            }

            return lsMiembros;
        }





    }
}
