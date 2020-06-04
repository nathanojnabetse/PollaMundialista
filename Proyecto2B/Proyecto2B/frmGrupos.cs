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
    public partial class frmGrupos : Form
    {
        public frmGrupos()
        {
            InitializeComponent();
        }

        List<Grupo> listaGrupos = new List<Grupo>();
       


        private void btnverGrupo_Click(object sender, EventArgs e)
        {
            Grupo verGrupo = (Grupo)lbxGrupos.SelectedItem;
            frmInfoGrupo frmInfo = new frmInfoGrupo(verGrupo);
            frmInfo.Show();
        }

        private void frmGrupos_Load(object sender, EventArgs e)
        {
            lbxGrupos.Items.Clear();
            listaGrupos = GrupoDAO.obtenerGrupos();
            foreach(Grupo iter in listaGrupos)
            {
                lbxGrupos.Items.Add(iter);
            }
        }
    }
}
