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
    public partial class frmAdministrarPartido  : Form
    {
        public frmAdministrarPartido(int v)
        {
            InitializeComponent();
            if(v == 1)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        ctrl.Visible = false;
                    }
                }
            }
        }

        public frmAdministrarPartido()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        private List<Partido> lsauxPArtidos;

     

        private void Partido1_CheckedChanged_1(object sender, EventArgs e)
        {

            P1E1.Text = Convert.ToString(rnd.Next(0, 10));
            P1E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P1E1.Text);
            int p2= Convert.ToInt32( P1E2.Text);
            jugarPartido(1, p1, p2);
            Partido1.Enabled = false;
            
        }

        private void Partido2_CheckedChanged(object sender, EventArgs e)
        {
            P2E1.Text = Convert.ToString(rnd.Next(0, 10));
            P2E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P2E1.Text);
            int p2 = Convert.ToInt32(P2E2.Text);
            jugarPartido(2, p1, p2);
            Partido2.Enabled = false;
        }

        private void Partido3_CheckedChanged(object sender, EventArgs e)
        {
            P3E1.Text = Convert.ToString(rnd.Next(0, 10));
            P3E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P3E1.Text);
            int p2 = Convert.ToInt32(P3E2.Text);
            jugarPartido(3, p1, p2);
            Partido3.Enabled = false;
        }

        private void Partido4_CheckedChanged(object sender, EventArgs e)
        {
            P4E1.Text = Convert.ToString(rnd.Next(0, 10));
            P4E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P4E1.Text);
            int p2 = Convert.ToInt32(P4E2.Text);
            jugarPartido(4, p1, p2);
            Partido4.Enabled = false;
        }

        private void Partido5_CheckedChanged(object sender, EventArgs e)
        {
            P5E1.Text = Convert.ToString(rnd.Next(0, 10));
            P5E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P5E1.Text);
            int p2 = Convert.ToInt32(P5E2.Text);
            jugarPartido(5, p1, p2);
            Partido5.Enabled = false;
        }

        private void Partido6_CheckedChanged(object sender, EventArgs e)
        {
            P6E1.Text = Convert.ToString(rnd.Next(0, 10));
            P6E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P6E1.Text);
            int p2 = Convert.ToInt32(P6E2.Text);
            jugarPartido(6, p1, p2);
            Partido6.Enabled = false;
        }

        private void Partido7_CheckedChanged(object sender, EventArgs e)
        {
            P7E1.Text = Convert.ToString(rnd.Next(0, 10));
            P7E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P7E1.Text);
            int p2 = Convert.ToInt32(P7E2.Text);
            jugarPartido(7, p1, p2);
            Partido7.Enabled = false;

        }

        private void Partido8_CheckedChanged(object sender, EventArgs e)
        {
            P8E1.Text = Convert.ToString(rnd.Next(0, 10));
            P8E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P8E1.Text);
            int p2 = Convert.ToInt32(P8E2.Text);
            jugarPartido(8, p1, p2);
            Partido8.Enabled = false;
        }

        private void Partido9_CheckedChanged(object sender, EventArgs e)
        {
            P9E1.Text = Convert.ToString(rnd.Next(0, 10));
            P9E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P9E1.Text);
            int p2 = Convert.ToInt32(P9E2.Text);
            jugarPartido(9, p1, p2);
            Partido9.Enabled = false;
        }

        private void Partido10_CheckedChanged(object sender, EventArgs e)
        {
            P10E1.Text = Convert.ToString(rnd.Next(0, 10));
            P10E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P10E1.Text);
            int p2 = Convert.ToInt32(P10E2.Text);
            jugarPartido(10, p1, p2);
            Partido10.Enabled = false;
        }

        private void Partido11_CheckedChanged(object sender, EventArgs e)
        {
            P11E1.Text = Convert.ToString(rnd.Next(0, 10));
            P11E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P11E1.Text);
            int p2 = Convert.ToInt32(P11E2.Text);
            jugarPartido(11, p1, p2);
            Partido11.Enabled = false;
        }

        private void Partido12_CheckedChanged(object sender, EventArgs e)
        {
            P12E1.Text = Convert.ToString(rnd.Next(0, 10));
            P12E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P12E1.Text);
            int p2 = Convert.ToInt32(P12E2.Text);
            jugarPartido(12, p1, p2);
            Partido12.Enabled = false;
        }

        private void Partido13_CheckedChanged(object sender, EventArgs e)
        {
            P13E1.Text = Convert.ToString(rnd.Next(0, 10));
            P13E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P13E1.Text);
            int p2 = Convert.ToInt32(P13E2.Text);
            jugarPartido(13, p1, p2);
            Partido13.Enabled = false;
        }

        private void Partido14_CheckedChanged(object sender, EventArgs e)
        {
            P14E1.Text = Convert.ToString(rnd.Next(0, 10));
            P14E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P14E1.Text);
            int p2 = Convert.ToInt32(P14E2.Text);
            jugarPartido(14, p1, p2);
            Partido14.Enabled = false;
        }

        private void Partido15_CheckedChanged(object sender, EventArgs e)
        {
            P15E1.Text = Convert.ToString(rnd.Next(0, 10));
            P15E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P15E1.Text);
            int p2 = Convert.ToInt32(P15E2.Text);
            jugarPartido(15, p1, p2);
            Partido15.Enabled = false;
        }

        private void Partido16_CheckedChanged(object sender, EventArgs e)
        {
            P16E1.Text = Convert.ToString(rnd.Next(0, 10));
            P16E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P16E1.Text);
            int p2 = Convert.ToInt32(P16E2.Text);
            jugarPartido(16, p1, p2);
            Partido16.Enabled = false;
        }

        private void Partido17_CheckedChanged(object sender, EventArgs e)
        {
            P17E1.Text = Convert.ToString(rnd.Next(0, 10));
            P17E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P17E1.Text);
            int p2 = Convert.ToInt32(P17E2.Text);
            jugarPartido(17, p1, p2);
            Partido17.Enabled = false;
        }

        private void Partido18_CheckedChanged(object sender, EventArgs e)
        {
            P18E1.Text = Convert.ToString(rnd.Next(0, 10));
            P18E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P18E1.Text);
            int p2 = Convert.ToInt32(P18E2.Text);
            jugarPartido(18, p1, p2);
            Partido18.Enabled = false;
        }

        private void Partido19_CheckedChanged(object sender, EventArgs e)
        {
            P19E1.Text = Convert.ToString(rnd.Next(0, 10));
            P19E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P19E1.Text);
            int p2 = Convert.ToInt32(P19E2.Text);
            jugarPartido(19, p1, p2);
            Partido19.Enabled = false;
        }

        private void Partido20_CheckedChanged(object sender, EventArgs e)
        {
            P20E1.Text = Convert.ToString(rnd.Next(0, 10));
            P20E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P20E1.Text);
            int p2 = Convert.ToInt32(P20E2.Text);
            jugarPartido(20, p1, p2);
            Partido20.Enabled = false;
        }

        private void Partido21_CheckedChanged(object sender, EventArgs e)
        {
            P21E1.Text = Convert.ToString(rnd.Next(0, 10));
            P21E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P21E1.Text);
            int p2 = Convert.ToInt32(P21E2.Text);
            jugarPartido(21, p1, p2);
            Partido21.Enabled = false;
        }

        private void Partido22_CheckedChanged(object sender, EventArgs e)
        {
            P22E1.Text = Convert.ToString(rnd.Next(0, 10));
            P22E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P22E1.Text);
            int p2 = Convert.ToInt32(P22E2.Text);
            jugarPartido(22, p1, p2);
            Partido22.Enabled = false;
        }

        private void Partido23_CheckedChanged(object sender, EventArgs e)
        {
            P23E1.Text = Convert.ToString(rnd.Next(0, 10));
            P23E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P23E1.Text);
            int p2 = Convert.ToInt32(P23E2.Text);
            jugarPartido(23, p1, p2);
            Partido23.Enabled = false;
        }

        private void Partido24_CheckedChanged(object sender, EventArgs e)
        {
            P24E1.Text = Convert.ToString(rnd.Next(0, 10));
            P24E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P24E1.Text);
            int p2 = Convert.ToInt32(P24E2.Text);
            jugarPartido(24, p1, p2);
            Partido24.Enabled = false;
        }

        private void Partido25_CheckedChanged(object sender, EventArgs e)
        {
            P25E1.Text = Convert.ToString(rnd.Next(0, 10));
            P25E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P25E1.Text);
            int p2 = Convert.ToInt32(P25E2.Text);
            jugarPartido(25, p1, p2);
            Partido25.Enabled = false;
        }

        private void Partido26_CheckedChanged(object sender, EventArgs e)
        {
            P26E1.Text = Convert.ToString(rnd.Next(0, 10));
            P26E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P26E1.Text);
            int p2 = Convert.ToInt32(P26E2.Text);
            jugarPartido(26, p1, p2);
            Partido26.Enabled = false;
        }

        private void Partido27_CheckedChanged(object sender, EventArgs e)
        {
            P27E1.Text = Convert.ToString(rnd.Next(0, 10));
            P27E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P27E1.Text);
            int p2 = Convert.ToInt32(P27E2.Text);
            jugarPartido(27, p1, p2);
            Partido27.Enabled = false;
        }

        private void Partido28_CheckedChanged(object sender, EventArgs e)
        {
            P28E1.Text = Convert.ToString(rnd.Next(0, 10));
            P28E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P28E1.Text);
            int p2 = Convert.ToInt32(P28E2.Text);
            jugarPartido(28, p1, p2);
            Partido28.Enabled = false;
        }

        private void Partido29_CheckedChanged(object sender, EventArgs e)
        {
            P29E1.Text = Convert.ToString(rnd.Next(0, 10));
            P29E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P29E1.Text);
            int p2 = Convert.ToInt32(P29E2.Text);
            jugarPartido(29, p1, p2);
            Partido29.Enabled = false;
        }

        private void Partido30_CheckedChanged(object sender, EventArgs e)
        {
            P30E1.Text = Convert.ToString(rnd.Next(0, 10));
            P30E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P30E1.Text);
            int p2 = Convert.ToInt32(P30E2.Text);
            jugarPartido(30, p1, p2);
            Partido30.Enabled = false;
        }

        private void Partido31_CheckedChanged(object sender, EventArgs e)
        {
            P31E1.Text = Convert.ToString(rnd.Next(0, 10));
            P31E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P31E1.Text);
            int p2 = Convert.ToInt32(P31E2.Text);
            jugarPartido(31, p1, p2);
            Partido31.Enabled = false;
        }

        private void Partido32_CheckedChanged(object sender, EventArgs e)
        {
            P32E1.Text = Convert.ToString(rnd.Next(0, 10));
            P32E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P32E1.Text);
            int p2 = Convert.ToInt32(P32E2.Text);
            jugarPartido(32, p1, p2);
            Partido32.Enabled = false;
        }

        private void Partido33_CheckedChanged(object sender, EventArgs e)
        {
            P33E1.Text = Convert.ToString(rnd.Next(0, 10));
            P33E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P33E1.Text);
            int p2 = Convert.ToInt32(P33E2.Text);
            jugarPartido(33, p1, p2);
            Partido33.Enabled = false;
        }

        private void Partido34_CheckedChanged(object sender, EventArgs e)
        {
            P34E1.Text = Convert.ToString(rnd.Next(0, 10));
            P34E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P34E1.Text);
            int p2 = Convert.ToInt32(P34E2.Text);
            jugarPartido(34, p1, p2);
            Partido34.Enabled = false;
        }

        private void Partido35_CheckedChanged(object sender, EventArgs e)
        {
            P35E1.Text = Convert.ToString(rnd.Next(0, 10));
            P35E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P35E1.Text);
            int p2 = Convert.ToInt32(P35E2.Text);
            jugarPartido(35, p1, p2);
            Partido35.Enabled = false;
        }

        private void Partido36_CheckedChanged(object sender, EventArgs e)
        {
            P36E1.Text = Convert.ToString(rnd.Next(0, 10));
            P36E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P36E1.Text);
            int p2 = Convert.ToInt32(P36E2.Text);
            jugarPartido(36, p1, p2);
            Partido36.Enabled = false;
        }

        private void Partido37_CheckedChanged(object sender, EventArgs e)
        {
            P37E1.Text = Convert.ToString(rnd.Next(0, 10));
            P37E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P37E1.Text);
            int p2 = Convert.ToInt32(P37E2.Text);
            jugarPartido(37, p1, p2);
            Partido37.Enabled = false;
        }

        private void Partido38_CheckedChanged(object sender, EventArgs e)
        {
            P38E1.Text = Convert.ToString(rnd.Next(0, 10));
            P38E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P38E1.Text);
            int p2 = Convert.ToInt32(P38E2.Text);
            jugarPartido(38, p1, p2);
            Partido38.Enabled = false;
        }

        private void Partido39_CheckedChanged(object sender, EventArgs e)
        {
            P39E1.Text = Convert.ToString(rnd.Next(0, 10));
            P39E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P39E1.Text);
            int p2 = Convert.ToInt32(P39E2.Text);
            jugarPartido(39, p1, p2);
            Partido39.Enabled = false;
        }

        private void Partido40_CheckedChanged(object sender, EventArgs e)
        {
            P40E1.Text = Convert.ToString(rnd.Next(0, 10));
            P40E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P40E1.Text);
            int p2 = Convert.ToInt32(P40E2.Text);
            jugarPartido(40, p1, p2);
            Partido40.Enabled = false;
        }

        private void Partido41_CheckedChanged(object sender, EventArgs e)
        {
            P41E1.Text = Convert.ToString(rnd.Next(0, 10));
            P41E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P41E1.Text);
            int p2 = Convert.ToInt32(P41E2.Text);
            jugarPartido(41, p1, p2);
            Partido41.Enabled = false;
        }

        private void Partido42_CheckedChanged(object sender, EventArgs e)
        {
            P42E1.Text = Convert.ToString(rnd.Next(0, 10));
            P42E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P42E1.Text);
            int p2 = Convert.ToInt32(P42E2.Text);
            jugarPartido(42, p1, p2);
            Partido42.Enabled = false;
        }

        private void Partido43_CheckedChanged(object sender, EventArgs e)
        {
            P43E1.Text = Convert.ToString(rnd.Next(0, 10));
            P43E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P43E1.Text);
            int p2 = Convert.ToInt32(P43E2.Text);
            jugarPartido(43, p1, p2);
            Partido43.Enabled = false;
        }

        private void Partido44_CheckedChanged(object sender, EventArgs e)
        {
            P44E1.Text = Convert.ToString(rnd.Next(0, 10));
            P44E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P44E1.Text);
            int p2 = Convert.ToInt32(P44E2.Text);
            jugarPartido(44, p1, p2);
            Partido44.Enabled = false;
        }

        private void Partido45_CheckedChanged(object sender, EventArgs e)
        {
            P45E1.Text = Convert.ToString(rnd.Next(0, 10));
            P45E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P45E1.Text);
            int p2 = Convert.ToInt32(P45E2.Text);
            jugarPartido(45, p1, p2);
            Partido45.Enabled = false;
        }

        private void Partido46_CheckedChanged(object sender, EventArgs e)
        {
            P46E1.Text = Convert.ToString(rnd.Next(0, 10));
            P46E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P46E1.Text);
            int p2 = Convert.ToInt32(P46E2.Text);
            jugarPartido(46, p1, p2);
            Partido46.Enabled = false;
        }

        private void Partido47_CheckedChanged(object sender, EventArgs e)
        {
            P47E1.Text = Convert.ToString(rnd.Next(0, 10));
            P47E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P47E1.Text);
            int p2 = Convert.ToInt32(P47E2.Text);
            jugarPartido(47, p1, p2);
            Partido47.Enabled = false;
        }

        private void Partido48_CheckedChanged(object sender, EventArgs e)
        {
            P48E1.Text = Convert.ToString(rnd.Next(0, 10));
            P48E2.Text = Convert.ToString(rnd.Next(0, 10));
            int p1 = Convert.ToInt32(P48E1.Text);
            int p2 = Convert.ToInt32(P48E2.Text);
            jugarPartido(48, p1, p2);
            Partido48.Enabled = false;

            Clasificar();

        }


        ///////////////////////
        private void Clasificar()
        {
            List<Clasificados> lsClasificados = new List<Clasificados>();
            lsClasificados = ClasificadosDAO.obtenerCladificados();

            List<String> lsOrdenadosA = new List<string>();
            List<String> lsOrdenadosB = new List<string>();
            List<String> lsOrdenadosC = new List<string>();
            List<String> lsOrdenadosD = new List<string>();
            List<String> lsOrdenadosE = new List<string>();
            List<String> lsOrdenadosF = new List<string>();
            List<String> lsOrdenadosG = new List<string>();
            List<String> lsOrdenadosH = new List<string>();

            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ1, "*", lsClasificados[0].Equipo11));
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ2, "*", lsClasificados[0].Equipo21));
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ3, "*", lsClasificados[0].Equipo31));
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ4, "*", lsClasificados[0].Equipo41));

            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ1, "*", lsClasificados[1].Equipo11));
            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ2, "*", lsClasificados[1].Equipo21));
            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ3, "*", lsClasificados[1].Equipo31));
            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ4, "*", lsClasificados[1].Equipo41));

            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ1, "*", lsClasificados[2].Equipo11));
            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ2, "*", lsClasificados[2].Equipo21));
            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ3, "*", lsClasificados[2].Equipo31));
            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ4, "*", lsClasificados[2].Equipo41));

            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ1, "*", lsClasificados[3].Equipo11));
            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ2, "*", lsClasificados[3].Equipo21));
            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ3, "*", lsClasificados[3].Equipo31));
            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ4, "*", lsClasificados[3].Equipo41));

            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ1, "*", lsClasificados[4].Equipo11));
            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ2, "*", lsClasificados[4].Equipo21));
            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ3, "*", lsClasificados[4].Equipo31));
            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ4, "*", lsClasificados[4].Equipo41));

            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ1, "*", lsClasificados[5].Equipo11));
            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ2, "*", lsClasificados[5].Equipo21));
            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ3, "*", lsClasificados[5].Equipo31));
            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ4, "*", lsClasificados[5].Equipo41));
        
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ1, "*", lsClasificados[6].Equipo11));
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ2, "*", lsClasificados[6].Equipo21));
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ3, "*", lsClasificados[6].Equipo31));
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ4, "*", lsClasificados[6].Equipo41));

            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ1, "*", lsClasificados[7].Equipo11));
            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ2, "*", lsClasificados[7].Equipo21));
            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ3, "*", lsClasificados[7].Equipo31));
            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ4, "*", lsClasificados[7].Equipo41));

            List<String> lsClasifA = new List<string>();
            List<String> lsClasifB = new List<string>();
            List<String> lsClasifC = new List<string>();
            List<String> lsClasifD = new List<string>();
            List<String> lsClasifE = new List<string>();
            List<String> lsClasifF = new List<string>();
            List<String> lsClasifG = new List<string>();
            List<String> lsClasifH = new List<string>();

            lsClasifA = listaOrdenado(lsOrdenadosA);
            lsClasifB = listaOrdenado(lsOrdenadosB);
            lsClasifC = listaOrdenado(lsOrdenadosC);
            lsClasifD = listaOrdenado(lsOrdenadosD);
            lsClasifE = listaOrdenado(lsOrdenadosE);
            lsClasifF = listaOrdenado(lsOrdenadosF);
            lsClasifG = listaOrdenado(lsOrdenadosG);
            lsClasifH = listaOrdenado(lsOrdenadosH);



            FaseDAO.ClasificarFase(idEquipo(lsClasifC[1 - 1]), 33);
            FaseDAO.ClasificarFase(idEquipo(lsClasifD[2 - 1]), 34);
            PartidoDAO.EditarPartido(idEquipo(lsClasifC[1 - 1]), idEquipo(lsClasifD[2 - 1]), 49);

            FaseDAO.ClasificarFase(idEquipo(lsClasifA[1 - 1]), 35);
            FaseDAO.ClasificarFase(idEquipo(lsClasifB[2 - 1]), 36);
            PartidoDAO.EditarPartido(idEquipo(lsClasifA[1 - 1]), idEquipo(lsClasifB[2 - 1]), 50);

            FaseDAO.ClasificarFase(idEquipo(lsClasifB[1 - 1]), 37);
            FaseDAO.ClasificarFase(idEquipo(lsClasifA[2 - 1]), 38);
            PartidoDAO.EditarPartido(idEquipo(lsClasifB[1 - 1]), idEquipo(lsClasifA[2 - 1]), 51);

            FaseDAO.ClasificarFase(idEquipo(lsClasifD[1 - 1]), 39);
            FaseDAO.ClasificarFase(idEquipo(lsClasifC[2 - 1]), 40);
            PartidoDAO.EditarPartido(idEquipo(lsClasifD[1 - 1]), idEquipo(lsClasifC[2 - 1]), 52);

            FaseDAO.ClasificarFase(idEquipo(lsClasifE[1 - 1]), 41);
            FaseDAO.ClasificarFase(idEquipo(lsClasifF[2 - 1]), 42);
            PartidoDAO.EditarPartido(idEquipo(lsClasifE[1 - 1]), idEquipo(lsClasifF[2 - 1]), 53);

            FaseDAO.ClasificarFase(idEquipo(lsClasifG[1 - 1]), 43);
            FaseDAO.ClasificarFase(idEquipo(lsClasifH[2 - 1]), 44);
            PartidoDAO.EditarPartido(idEquipo(lsClasifG[1 - 1]), idEquipo(lsClasifH[2 - 1]), 54);

            FaseDAO.ClasificarFase(idEquipo(lsClasifF[1 - 1]), 45);
            FaseDAO.ClasificarFase(idEquipo(lsClasifE[2 - 1]), 46);
            PartidoDAO.EditarPartido(idEquipo(lsClasifF[1 - 1]), idEquipo(lsClasifE[2 - 1]), 55);

            FaseDAO.ClasificarFase(idEquipo(lsClasifH[1 - 1]), 47);
            FaseDAO.ClasificarFase(idEquipo(lsClasifG[2 - 1]), 48);
            PartidoDAO.EditarPartido(idEquipo(lsClasifH[1 - 1]), idEquipo(lsClasifG[2 - 1]), 56);

        }

        public static int idEquipo(string nombreEquipo)
        {

            if (nombreEquipo == "Rusia") { return 1; }
            else if (nombreEquipo == "Arabia Saudi") { return 2; }
            else if (nombreEquipo == "Egipto") { return 3; }
            else if (nombreEquipo == "Uruguay") { return 4; }
            else if (nombreEquipo == "Portugal") { return 5; }
            else if (nombreEquipo == "España") { return 6; }
            else if (nombreEquipo == "Marruecos") { return 7; }
            else if (nombreEquipo == "Irán") { return 8; }
            else if (nombreEquipo == "Francia") { return 9; }
            else if (nombreEquipo == "Australia") { return 10; }
            else if (nombreEquipo == "Perú") { return 11; }
            else if (nombreEquipo == "Dinamarca") { return 12; }
            else if (nombreEquipo == "Argentina") { return 13; }
            else if (nombreEquipo == "Islandia") { return 14; }
            else if (nombreEquipo == "Croacia") { return 15; }
            else if (nombreEquipo == "Nigeria") { return 16; }
            else if (nombreEquipo == "Brasil") { return 17; }
            else if (nombreEquipo == "Suiza") { return 18; }
            else if (nombreEquipo == "Costa Rica") { return 19; }
            else if (nombreEquipo == "Serbia") { return 20; }
            else if (nombreEquipo == "Alemania") { return 21; }
            else if (nombreEquipo == "México") { return 22; }
            else if (nombreEquipo == "Suecia") { return 23; }
            else if (nombreEquipo == "Corea del Sur") { return 24; }
            else if (nombreEquipo == "Bélgica") { return 25; }
            else if (nombreEquipo == "Panamá") { return 26; }
            else if (nombreEquipo == "Túnez") { return 27; }
            else if (nombreEquipo == "Inglaterra") { return 28; }
            else if (nombreEquipo == "Polonia") { return 29; }
            else if (nombreEquipo == "Senegal") { return 30; }
            else if (nombreEquipo == "Colombia") { return 31; }
            else if (nombreEquipo == "Japón") { return 32; }
            return 33;
        }

        public static List<String> listaOrdenado(List<String> lsPorOrdenar)
        {
            int i, j;
            string aux;
            string cadena1;
            string cadena2;
            char c1;
            char c2;


            for (i = 0; i < lsPorOrdenar.Count - 1; i++)
            {

                for (j = 0; j < lsPorOrdenar.Count - i - 1; j++)
                {


                    cadena1 = lsPorOrdenar[j + 1];
                    cadena2 = lsPorOrdenar[j];
                    c1 = cadena1[0];
                    c2 = cadena2[0];

                    if (Convert.ToInt32(c1) < Convert.ToInt32(c2))
                    {

                        aux = lsPorOrdenar[j + 1];
                        lsPorOrdenar[j + 1] = lsPorOrdenar[j];
                        lsPorOrdenar[j] = aux;
                    }

                }
            }
            List<String> lsFinal = new List<string>();
            List<String> lsENVIAR = new List<string>();
            lsFinal.Add(lsPorOrdenar[3]);
            lsFinal.Add(lsPorOrdenar[2]);
            lsFinal.Add(lsPorOrdenar[1]);
            lsFinal.Add(lsPorOrdenar[0]);
            int cont = 0;
            
            foreach (var iter in lsFinal)
            {
                
                String value = iter;
                Char delimiter = '*';
                String[] substrings = value.Split(delimiter);
                foreach (var substring in substrings)
                {
                    
                    if((cont == 1)|| (cont == 3) || (cont == 5) || (cont == 7))
                    {
                        lsENVIAR.Add(substring);
                        Console.WriteLine(substring);
                    }
                    cont++;
                }
                    

            }

            return lsENVIAR;
        }
        ////////////////////////////

        private void frmAdministrarPartido_Load(object sender, EventArgs e)
        {
            List<Partido> lsAuxPartidos = new List<Partido>();
            
            lsAuxPartidos = PartidoDAO.obtenerPartido();
            foreach (var iter in lsAuxPartidos)
            {              
                if (iter.IdPartido == 1)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido1.Enabled = true;
                        P1E1.Text = "-";
                        P1E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();

                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P1E1.Text = Convert.ToString(lsMarcadores[1-1].PuntosE1);
                        P1E2.Text = Convert.ToString(lsMarcadores[1-1].PuntosE2);
                        Partido1.Enabled = false;
                    }
                }
                else if(iter.IdPartido == 2)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido2.Enabled = true;
                        P2E1.Text = "-";
                        P2E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P2E1.Text = Convert.ToString(lsMarcadores[2-1].PuntosE1);
                        P2E2.Text = Convert.ToString(lsMarcadores[2-1].PuntosE2);
                        Partido2.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 3)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido3.Enabled = true;
                        P3E1.Text = "-";
                        P3E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P3E1.Text = Convert.ToString(lsMarcadores[3-1].PuntosE1);
                        P3E2.Text = Convert.ToString(lsMarcadores[3-1].PuntosE2);
                        Partido3.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 4)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido4.Enabled = true;
                        P4E1.Text = "-";
                        P4E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P4E1.Text = Convert.ToString(lsMarcadores[4-1].PuntosE1);
                        P4E2.Text = Convert.ToString(lsMarcadores[4-1].PuntosE2);
                        Partido4.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 5)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido5.Enabled = true;
                        P5E1.Text = "-";
                        P5E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P5E1.Text = Convert.ToString(lsMarcadores[5 - 1].PuntosE1);
                        P5E2.Text = Convert.ToString(lsMarcadores[5 - 1].PuntosE2);
                        Partido5.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 6)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido6.Enabled = true;
                        P6E1.Text = "-";
                        P6E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P6E1.Text = Convert.ToString(lsMarcadores[6 - 1].PuntosE1);
                        P6E2.Text = Convert.ToString(lsMarcadores[6 - 1].PuntosE2);
                        Partido6.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 7)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido7.Enabled = true;
                        P7E1.Text = "-";
                        P7E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P7E1.Text = Convert.ToString(lsMarcadores[7 - 1].PuntosE1);
                        P7E2.Text = Convert.ToString(lsMarcadores[7 - 1].PuntosE2);
                        Partido7.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 8)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido8.Enabled = true;
                        P8E1.Text = "-";
                        P8E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P8E1.Text = Convert.ToString(lsMarcadores[8 - 1].PuntosE1);
                        P8E2.Text = Convert.ToString(lsMarcadores[8 - 1].PuntosE2);
                        Partido8.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 9)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido9.Enabled = true;
                        P9E1.Text = "-";
                        P9E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P9E1.Text = Convert.ToString(lsMarcadores[9 - 1].PuntosE1);
                        P9E2.Text = Convert.ToString(lsMarcadores[9 - 1].PuntosE2);
                        Partido9.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 10)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido10.Enabled = true;
                        P10E1.Text = "-";
                        P10E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P10E1.Text = Convert.ToString(lsMarcadores[10 - 1].PuntosE1);
                        P10E2.Text = Convert.ToString(lsMarcadores[10 - 1].PuntosE2);
                        Partido10.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 11)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido11.Enabled = true;
                        P11E1.Text = "-";
                        P11E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P11E1.Text = Convert.ToString(lsMarcadores[11 - 1].PuntosE1);
                        P11E2.Text = Convert.ToString(lsMarcadores[11 - 1].PuntosE2);
                        Partido11.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 12)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido12.Enabled = true;
                        P12E1.Text = "-";
                        P12E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P12E1.Text = Convert.ToString(lsMarcadores[12 - 1].PuntosE1);
                        P12E2.Text = Convert.ToString(lsMarcadores[12 - 1].PuntosE2);
                        Partido12.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 13)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido13.Enabled = true;
                        P13E1.Text = "-";
                        P13E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P13E1.Text = Convert.ToString(lsMarcadores[13 - 1].PuntosE1);
                        P13E2.Text = Convert.ToString(lsMarcadores[13 - 1].PuntosE2);
                        Partido13.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 14)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido14.Enabled = true;
                        P14E1.Text = "-";
                        P14E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P14E1.Text = Convert.ToString(lsMarcadores[14 - 1].PuntosE1);
                        P14E2.Text = Convert.ToString(lsMarcadores[14 - 1].PuntosE2);
                        Partido14.Enabled = false;
                    }
                }

                else if (iter.IdPartido == 15)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido15.Enabled = true;
                        P15E1.Text = "-";
                        P15E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P15E1.Text = Convert.ToString(lsMarcadores[15 - 1].PuntosE1);
                        P15E2.Text = Convert.ToString(lsMarcadores[15 - 1].PuntosE2);
                        Partido15.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 16)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido16.Enabled = true;
                        P16E1.Text = "-";
                        P16E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P16E1.Text = Convert.ToString(lsMarcadores[16 - 1].PuntosE1);
                        P16E2.Text = Convert.ToString(lsMarcadores[16 - 1].PuntosE2);
                        Partido16.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 17)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido17.Enabled = true;
                        P17E1.Text = "-";
                        P17E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P17E1.Text = Convert.ToString(lsMarcadores[17 - 1].PuntosE1);
                        P17E2.Text = Convert.ToString(lsMarcadores[17 - 1].PuntosE2);
                        Partido17.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 18)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido18.Enabled = true;
                        P18E1.Text = "-";
                        P18E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P18E1.Text = Convert.ToString(lsMarcadores[18 - 1].PuntosE1);
                        P18E2.Text = Convert.ToString(lsMarcadores[18 - 1].PuntosE2);
                        Partido18.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 19)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido19.Enabled = true;
                        P19E1.Text = "-";
                        P19E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P19E1.Text = Convert.ToString(lsMarcadores[19 - 1].PuntosE1);
                        P19E2.Text = Convert.ToString(lsMarcadores[19 - 1].PuntosE2);
                        Partido19.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 20)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido20.Enabled = true;
                        P20E1.Text = "-";
                        P20E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P20E1.Text = Convert.ToString(lsMarcadores[20 - 1].PuntosE1);
                        P20E2.Text = Convert.ToString(lsMarcadores[20 - 1].PuntosE2);
                        Partido20.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 21)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido21.Enabled = true;
                        P21E1.Text = "-";
                        P21E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P21E1.Text = Convert.ToString(lsMarcadores[21 - 1].PuntosE1);
                        P21E2.Text = Convert.ToString(lsMarcadores[21 - 1].PuntosE2);
                        Partido21.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 22)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido22.Enabled = true;
                        P22E1.Text = "-";
                        P22E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P22E1.Text = Convert.ToString(lsMarcadores[22 - 1].PuntosE1);
                        P22E2.Text = Convert.ToString(lsMarcadores[22 - 1].PuntosE2);
                        Partido22.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 23)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido23.Enabled = true;
                        P23E1.Text = "-";
                        P23E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P23E1.Text = Convert.ToString(lsMarcadores[23 - 1].PuntosE1);
                        P23E2.Text = Convert.ToString(lsMarcadores[23 - 1].PuntosE2);
                        Partido23.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 24)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido24.Enabled = true;
                        P24E1.Text = "-";
                        P24E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P24E1.Text = Convert.ToString(lsMarcadores[24 - 1].PuntosE1);
                        P24E2.Text = Convert.ToString(lsMarcadores[24 - 1].PuntosE2);
                        Partido24.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 25)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido25.Enabled = true;
                        P25E1.Text = "-";
                        P25E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P25E1.Text = Convert.ToString(lsMarcadores[25 - 1].PuntosE1);
                        P25E2.Text = Convert.ToString(lsMarcadores[25 - 1].PuntosE2);
                        Partido25.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 26)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido26.Enabled = true;
                        P26E1.Text = "-";
                        P26E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P26E1.Text = Convert.ToString(lsMarcadores[26 - 1].PuntosE1);
                        P26E2.Text = Convert.ToString(lsMarcadores[26 - 1].PuntosE2);
                        Partido26.Enabled = false;
                    }

                }
                else if (iter.IdPartido == 26)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido26.Enabled = true;
                        P26E1.Text = "-";
                        P26E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P26E1.Text = Convert.ToString(lsMarcadores[26 - 1].PuntosE1);
                        P26E2.Text = Convert.ToString(lsMarcadores[26 - 1].PuntosE2);
                        Partido26.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 27)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido27.Enabled = true;
                        P27E1.Text = "-";
                        P27E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P27E1.Text = Convert.ToString(lsMarcadores[27 - 1].PuntosE1);
                        P27E2.Text = Convert.ToString(lsMarcadores[27 - 1].PuntosE2);
                        Partido27.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 28)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido28.Enabled = true;
                        P28E1.Text = "-";
                        P28E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P28E1.Text = Convert.ToString(lsMarcadores[28 - 1].PuntosE1);
                        P28E2.Text = Convert.ToString(lsMarcadores[28 - 1].PuntosE2);
                        Partido28.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 29)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido29.Enabled = true;
                        P29E1.Text = "-";
                        P29E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P29E1.Text = Convert.ToString(lsMarcadores[29 - 1].PuntosE1);
                        P29E2.Text = Convert.ToString(lsMarcadores[29 - 1].PuntosE2);
                        Partido29.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 30)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido30.Enabled = true;
                        P30E1.Text = "-";
                        P30E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P30E1.Text = Convert.ToString(lsMarcadores[30 - 1].PuntosE1);
                        P30E2.Text = Convert.ToString(lsMarcadores[30 - 1].PuntosE2);
                        Partido30.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 31)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido31.Enabled = true;
                        P31E1.Text = "-";
                        P31E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P31E1.Text = Convert.ToString(lsMarcadores[31 - 1].PuntosE1);
                        P31E2.Text = Convert.ToString(lsMarcadores[31 - 1].PuntosE2);
                        Partido31.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 32)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido32.Enabled = true;
                        P32E1.Text = "-";
                        P32E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P32E1.Text = Convert.ToString(lsMarcadores[32 - 1].PuntosE1);
                        P32E2.Text = Convert.ToString(lsMarcadores[32 - 1].PuntosE2);
                        Partido32.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 33)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido33.Enabled = true;
                        P33E1.Text = "-";
                        P33E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P33E1.Text = Convert.ToString(lsMarcadores[33 - 1].PuntosE1);
                        P33E2.Text = Convert.ToString(lsMarcadores[33 - 1].PuntosE2);
                        Partido33.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 34)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido34.Enabled = true;
                        P34E1.Text = "-";
                        P34E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P34E1.Text = Convert.ToString(lsMarcadores[34 - 1].PuntosE1);
                        P34E2.Text = Convert.ToString(lsMarcadores[34 - 1].PuntosE2);
                        Partido34.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 35)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido35.Enabled = true;
                        P35E1.Text = "-";
                        P35E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P35E1.Text = Convert.ToString(lsMarcadores[35-1].PuntosE1);
                        P35E2.Text = Convert.ToString(lsMarcadores[35-1].PuntosE2);
                        Partido35.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 36)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido36.Enabled = true;
                        P36E1.Text = "-";
                        P36E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P36E1.Text = Convert.ToString(lsMarcadores[36 - 1].PuntosE1);
                        P36E2.Text = Convert.ToString(lsMarcadores[36 - 1].PuntosE2);
                        Partido36.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 37)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido37.Enabled = true;
                        P37E1.Text = "-";
                        P37E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P37E1.Text = Convert.ToString(lsMarcadores[37 - 1].PuntosE1);
                        P37E2.Text = Convert.ToString(lsMarcadores[37 - 1].PuntosE2);
                        Partido37.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 38)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido38.Enabled = true;
                        P38E1.Text = "-";
                        P38E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P38E1.Text = Convert.ToString(lsMarcadores[38 - 1].PuntosE1);
                        P38E2.Text = Convert.ToString(lsMarcadores[38 - 1].PuntosE2);
                        Partido38.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 39)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido39.Enabled = true;
                        P39E1.Text = "-";
                        P39E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P39E1.Text = Convert.ToString(lsMarcadores[39 - 1].PuntosE1);
                        P39E2.Text = Convert.ToString(lsMarcadores[39 - 1].PuntosE2);
                        Partido39.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 40)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido40.Enabled = true;
                        P40E1.Text = "-";
                        P40E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P40E1.Text = Convert.ToString(lsMarcadores[40 - 1].PuntosE1);
                        P40E2.Text = Convert.ToString(lsMarcadores[40 - 1].PuntosE2);
                        Partido40.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 41)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido41.Enabled = true;
                        P41E1.Text = "-";
                        P41E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P41E1.Text = Convert.ToString(lsMarcadores[41 - 1].PuntosE1);
                        P41E2.Text = Convert.ToString(lsMarcadores[41 - 1].PuntosE2);
                        Partido41.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 42)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido42.Enabled = true;
                        P42E1.Text = "-";
                        P42E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P42E1.Text = Convert.ToString(lsMarcadores[42 - 1].PuntosE1);
                        P42E2.Text = Convert.ToString(lsMarcadores[42 - 1].PuntosE2);
                        Partido42.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 43)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido43.Enabled = true;
                        P43E1.Text = "-";
                        P43E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P43E1.Text = Convert.ToString(lsMarcadores[43 - 1].PuntosE1);
                        P43E2.Text = Convert.ToString(lsMarcadores[43 - 1].PuntosE2);
                        Partido43.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 44)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido44.Enabled = true;
                        P44E1.Text = "-";
                        P44E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P44E1.Text = Convert.ToString(lsMarcadores[44 - 1].PuntosE1);
                        P44E2.Text = Convert.ToString(lsMarcadores[44 - 1].PuntosE2);
                        Partido44.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 45)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido45.Enabled = true;
                        P45E1.Text = "-";
                        P45E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P45E1.Text = Convert.ToString(lsMarcadores[45 - 1].PuntosE1);
                        P45E2.Text = Convert.ToString(lsMarcadores[45 - 1].PuntosE2);
                        Partido45.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 46)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido46.Enabled = true;
                        P46E1.Text = "-";
                        P46E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P46E1.Text = Convert.ToString(lsMarcadores[46 - 1].PuntosE1);
                        P46E2.Text = Convert.ToString(lsMarcadores[46 - 1].PuntosE2);
                        Partido46.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 47)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido47.Enabled = true;
                        P47E1.Text = "-";
                        P47E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P47E1.Text = Convert.ToString(lsMarcadores[47 - 1].PuntosE1);
                        P47E2.Text = Convert.ToString(lsMarcadores[47 - 1].PuntosE2);
                        Partido47.Enabled = false;
                    }
                }
                else if (iter.IdPartido == 48)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        Partido48.Enabled = true;
                        P48E1.Text = "-";
                        P48E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P48E1.Text = Convert.ToString(lsMarcadores[48 - 1].PuntosE1);
                        P48E2.Text = Convert.ToString(lsMarcadores[48 - 1].PuntosE2);
                        Partido48.Enabled = false;
                    }
                }

            }



            //if (lsPArtidos[0].Estado == "p")
            //{
            //    Partido1.Enabled = true;
            //    P1E1.Text = "-";
            //    P1E1.Text = "-";

            //    List<Marcador> lsMarcadores = new List<Marcador>();

            //    lsMarcadores = MarcadorDAO.obtenerMarcador();
            //    P1E1.Text = Convert.ToString(lsMarcadores[0].PuntosE1);
            //    P1E2.Text = Convert.ToString(lsMarcadores[0].PuntosE2);
            //    Partido1.Enabled = false;
            //}
            //else
            //{
            //    Console.WriteLine("no reconocio el p");
            //}

        }

        private void jugarPartido(int idPArtido, int p1, int p2)
        {

            PartidoDAO.jugarPartido(idPArtido);
            MarcadorDAO.ingresarMarcador(idPArtido, p1, p2);

            List<Partido> partido = new List<Partido>();
            partido = PartidoDAO.buscarPartido(idPArtido);
            int E1 = partido[0].IdEquipo1;
            int E2 = partido[0].IdEquipo2;

            List<Equipo> equipo1 = new List<Equipo>();
            equipo1 = EquipoDAO.obtenerEquipo(E1);
            int partidosJugados1 = equipo1[0].PartidosJugados;
            int partidosGanados1 = equipo1[0].PartidosGanados;
            int partidosPerdidos1 = equipo1[0].PartidosPerdidos;
            int partidosEmpatados1 = equipo1[0].PartidosEmpatados;
            int golesFavor1 = equipo1[0].GolesFavor;
            int goleContra1 = equipo1[0].GolesContra;
            int puntos1 = equipo1[0].Puntos;

            List<Equipo> equipo2 = new List<Equipo>();
            equipo2 = EquipoDAO.obtenerEquipo(E2);
            int partidosJugados2 = equipo2[0].PartidosJugados;
            int partidosGanados2 = equipo2[0].PartidosGanados;
            int partidosPerdidos2 = equipo2[0].PartidosPerdidos;
            int partidosEmpatados2 = equipo2[0].PartidosEmpatados;
            int golesFavor2 = equipo2[0].GolesFavor;
            int goleContra2 = equipo2[0].GolesContra;
            int puntos2 = equipo2[0].Puntos;

            if (p1 > p2)
            {
                partidosJugados1++;
                partidosGanados1++;
                //partidosPerdidos1
                //partidosEmpatados1
                golesFavor1 = golesFavor1 + p1;
                goleContra1 = goleContra1 - p2;
                puntos1 = puntos1 + 3;

                partidosJugados2++;
                //partidosGanados2 
                partidosPerdidos2++;
                //partidosEmpatados2 
                golesFavor2 = golesFavor2 + p2;
                goleContra2 = goleContra2 - p1;
                puntos2 = puntos2 + 0;

                EquipoDAO.editarEquipo(partidosJugados1, partidosGanados1, partidosPerdidos1, partidosEmpatados1, golesFavor1, goleContra1, puntos1, E1);
                EquipoDAO.editarEquipo(partidosJugados2, partidosGanados2, partidosPerdidos2, partidosEmpatados2, golesFavor2, goleContra2, puntos2, E2);
            }
            else if (p2 > p1)
            {
                partidosJugados1++;
                //partidosGanados1++;
                partidosPerdidos1++;
                //partidosEmpatados1
                golesFavor1 = golesFavor1 + p1;
                goleContra1 = goleContra1 - p2;
                puntos1 = puntos1 + 0;

                partidosJugados2++;
                partidosGanados2++; 
                //partidosPerdidos2++;
                //partidosEmpatados2 
                golesFavor2 = golesFavor2 + p2;
                goleContra2 = goleContra2 - p1;
                puntos2 = puntos2 + 3;

                EquipoDAO.editarEquipo(partidosJugados1, partidosGanados1, partidosPerdidos1, partidosEmpatados1, golesFavor1, goleContra1, puntos1, E1);
                EquipoDAO.editarEquipo(partidosJugados2, partidosGanados2, partidosPerdidos2, partidosEmpatados2, golesFavor2, goleContra2, puntos2, E2);
            }
            else if (p1 == p2)
            {
                partidosJugados1++;
                //partidosGanados1++;
                //partidosPerdidos1++;
                partidosEmpatados1++;
                golesFavor1 = golesFavor1 + p1;
                goleContra1 = goleContra1 - p2;
                puntos1 = puntos1 + 1;

                partidosJugados2++;
                //partidosGanados2++;
                //partidosPerdidos2++;
                partidosEmpatados2++;
                golesFavor2 = golesFavor2 + p2;
                goleContra2 = goleContra2 - p1;
                puntos2 = puntos2 + 1;

                EquipoDAO.editarEquipo(partidosJugados1, partidosGanados1, partidosPerdidos1, partidosEmpatados1, golesFavor1, goleContra1, puntos1, E1);
                EquipoDAO.editarEquipo(partidosJugados2, partidosGanados2, partidosPerdidos2, partidosEmpatados2, golesFavor2, goleContra2, puntos2, E2);

            }
        }
    }
}
