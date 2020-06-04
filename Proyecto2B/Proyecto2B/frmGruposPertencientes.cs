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
    public partial class frmGruposPertencientes : Form
    {
        Usuario usuario = new Usuario();

        Grupo grupo;
        String cadena;

        UserGrupo userGrupo;


        internal UserGrupo UserGrupo { get => userGrupo; set => userGrupo = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public frmGruposPertencientes()
        {
            InitializeComponent();
        }

        public frmGruposPertencientes(Usuario usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }


        private void frmGruposPertencientes_Load(object sender, EventArgs e)
        {
            List<UserGrupo> lsUser_Grupos = new List<UserGrupo>();
            lsUser_Grupos = UserGrupoDAO.gruposAlosQuePertenezco(Usuario);
            List<Grupo> lsNombres_Grupos = new List<Grupo>();


            lbxGrupos.Items.Clear();
            foreach (UserGrupo iter in lsUser_Grupos)
            {
                lsNombres_Grupos = GrupoDAO.buscarGrupoporID(iter);
                //GrupoDAO.buscarGrupoporID(iter.IdGrupo);

                foreach (Grupo a in lsNombres_Grupos)
                {
                    lbxGrupos.Items.Add(a);
                }
            }




        }


        private void btnverGrupo_Click_1(object sender, EventArgs e)
        {
            Grupo verGrupo = (Grupo)lbxGrupos.SelectedItem;
            frmInfoGrupo frmInfo = new frmInfoGrupo(verGrupo);
            frmInfo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPredicciones frmPredicciones = new frmPredicciones((Grupo)lbxGrupos.SelectedItem, Usuario, cadena);
            frmPredicciones.Show();
        }
    }
}
