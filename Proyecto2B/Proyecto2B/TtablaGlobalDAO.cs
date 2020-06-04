using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proyecto2B
{
    class TtablaGlobalDAO
    {
        public static List<TtablaGlobal> tablaGlobaldePosiciones()
        {
            List<TtablaGlobal> lsPosiciones = new List<TtablaGlobal>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select top 32 *from tblEquipo  order by partidosJugados desc, puntos desc,(golesFavor + golesContra) desc";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {

                    string pais = datos.GetString(1);
                    int partidosJugados = datos.GetInt32(3);
                    int partidosGanados = datos.GetInt32(4);
                    int partidosPerdidos = datos.GetInt32(5);
                    int partidosEmpatados = datos.GetInt32(6);
                    int golesFavor = datos.GetInt32(7);
                    int golContra = datos.GetInt32(8);
                    int golDiferencia = golesFavor + golContra;
                    int puntos = datos.GetInt32(9);

                    TtablaGlobal aux = new TtablaGlobal(pais, partidosJugados, partidosGanados, partidosPerdidos, partidosEmpatados, golesFavor, golContra, golDiferencia, puntos);

                    lsPosiciones.Add(aux);
                    
                }
            }
            return lsPosiciones;
        }



    }
}
