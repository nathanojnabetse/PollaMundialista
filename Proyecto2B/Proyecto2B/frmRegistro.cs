using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;






namespace Proyecto2B
{
    public partial class frmRegistro : Form
    {
        List<string> lsGeneros = new List<string>();
        List<string> lsPaises = new List<string>();


        public static bool IsValidEmail(string strIn)
        {

            return Regex.IsMatch(strIn,
                   @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }


        public frmRegistro()
        {
            InitializeComponent();
            listarGeneros();
            listarPaises();
        }

        private void listarPaises()
        {
            lsPaises.Add("Afganistán"); lsPaises.Add("Albania"); lsPaises.Add("Alemania"); lsPaises.Add("Andorra");
            lsPaises.Add("Angola"); lsPaises.Add("Antigua y Barbuda"); lsPaises.Add("Arabia Saudita"); lsPaises.Add("Argelia");
            lsPaises.Add("Argentina"); lsPaises.Add("Armenia"); lsPaises.Add("Australia"); lsPaises.Add("Austria");
            lsPaises.Add("Azerbaiyán"); lsPaises.Add("Bahamas"); lsPaises.Add("Bangladés"); lsPaises.Add("Barbados");
            lsPaises.Add("Baréin"); lsPaises.Add("Bélgica"); lsPaises.Add("Belice"); lsPaises.Add("Benín");
            lsPaises.Add("Bielorrusia"); lsPaises.Add("Birmania"); lsPaises.Add("Bolivia"); lsPaises.Add("Bosnia y Herzegovina");
            lsPaises.Add("Botsuana"); lsPaises.Add("Brasil"); lsPaises.Add("Brunéi"); lsPaises.Add("Bulgaria");
            lsPaises.Add("Burkina Faso"); lsPaises.Add("Burundi"); lsPaises.Add("Bután"); lsPaises.Add("Cabo Verde");
            lsPaises.Add("Camboya"); lsPaises.Add("Camerún"); lsPaises.Add("Canadá"); lsPaises.Add("Catar");
            lsPaises.Add("Chad"); lsPaises.Add("Chile"); lsPaises.Add("China"); lsPaises.Add("Chipre");
            lsPaises.Add("Ciudad del Vaticano"); lsPaises.Add("Colombia"); lsPaises.Add("Comoras"); lsPaises.Add("Corea del Norte");
            lsPaises.Add("Corea del Sur"); lsPaises.Add("Costa de Marfil"); lsPaises.Add("Costa Rica"); lsPaises.Add("Croacia");
            lsPaises.Add("Cuba"); lsPaises.Add("Dinamarca"); lsPaises.Add("Dominica"); lsPaises.Add("Ecuador");
            lsPaises.Add("Egipto"); lsPaises.Add("El Salvador"); lsPaises.Add("Emiratos Árabes Unidos"); lsPaises.Add("Eritrea");
            lsPaises.Add("Eslovaquia"); lsPaises.Add("Eslovenia"); lsPaises.Add("España"); lsPaises.Add("Estados Unidos");
            lsPaises.Add("Estonia"); lsPaises.Add("Etiopía"); lsPaises.Add("Filipinas"); lsPaises.Add("Finlandia");
            lsPaises.Add("Fiyi"); lsPaises.Add("Francia"); lsPaises.Add("Gabón"); lsPaises.Add("Gambia");
            lsPaises.Add("Georgia"); lsPaises.Add("Ghana"); lsPaises.Add("Granada"); lsPaises.Add("Grecia");
            lsPaises.Add("Guatemala"); lsPaises.Add("Guyana"); lsPaises.Add("Guinea"); lsPaises.Add("Guinea ecuatorial");
            lsPaises.Add("Guinea-Bisáu"); lsPaises.Add("Haití"); lsPaises.Add("Honduras"); lsPaises.Add("Hungría");
            lsPaises.Add("India"); lsPaises.Add("Indonesia"); lsPaises.Add("Irak"); lsPaises.Add("Irán");
            lsPaises.Add("Irlanda"); lsPaises.Add("Islandia"); lsPaises.Add("Islas Marshall"); lsPaises.Add("Islas Salomón");
            lsPaises.Add("Israel"); lsPaises.Add("Italia"); lsPaises.Add("Jamaica"); lsPaises.Add("Japón");
            lsPaises.Add("Jordania"); lsPaises.Add("Kazajistán"); lsPaises.Add("Kenia"); lsPaises.Add("Kirguistán");
            lsPaises.Add("Kiribati"); lsPaises.Add("Kuwait"); lsPaises.Add("Laos"); lsPaises.Add("Lesoto");
            lsPaises.Add("Letonia"); lsPaises.Add("Líbano"); lsPaises.Add("Liberia"); lsPaises.Add("Libia");
            lsPaises.Add("Liechtenstein"); lsPaises.Add("Lituania"); lsPaises.Add("Luxemburgo"); lsPaises.Add("Madagascar");
            lsPaises.Add("Malasia"); lsPaises.Add("Malaui"); lsPaises.Add("Maldivas"); lsPaises.Add("Malí");
            lsPaises.Add("Malta"); lsPaises.Add("Marruecos"); lsPaises.Add("Mauricio"); lsPaises.Add("Mauritania");
            lsPaises.Add("México"); lsPaises.Add("Micronesia"); lsPaises.Add("Moldavia"); lsPaises.Add("Mónaco");
            lsPaises.Add("Mongolia"); lsPaises.Add("Montenegro"); lsPaises.Add("Mozambique"); lsPaises.Add("Namibia");
            lsPaises.Add("Nauru"); lsPaises.Add("Nepal"); lsPaises.Add("Nicaragua"); lsPaises.Add("Níger");
            lsPaises.Add("Nigeria"); lsPaises.Add("Noruega"); lsPaises.Add("Nueva Zelanda"); lsPaises.Add("Omán");
            lsPaises.Add("Países Bajos"); lsPaises.Add("Pakistán"); lsPaises.Add("Palaos"); lsPaises.Add("Panamá");
            lsPaises.Add("Papúa Nueva Guinea"); lsPaises.Add("Paraguay"); lsPaises.Add("Perú"); lsPaises.Add("Polonia");
            lsPaises.Add("Portugal"); lsPaises.Add("Reino Unido"); lsPaises.Add("República Centroafricana"); lsPaises.Add("República Checa");
            lsPaises.Add("República de Macedonia"); lsPaises.Add("República del Congo"); lsPaises.Add("República Democrática del Congo"); lsPaises.Add("República Dominicana");
            lsPaises.Add("República Sudafricana"); lsPaises.Add("Ruanda"); lsPaises.Add("Rumanía"); lsPaises.Add("Rusia");
            lsPaises.Add("Samoa"); lsPaises.Add("San Cristóbal y Nieves"); lsPaises.Add("San Marino"); lsPaises.Add("San Vicente y las Granadinas");
            lsPaises.Add("Santa Lucía"); lsPaises.Add("Santo Tomé y Príncipe"); lsPaises.Add("Senegal"); lsPaises.Add("Serbia");
            lsPaises.Add("Seychelles"); lsPaises.Add("Sierra Leona"); lsPaises.Add("Singapur"); lsPaises.Add("Siria");
            lsPaises.Add("Somalia"); lsPaises.Add("Sri Lanka"); lsPaises.Add("Suazilandia"); lsPaises.Add("Sudán");
            lsPaises.Add("Sudán del Sur"); lsPaises.Add("Suecia"); lsPaises.Add("Suiza"); lsPaises.Add("Surinam");
            lsPaises.Add("Tailandia"); lsPaises.Add("Tanzania"); lsPaises.Add("Tayikistán"); lsPaises.Add("Timor Oriental");
            lsPaises.Add("Togo"); lsPaises.Add("Tonga"); lsPaises.Add("Trinidad y Tobago"); lsPaises.Add("Túnez");
            lsPaises.Add("Turkmenistán"); lsPaises.Add("Turquía"); lsPaises.Add("Tuvalu"); lsPaises.Add("Ucrania");
            lsPaises.Add("Uganda"); lsPaises.Add("Uruguay"); lsPaises.Add("Uzbekistán"); lsPaises.Add("Vanuatu");
            lsPaises.Add("Venezuela"); lsPaises.Add("Vietnam"); lsPaises.Add("Yemen"); lsPaises.Add("Yibuti");
            lsPaises.Add("Zambia"); lsPaises.Add("Zimbabue");
            foreach (string pais in lsPaises)
            {
                cbxPaises.Items.Add(pais);
            }
        }

        private void listarGeneros()
        {
            lsGeneros.Add("Masculino");
            lsGeneros.Add("Femenino");
            cbxGenero.Items.Clear();
            foreach (string genero in lsGeneros)
            {
                cbxGenero.Items.Add(genero);
            }

        }

        
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            dtpNacimiento.CustomFormat = "MMMM dd, yyyy - dddd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuarioNuevo = new Usuario();

            if (txtNombre.Text is string)
            {
                usuarioNuevo.Nombre = txtNombre.Text;
            }
            else
            {
                MessageBox.Show("Nombre invalido");
                txtNombre.Text = "";
            }
            if (IsValidEmail(txtCoreo.Text) == false)
            {
                txtCoreo.Text = "";
                MessageBox.Show("Correo Invalido");
            }
            try
            {
                usuarioNuevo.Apellido = txtApellido.Text;
                usuarioNuevo.Correo = txtCoreo.Text;
                usuarioNuevo.Contrasena = txtContrasena.Text;
                usuarioNuevo.Genero = cbxGenero.SelectedItem.ToString();
                usuarioNuevo.Pais = cbxPaises.SelectedItem.ToString();
                //usuarioNuevo.FechaNacimiento = dtpNacimiento.Value.Date.ToString("MM/dd/yyyy"); 
                usuarioNuevo.FechaNacimiento = dtpNacimiento.Value.Date;

                usuarioNuevo = new Usuario(usuarioNuevo.Id, usuarioNuevo.Nombre, usuarioNuevo.Apellido, usuarioNuevo.Correo, usuarioNuevo.Contrasena, usuarioNuevo.Genero, usuarioNuevo.Pais, usuarioNuevo.FechaNacimiento, usuarioNuevo.PuntoAcumulados);

                UsuarioDAO.insertarUsuario(usuarioNuevo);

                this.Hide();
                frmUsuario frmUsuario = new frmUsuario(usuarioNuevo);
                frmUsuario.Usuario = usuarioNuevo;
                frmUsuario.Show();
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                MessageBox.Show("Ingrese datos por favor");
            }

            
        }
    }
}
