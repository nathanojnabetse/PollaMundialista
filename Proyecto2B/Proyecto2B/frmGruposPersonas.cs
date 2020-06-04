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
    public partial class frmGruposPersonas : Form
    {
        Usuario usuario;
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public frmGruposPersonas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Grupo> lsGrupos = new List<Grupo>();

            lsGrupos = GrupoDAO.buscarGrupo(txtCodGrupo.Text);

           
                lbxGrupos.Items.Clear();

                foreach(var iter in lsGrupos)
                {
                    lbxGrupos.Items.Add(iter);
                }

               
        }

        private void btnUnirme_Click(object sender, EventArgs e)
        {
            Grupo graux = (Grupo)lbxGrupos.SelectedItem;

            if (MessageBox.Show("¿Esta seguro de querer unirse a este grupo?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuarioDAO.unionAgrupo(usuario, graux);
                this.Close();
            }
            

        }

        private void frmGruposPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
