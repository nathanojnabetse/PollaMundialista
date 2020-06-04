using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    class FaseDAO
    {


        public static void ClasificarFase(int idEquipo, int idFasegr )
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();

            string query = "update tblEquipo_Fase set idEquipo = '"+ idEquipo +"'  where idEquipoFase = '"+idFasegr +"'";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();


        }


        

        public static List<int> ObtenerOctavos()
        {
            List<int> lsIdSeleccion = new List<int>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select tblFase.idFase, tblFase.nombreFase, tblEquipo_Fase.idEquipo from tblFase inner join tblEquipo_Fase on tblFase.idFase = tblEquipo_Fase.idFase where tblFase.idFase = 2";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idSeleccion = datos.GetInt32(2);
                    

                    
                    lsIdSeleccion.Add(idSeleccion);

                }
            }
            return lsIdSeleccion;
        }


    }
}
