using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace Proyecto2B
{
    public class UsuarioDAO
    {

        public static void sumarPuntos(Usuario user)
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblUsuario set puntosAcumulados = " + user.PuntoAcumulados   +
       
                "where idUsuario=" + user.Id + ";";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        //Obtener Lista
        public static List<Usuario> obtenerUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select *  from tblUsuario";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idUsuario = datos.GetInt32(0);
                    string nombreUsuario = datos.GetString(1);
                    string apellidoUsuario = datos.GetString(2);
                    string correo = datos.GetString(3);
                    string contrasena = datos.GetString(4);
                    string genero = datos.GetString(5);
                    string pais = datos.GetString(6);
                    DateTime fechaNacimiento = datos.GetDateTime(7);
                    int puntosAcumulados = datos.GetInt32(8);

                    Usuario usuariAux = new Usuario(idUsuario, nombreUsuario, apellidoUsuario,correo,contrasena, genero, pais, fechaNacimiento, puntosAcumulados);
                    listaUsuario.Add(usuariAux);

                }
            }
            return listaUsuario; 
        }

        //Insertar nuevo Usuario 
        public static void insertarUsuario(Usuario user) 
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            //string query = "insert into Usuario (idUsuario,nombreUsuario,apellidoUsuario,correo,genero,pais,fechaNacimiento,punntosAcumulados)" +
            //    "values("+user.Id+", '"+user.Nombre+"','"+user.Apellido+"', '"+user.Correo+"','"+user.Genero+"','"+user.Pais+"','"+user.FechaNacimiento+"',"+user.PuntoAcumulados+" )";
            string query = "exec sp_InsertarUsuario '" + user.Nombre + "','" + user.Apellido + "','" + user.Correo + "','" + user.Contrasena + "','" + user.Genero + "','" + user.Pais + "','" + user.FechaNacimiento+ "',0";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();


        }

        //Eliminar   Usuario 
        public static void eliminarUsuario(Usuario user)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "delete from Usuario where idUsuario =" + user.Id + ";";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        //Modificar Usuario
        public static void modificarUsuario(Usuario user)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update tblUsuario set nombreUser= '" + user.Nombre + "', apellidoUser = '" + user.Apellido + "',correo= '" + user.Correo + "', contrasena = '" + user.Contrasena + "', genero = '" + user.Genero + "', pais='" + user.Pais + "'" +
                "where idUsuario=" + user.Id + ";";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        public static void ingresarprimerUsuarioGrupo(Usuario user, Grupo grupo)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "exec sp_Ingresar_Usuario_a_Grupo "+user.Id+","+grupo.Reglas.Id+"";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }



        public static void unionAgrupo(Usuario user, Grupo grupo)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "exec sp_Ingresar_Usuario_a_Grupo " + user.Id + "," + grupo.Id+ "";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        public static List<Usuario> buscarAdmin(int idGrupo)
        {

            List<Usuario> listaUsuario = new List<Usuario>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select top 1 * from tblUser_Grupo  where idGrupo = " + idGrupo+" order by idUser_Grupo asc";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idUsuario = datos.GetInt32(1);
                    
                    Usuario usuariAux = new Usuario(idUsuario);
                    listaUsuario.Add(usuariAux);

                }
            }
            return listaUsuario;
        }

        internal static List<Usuario> buscarUserPorID(UserGrupo userGrupo)
        {
            List<Usuario> lsUsuarios= new List<Usuario>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT  * FROM tblUsuario where idUsuario = '" + userGrupo.IdUsuario + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idUsuario = datos.GetInt32(0);
                    string nombreUsuario = datos.GetString(1);
                    string apellidoUsuario = datos.GetString(2);
                    string correo = datos.GetString(3);
                    string contrasena = datos.GetString(4);
                    string genero = datos.GetString(5);
                    string pais = datos.GetString(6);
                    DateTime fechaNacimiento = datos.GetDateTime(7);
                    int puntosAcumulados = datos.GetInt32(8);

                   Usuario userAux = new Usuario(idUsuario, nombreUsuario, apellidoUsuario, correo, contrasena, genero, pais, fechaNacimiento, puntosAcumulados);
                    lsUsuarios.Add(userAux);
                }
            }
            return lsUsuarios;
        }
    }
}
