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
    public partial class frmTablaGlobal : Form
    {
        public frmTablaGlobal()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmTablaGlobal_Load(object sender, EventArgs e)
        {
            List<TtablaGlobal> tabla = new List<TtablaGlobal>();
            tabla = TtablaGlobalDAO.tablaGlobaldePosiciones();

            foreach(var iter in tabla)
            {
                listBox1.Items.Add( iter);
            }
        }
    }
}
