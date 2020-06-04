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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void administrarPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarPartido frmadministrar = new frmAdministrarPartido();
            frmadministrar.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerFaseGrupos frmVerFaseGrupos = new frmVerFaseGrupos();
            frmVerFaseGrupos.Show();
        }

        private void llavesDeClasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLlavesClasificacion frmLlavesClasificacion = new frmLlavesClasificacion(0);
            frmLlavesClasificacion.Show();
        }

        private void clasificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClasificados frmClasificados = new frmClasificados();
            frmClasificados.Show();
        }

        private void tablaGlobalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTablaGlobal frmTablaGlobal = new frmTablaGlobal();
            frmTablaGlobal.Show();
        }

        private void administradprToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupos frmGrupos = new frmGrupos();
            frmGrupos.Show();
        }
    }
}
