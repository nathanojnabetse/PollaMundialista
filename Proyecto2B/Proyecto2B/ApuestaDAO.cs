using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    public class ApuestaDAO
    {
        public static void ingresarApuesta(int idGrupo, int idUsuario, int idPartido, int p1, int p2)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            //string query = "exec sp_CrearApuesta"+idGrupo + "," + idUsuario+ "," + idPartido+ "," + p1+ "," + p2+ ";";
            string query = "insert into tblApuesta( idGrupo,idUsuario,idPArtido,puntos1,puntos2)" +
               "values(" + idGrupo + "," + idUsuario + "," + idPartido + "," + p1 + "," + p2 + ")";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }
    }
}
