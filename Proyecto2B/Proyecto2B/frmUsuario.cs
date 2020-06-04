using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2B
{
    public partial class frmUsuario : Form
    {
        Usuario usuario;
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public frmUsuario(Usuario usuarioNuevo)

        {
            InitializeComponent();
        }

        public frmUsuario()

        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido: " + usuario.Nombre + " " + usuario.Apellido ;
        }

        private void crearNuevoGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReglasGrupo frmReglasGrupo = new frmReglasGrupo();
            List<Usuario> lsaux = new List<Usuario>();
            
            lsaux = UsuarioDAO.obtenerUsuario();
            foreach (var iter in lsaux)
            {
                if ((iter.Nombre == usuario.Nombre) && (iter.Apellido == usuario.Apellido))
                {

                    frmReglasGrupo.Usuario = iter;
                    frmReglasGrupo.Show();
                    break;
                }
            }

        }

        private void verGruposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            //frmGruposPertencientes frmGruposPertencientes = new frmGruposPertencientes();
            //frmGruposPertencientes.Usuario = this.usuario;
            //frmGruposPertencientes.Show();


        }

        private void unirmeAUnGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGruposPersonas frmGruposPersonas = new frmGruposPersonas();
            List<Usuario> lsaux = new List<Usuario>();
            lsaux = UsuarioDAO.obtenerUsuario();
            foreach (var iter in lsaux)
            {
                if ((iter.Nombre == usuario.Nombre)&&(iter.Apellido == usuario.Apellido))
                {

                    frmGruposPersonas.Usuario = iter;
                    frmGruposPersonas.Show();
                    break;
                }
            }
            
        }

       

        private void verGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerFaseGrupos frmVerFaseGrupos = new frmVerFaseGrupos();
            frmVerFaseGrupos.Show();
        }

        private void partidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdministrarPartido administrarPartido = new frmAdministrarPartido(1);
            administrarPartido.Show();
        }

        private void tablaGlobalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaGlobal frmTablaGlobal = new frmTablaGlobal();
            frmTablaGlobal.Show();
        }

        private void misGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGruposPertencientes frmGruposPertenece = new frmGruposPertencientes(usuario);

            List<Usuario> lsaux = new List<Usuario>();
            lsaux = UsuarioDAO.obtenerUsuario();
            foreach (var iter in lsaux)
            {
                if ((iter.Nombre == usuario.Nombre) && (iter.Apellido == usuario.Apellido))
                {
                    frmGruposPertenece.Usuario = iter;
                    frmGruposPertenece.Show();
                    break;
                }
            }

        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarUsuario frmEditarUser = new frmEditarUsuario(usuario);
            
            frmEditarUser.Show();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendarioPartidos frmCalendarioPartidos = new frmCalendarioPartidos();
            frmCalendarioPartidos.Show();
        }

        private void seleccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeleccion frmSeleccion = new FrmSeleccion();
            frmSeleccion.Show();
        }

        private void llavesDeClasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLlavesClasificacion frmLlavesClasificacion = new frmLlavesClasificacion(1);
            frmLlavesClasificacion.Show();
            
        }

        private void clasificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClasificados frmClasificados = new frmClasificados();
            frmClasificados.Show();
        }

        private void tablaDeMiGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
