using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;







namespace Proyecto2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////Verificar correo
        public static bool IsValidEmail(string strIn)
        {

            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            SqlConnection conexion = BaseDatos.obtenerConexion();
            string query = "select * from tblUsuario where correo = '" + txtUsuario.Text + "'";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader datos = command.ExecuteReader();

            Usuario usuarioLogin = new Usuario();

            if (IsValidEmail(txtUsuario.Text) == false)
            {
                txtUsuario.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Correo Invalido");
            }
            else
            {
                while (datos.Read())
                {
                    Console.WriteLine(datos.GetString(4));
                    Console.WriteLine("hola: " + query);



                    if (txtPassword.Text == datos.GetString(4))
                    {
                        if ((datos.GetString(3) == "admi@pollamundialista.com") && (txtPassword.Text == datos.GetString(4)))
                        {
                            frmAdministrador frmAdministrador = new frmAdministrador();
                            frmAdministrador.Show();
                        }
                        else
                        {
                            List<Usuario> lsAuxUsuarios = new List<Usuario>();
                            lsAuxUsuarios = UsuarioDAO.obtenerUsuario();
                            foreach(var iter in lsAuxUsuarios)
                            {
                                if (iter.Id == datos.GetInt32(0))
                                {
                                    usuarioLogin = iter;
                                }
                            }
                           
                            frmUsuario frmUsuario = new frmUsuario(usuarioLogin);
                            frmUsuario.Usuario = usuarioLogin;
                            frmUsuario.Show();
                        }
                        MessageBox.Show("ACCESO CORRECTO");
                    }
                    else
                    {
                       
                        MessageBox.Show("DATOS NO COINCIDEN");
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                    }



                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "1234";
            txtUsuario.Text = "cesarin@hotmail.com";
           // txtUsuario.Text = "admi@pollamundialista.com";
        }
    }
}
