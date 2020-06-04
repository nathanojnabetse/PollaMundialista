using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proyecto2B
{
    class ClasificadosDAO
    {

        public static List<Clasificados> obtenerCladificados()
        {
            List<Clasificados> lsClasificados = new List<Clasificados>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select *from vw_GruposPosiciones";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    string idGrupoEquipos = datos.GetString(0);
                    string Equipo1 = datos.GetString(1);
                    int puntosEQ1 = datos.GetInt32(2);
                    string Equipo2 = datos.GetString(3); ;
                    int puntosEQ2 = datos.GetInt32(4);
                    string Equipo3 = datos.GetString(5); ;
                    int puntosEQ3 = datos.GetInt32(6);
                    string Equipo4 = datos.GetString(7); ;
                    int puntosEQ4 = datos.GetInt32(8);

                    Clasificados clasificadosAux = new Clasificados(idGrupoEquipos, Equipo1, puntosEQ1, Equipo2, puntosEQ2, Equipo3, puntosEQ3, Equipo4, puntosEQ4);
                    lsClasificados.Add(clasificadosAux);


                }
            }
            return lsClasificados;
        }

    }
}
