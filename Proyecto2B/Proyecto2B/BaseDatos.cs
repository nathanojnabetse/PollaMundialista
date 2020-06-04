using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto2B
{
    public class BaseDatos
    {
        public static SqlConnection obtenerConexion()
        {
            //SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EBS5NHQ\SQLEXPRESS;Initial Catalog=PollaMundialista;Integrated Security=True");
            SqlConnection conexion = new SqlConnection(@"Data Source=JONA\SQLEXPRESS;Initial Catalog=PollaMundialista;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
          
        
    }
}
