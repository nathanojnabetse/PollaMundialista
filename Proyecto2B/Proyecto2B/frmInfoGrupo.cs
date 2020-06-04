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
    public partial class frmInfoGrupo : Form
    {
        Grupo grupo;

        public Grupo Grupo { get => grupo; set => grupo = value; }

        public frmInfoGrupo()
        {
            InitializeComponent();
        }

        public frmInfoGrupo(Grupo Grupo)
        {
            this.grupo = Grupo;
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void lblNombreGrupo_Click(object sender, EventArgs e)
        {

        }

        private void puntaje()
        {

        }


        private void frmInfoGrupo_Load(object sender, EventArgs e)
        {
            lblNombreGrupo.Text = grupo.Nombre;

            List<UserGrupo> lsUsuariosDelGrupo = new List<UserGrupo>();
            lsUsuariosDelGrupo = UserGrupoDAO.PersonasDelGrupo(grupo);
            List<Usuario> lsPersonas = new List<Usuario>();

            lbxPersonas.Items.Clear();
            foreach(UserGrupo iter in lsUsuariosDelGrupo)
            {
                lsPersonas = UsuarioDAO.buscarUserPorID(iter);
                foreach(Usuario user in lsPersonas)
                {
                    lbxPersonas.Items.Add(user);
                }
            }
        }
    }
}
