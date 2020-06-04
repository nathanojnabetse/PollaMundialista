using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Proyecto2B
{
    class GrupoDAO
    {

        public static List<Grupo> buscarGrupo(string codigoBUS)
        {
            List<Grupo> lsGrupos = new List<Grupo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT  * FROM tblGrupo where codigo = '"+codigoBUS+"'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string codigo = datos.GetString(2);
                    int idReglas = datos.GetInt32(3);

                    Grupo auxgrupo = new Grupo(id, nombre, codigo, idReglas);
                    lsGrupos.Add(auxgrupo);
                }
            }
 
            return lsGrupos;
        }

        internal static List<Grupo> buscarGrupoporID(UserGrupo userGrupo)
        {
            List<Grupo> lsGruposPertenece = new List<Grupo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT  * FROM tblGrupo where idGrupo = '" + userGrupo.IdGrupo + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string codigo = datos.GetString(2);
                    int idReglas = datos.GetInt32(3);

                    Grupo grupoAux = new Grupo(id, nombre, codigo, idReglas);
                    lsGruposPertenece.Add(grupoAux);
                }
            }
            return lsGruposPertenece;
        }

        internal static List<Grupo> obtenerGrupos( )
        {
            List<Grupo> lsGrupos  = new List<Grupo>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT  * FROM tblGrupo ";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int id = datos.GetInt32(0);
                    string nombre = datos.GetString(1);
                    string codigo = datos.GetString(2);
                    int idReglas = datos.GetInt32(3);

                    Grupo grupoAux = new Grupo(id, nombre, codigo, idReglas);
                    lsGrupos .Add(grupoAux);
                }
            }
            return lsGrupos ;
        }

        public static void crearGrupo(Grupo grupo)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "exec sp_InsertarGrupo '" + grupo.Nombre + "','" + grupo.Codigo + "'," + grupo.Reglas.Id + "";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }


       
    }
}
