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
    public partial class FrmSeleccion : Form
    {
        public FrmSeleccion()
        {
            InitializeComponent();
        }

        List<Equipo> lsEquipos = new List<Equipo>();
        

        private void FrmSeleccion_Load(object sender, EventArgs e)
        {
            lsEquipos = EquipoDAO.infoEquipo();
            lbxInfoEquipos.Items.Clear();
            foreach(Equipo iter in lsEquipos)
            {
                lbxInfoEquipos.Items.Add(iter);
            }

           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
