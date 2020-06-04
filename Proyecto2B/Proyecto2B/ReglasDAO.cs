using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    public class ReglasDAO
    {
        public static List<Reglas> obtenerReglas()
        {
            List<Reglas> listaReglas = new List<Reglas>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblReglas";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idReglas = datos.GetInt32(0);
                    int marcadorExactoAcertado = datos.GetInt32(1);
                    int ganadorAcertado = datos.GetInt32(2);
                    int golAcertado = datos.GetInt32(3);
                    int bonoOctavos = datos.GetInt32(4);
                    int bonoCuartos = datos.GetInt32(5);
                    int bonoSemi = datos.GetInt32(6);
                    int bonoFinal = datos.GetInt32(7);
                    decimal valorApuesta = datos.GetDecimal(8);
                    decimal primerLugar = datos.GetDecimal(9);
                    decimal segundoLugar = datos.GetDecimal(10);
                    decimal tercerLugar = datos.GetDecimal(11);

                    Reglas reglas = new Reglas(idReglas, marcadorExactoAcertado, ganadorAcertado, golAcertado, bonoOctavos, bonoCuartos, bonoSemi, bonoFinal, valorApuesta, primerLugar, segundoLugar, tercerLugar);
                    listaReglas.Add(reglas);
                }
            }
            return listaReglas;

        }

        //Crear Reglas 
        public static void crearReglas(Reglas reglas)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "exec sp_InsertarReglas "+reglas.MarcadorExactoAcertado+","+reglas.GanadorAcertado+ ","+ reglas.GolAcertado+ ","+ reglas.BonoOctavos+ ","+ reglas.BonoCuartos+ ","+ reglas.BonoSemi+ ","+ reglas.Bonofinal+ ","+ reglas.ValorApuesta+ ","+ reglas.PrimerLugar+ ","+ reglas.SegundoLuar+ ","+ reglas.TercerLugar+ "";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        
        //Editar Reglas 
        public static void editarReglas(Reglas reglas)
        {
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "update Reglas set marcadorExactoAcertado =" + reglas.MarcadorExactoAcertado + ", ganadorAcertado = "+reglas.GanadorAcertado+", golAcertado= "+reglas.GolAcertado+", bonoOctavos ="+reglas.BonoOctavos+",bonoCuartos ="+reglas.BonoCuartos+",bonoSemi="+reglas.BonoSemi+",bonoFinal="+reglas.Bonofinal+",primerLugar="+reglas.PrimerLugar+",segundoLugar="+reglas.SegundoLuar+",tercerLugar="+reglas.TercerLugar+"" +
                "where idReglas=" + reglas.Id + ";";
            SqlCommand command = new SqlCommand(query, conexion);
            command.ExecuteNonQuery();
        }

        //Editar Reglas 
        public static List<Reglas> ultimoIngresado()
        {
            List<Reglas> listaReglas = new List<Reglas>();
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "SELECT TOP 1 * FROM tblReglas ORDER BY idReglas DESC";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idReglas = datos.GetInt32(0);
                    int marcadorExactoAcertado = datos.GetInt32(1);
                    int ganadorAcertado = datos.GetInt32(2);
                    int golAcertado = datos.GetInt32(3);
                    int bonoOctavos = datos.GetInt32(4);
                    int bonoCuartos = datos.GetInt32(5);
                    int bonoSemi = datos.GetInt32(6);
                    int bonoFinal = datos.GetInt32(7);
                    decimal valorApuesta = datos.GetDecimal(8);
                    decimal primerLugar = datos.GetDecimal(9);
                    decimal segundoLugar = datos.GetDecimal(10);
                    decimal tercerLugar = datos.GetDecimal(11);

                    Reglas reglas = new Reglas(idReglas, marcadorExactoAcertado, ganadorAcertado, golAcertado, bonoOctavos, bonoCuartos, bonoSemi, bonoFinal, valorApuesta, primerLugar, segundoLugar, tercerLugar);
                    listaReglas.Add(reglas);
                }
            }
            return listaReglas;
        }

        public static List<Reglas> obtenerReglasID(int id)
        {

                List<Reglas> listaReglas = new List<Reglas>();
                SqlConnection conexion = BaseDatos.obtenerConexion();
                string query = "select * from tblReglas where idReglas =" + id;
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader datos = command.ExecuteReader();


            if (datos.HasRows)
            {
                while (datos.Read())
                {
                    int idReglas = datos.GetInt32(0);
                    int marcadorExactoAcertado = datos.GetInt32(1);
                    int ganadorAcertado = datos.GetInt32(2);
                    int golAcertado = datos.GetInt32(3);
                    int bonoOctavos = datos.GetInt32(4);
                    int bonoCuartos = datos.GetInt32(5);
                    int bonoSemi = datos.GetInt32(6);
                    int bonoFinal = datos.GetInt32(7);
                    decimal valorApuesta = datos.GetDecimal(8);
                    decimal primerLugar = datos.GetDecimal(9);
                    decimal segundoLugar = datos.GetDecimal(10);
                    decimal tercerLugar = datos.GetDecimal(11);

                    Reglas reglas = new Reglas(idReglas, marcadorExactoAcertado, ganadorAcertado, golAcertado, bonoOctavos, bonoCuartos, bonoSemi, bonoFinal, valorApuesta, primerLugar, segundoLugar, tercerLugar);
                    listaReglas.Add(reglas);
                }
            }
            return listaReglas;

        }
    }



    
}
