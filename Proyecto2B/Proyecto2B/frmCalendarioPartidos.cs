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
    public partial class frmCalendarioPartidos : Form
    {
        Partido partido;

        public Partido Partido { get => partido; set => partido = value; }

        public frmCalendarioPartidos()
        {
            InitializeComponent();
        }

        private void frmCalendarioPartidos_Load(object sender, EventArgs e)
        {

            List<CalendarioPartidos> lsCal = new List<CalendarioPartidos>();
            Console.WriteLine("calsadad");
            lsCal = CalendarioPartidosDAO.obtenerTodoslospartidos();

            foreach(var iter in lsCal)
            {
                lbxCalendario.Items.Add(iter);
            }


            //List<Partido> lsPartidos = new List<Partido>();
            //lsPartidos = PartidoDAO.obtenerPartido();
            //List<Equipo> nombresEquipos1 = new List<Equipo>();
            //List<Equipo> nombresEquipos2 = new List<Equipo>();

            //lbxCalendario.Items.Clear();
            //foreach (Partido iter in lsPartidos)
            //{

            //    nombresEquipos1 = EquipoDAO.buscarEquipoPorID1(iter);
            //    nombresEquipos2 = EquipoDAO.buscarEquipoPorID1(iter);
            //    foreach (Equipo equip in nombresEquipos1)
            //    {
            //        lbxCalendario.Items.Add(equip);

            //    }
            //    lbxCalendario.Items.Add(iter);

            //}
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
