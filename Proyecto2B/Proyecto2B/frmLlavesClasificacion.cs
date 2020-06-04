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
    public partial class frmLlavesClasificacion : Form
    {
        public frmLlavesClasificacion(int v)
        {
            InitializeComponent();
            if (v == 1)
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


        Random rnd = new Random();


        private void partido49_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P49C1.Text = Convert.ToString(gol1);
            P49D2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P49C1.Text);
            int p2 = Convert.ToInt32(P49D2.Text);

            jugarPartido(49, p1, p2);
            partido49.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[49 - 1].IdEquipo1, 57);
                cargar(banderita(lsAUx[49 - 1].IdEquipo1), G49);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[49 - 1].IdEquipo2, 57);
                cargar(banderita(lsAUx[49 - 1].IdEquipo2), G49);
            }


        }



        private void partido50_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P50A1.Text = Convert.ToString(gol1);
            P50B2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P50A1.Text);
            int p2 = Convert.ToInt32(P50B2.Text);

            jugarPartido(50, p1, p2);
            partido50.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[50 - 1].IdEquipo1, 57);
                cargar(banderita(lsAUx[50 - 1].IdEquipo1), G50);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[50 - 1].IdEquipo2, 57);
                cargar(banderita(lsAUx[50 - 1].IdEquipo2), G50);
            }


        }

        private void partido51_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P51B1.Text = Convert.ToString(gol1);
            P51A2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P51B1.Text);
            int p2 = Convert.ToInt32(P51A2.Text);

            jugarPartido(51, p1, p2);
            partido51.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[51 - 1].IdEquipo1, 60);

                cargar(banderita(lsAUx[51 - 1].IdEquipo1), G51);

            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[51 - 1].IdEquipo2, 60);
                cargar(banderita(lsAUx[51 - 1].IdEquipo2), G51);
            }


        }

        private void partido52_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P52D1.Text = Convert.ToString(gol1);
            P52C2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P52D1.Text);
            int p2 = Convert.ToInt32(P52C2.Text);

            jugarPartido(52, p1, p2);
            partido52.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[52 - 1].IdEquipo1, 60);
                cargar(banderita(lsAUx[52 - 1].IdEquipo1), G52);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[52 - 1].IdEquipo2, 60);
                cargar(banderita(lsAUx[52 - 1].IdEquipo2), G52);
            }
        }

        private void partido53_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P53E1.Text = Convert.ToString(gol1);
            P53F2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P53E1.Text);
            int p2 = Convert.ToInt32(P53F2.Text);

            jugarPartido(53, p1, p2);
            partido53.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[53 - 1].IdEquipo1, 58);
                cargar(banderita(lsAUx[53 - 1].IdEquipo1), G53);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[53 - 1].IdEquipo2, 58);
                cargar(banderita(lsAUx[53 - 1].IdEquipo2), G53);
            }
        }

        private void partido54_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P54G1.Text = Convert.ToString(gol1);
            P54H2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P54G1.Text);
            int p2 = Convert.ToInt32(P54H2.Text);

            jugarPartido(54, p1, p2);
            partido54.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[54 - 1].IdEquipo1, 58);
                cargar(banderita(lsAUx[54 - 1].IdEquipo1), G54);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[54 - 1].IdEquipo2, 58);
                cargar(banderita(lsAUx[54 - 1].IdEquipo2), G54);
            }

        }

        private void partido55_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P55F1.Text = Convert.ToString(gol1);
            P55E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P55F1.Text);
            int p2 = Convert.ToInt32(P55E2.Text);

            jugarPartido(55, p1, p2);
            partido55.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[55 - 1].IdEquipo1, 59);
                cargar(banderita(lsAUx[55 - 1].IdEquipo1), G55);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[55 - 1].IdEquipo2, 59);
                cargar(banderita(lsAUx[55 - 1].IdEquipo2), G55);
            }
        }

        private void partido56_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P56H1.Text = Convert.ToString(gol1);
            P56G2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P56H1.Text);
            int p2 = Convert.ToInt32(P56G2.Text);

            jugarPartido(56, p1, p2);
            partido56.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[56 - 1].IdEquipo1, 59);
                cargar(banderita(lsAUx[56 - 1].IdEquipo1), G56);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[56 - 1].IdEquipo2, 59);
                cargar(banderita(lsAUx[56 - 1].IdEquipo2), G56);
            }

        }
    
    

        private void partido57_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P57E1.Text = Convert.ToString(gol1);
            P57E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P57E1.Text);
            int p2 = Convert.ToInt32(P57E2.Text);

            jugarPartido(57, p1, p2);
            partido57.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[57 - 1].IdEquipo1, 61);
                cargar(banderita(lsAUx[57 - 1].IdEquipo1), G57);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[57 - 1].IdEquipo2, 61);
                cargar(banderita(lsAUx[57 - 1].IdEquipo2), G57); 
            }
        }

        private void partido58_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P58E1.Text = Convert.ToString(gol1);
            P58E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P58E1.Text);
            int p2 = Convert.ToInt32(P58E2.Text);

            jugarPartido(58, p1, p2);
            partido58.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[58 - 1].IdEquipo1, 61);
                cargar(banderita(lsAUx[58 - 1].IdEquipo1), G58);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[58 - 1].IdEquipo2, 61);
                cargar(banderita(lsAUx[58 - 1].IdEquipo2), G58);
            }

        }

        private void partido59_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P59E1.Text = Convert.ToString(gol1);
            P59E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P59E1.Text);
            int p2 = Convert.ToInt32(P59E2.Text);

            jugarPartido(59, p1, p2);
            partido59.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[59 - 1].IdEquipo1, 62);
                cargar(banderita(lsAUx[59 - 1].IdEquipo1), G59);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[59 - 1].IdEquipo2, 62);
                cargar(banderita(lsAUx[59 - 1].IdEquipo2), G59);
            }

        }

        private void partido60_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P60E1.Text = Convert.ToString(gol1);
            P60E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P60E1.Text);
            int p2 = Convert.ToInt32(P60E2.Text);

            jugarPartido(60, p1, p2);
            partido60.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[60 - 1].IdEquipo1, 62);
                cargar(banderita(lsAUx[60 - 1].IdEquipo1), G60);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[60 - 1].IdEquipo2, 62);
                cargar(banderita(lsAUx[60 - 1].IdEquipo2), G60);
            }

        }

        private void partido61_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P61E1.Text = Convert.ToString(gol1);
            P61E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P61E1.Text);
            int p2 = Convert.ToInt32(P61E2.Text);

            jugarPartido(61, p1, p2);
            partido61.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[61 - 1].IdEquipo1, 64);
                PartidoDAO.EditarPartidoE2(lsAUx[61 - 1].IdEquipo2, 63);
                cargar(banderita(lsAUx[61 - 1].IdEquipo1), G61);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE1(lsAUx[61 - 1].IdEquipo2, 64);
                PartidoDAO.EditarPartidoE2(lsAUx[61 - 1].IdEquipo1, 63);
                cargar(banderita(lsAUx[61 - 1].IdEquipo2), G61);
               
            }


        }

        private void partido62_CheckedChanged(object sender, EventArgs e)
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P62E1.Text = Convert.ToString(gol1);
            P62E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P62E1.Text);
            int p2 = Convert.ToInt32(P62E2.Text);

            jugarPartido(62, p1, p2);
            partido62.Enabled = false;


            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            if (p1 > p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[62 - 1].IdEquipo1, 64);
                PartidoDAO.EditarPartidoE1(lsAUx[62 - 1].IdEquipo2, 63);
                cargar(banderita(lsAUx[62 - 1].IdEquipo1), G62);
            }
            else if (p1 < p2)
            {
                PartidoDAO.EditarPartidoE2(lsAUx[62 - 1].IdEquipo2, 64);
                PartidoDAO.EditarPartidoE1(lsAUx[62 - 1].IdEquipo1, 63);
                cargar(banderita(lsAUx[62 - 1].IdEquipo2), G62);
            }


        }

        private void partido64_CheckedChanged(object sender, EventArgs e)
        {
            tercerpuesto();

            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            P64E1.Text = Convert.ToString(gol1);
            P64E2.Text = Convert.ToString(gol2);

            int p1 = Convert.ToInt32(P64E1.Text);
            int p2 = Convert.ToInt32(P64E2.Text);

            jugarPartido(64, p1, p2);
            partido64.Enabled = false;

            List<Partido> lsAUx = new List<Partido>();
            lsAUx = PartidoDAO.obtenerPartido();

            cargar(banderita(lsAUx[64 - 1].IdEquipo1), G61);
            cargar(banderita(lsAUx[64 - 1].IdEquipo2), G62);



        }

        private void tercerpuesto()
        {
            int gol1 = rnd.Next(0, 10);
            int gol2 = rnd.Next(0, 10);

            if (gol1 == gol2)
            {
                gol1 = gol1 + 1;
            }

            int p1 = gol1;
            int p2 = gol2;

            jugarPartido(63, p1, p2);

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

        private void frmLlavesClasificacion_Load(object sender, EventArgs e)
        {
            List<Partido> lsAuxPartidos = new List<Partido>();

            lsAuxPartidos = PartidoDAO.obtenerPartido();

            foreach (var iter in lsAuxPartidos)
            {
                if (iter.IdPartido == 49)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido49.Enabled = true;
                        P49C1.Text = "-";
                        P49D2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();

                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P49C1.Text = Convert.ToString(lsMarcadores[49 - 1].PuntosE1);
                        P49D2.Text = Convert.ToString(lsMarcadores[49 - 1].PuntosE2);
                        partido49.Enabled = false;                                             



                    }
                    cargar(banderita(lsAuxPartidos[49 - 1].IdEquipo1), C1);
                    cargar(banderita(lsAuxPartidos[49 - 1].IdEquipo2), D2);
                }
                else if (iter.IdPartido == 50)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido50.Enabled = true;
                        P50A1.Text = "-";
                        P50B2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P50A1.Text = Convert.ToString(lsMarcadores[50 - 1].PuntosE1);
                        P50B2.Text = Convert.ToString(lsMarcadores[50 - 1].PuntosE2);
                        partido50.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[50 - 1].IdEquipo1), A1);
                    cargar(banderita(lsAuxPartidos[50 - 1].IdEquipo2), B2);
                }
                else if (iter.IdPartido == 51)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido51.Enabled = true;
                        P51A2.Text = "-";
                        P51B1.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P51B1.Text = Convert.ToString(lsMarcadores[51 - 1].PuntosE1);
                        P51A2.Text = Convert.ToString(lsMarcadores[51 - 1].PuntosE2);
                        partido51.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[51 - 1].IdEquipo1), B1);
                    cargar(banderita(lsAuxPartidos[51 - 1].IdEquipo2), A2);
                }
                else if (iter.IdPartido == 52)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido52.Enabled = true;
                        P52D1.Text = "-";
                        P52C2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P52D1.Text = Convert.ToString(lsMarcadores[52 - 1].PuntosE1);
                        P52C2.Text = Convert.ToString(lsMarcadores[52 - 1].PuntosE2);
                        partido52.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[52 - 1].IdEquipo1), D1);
                    cargar(banderita(lsAuxPartidos[52 - 1].IdEquipo2), C2);
                }
                else if (iter.IdPartido == 53)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido53.Enabled = true;
                        P53E1.Text = "-";
                        P53F2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P53E1.Text = Convert.ToString(lsMarcadores[53 - 1].PuntosE1);
                        P53F2.Text = Convert.ToString(lsMarcadores[53 - 1].PuntosE2);
                        partido53.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[53 - 1].IdEquipo1), E1);
                    cargar(banderita(lsAuxPartidos[53 - 1].IdEquipo2), F2);
                }
                else if (iter.IdPartido == 54)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido54.Enabled = true;
                        P54G1.Text = "-";
                        P54H2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P54G1.Text = Convert.ToString(lsMarcadores[54 - 1].PuntosE1);
                        P54H2.Text = Convert.ToString(lsMarcadores[54 - 1].PuntosE2);
                        partido54.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[54 - 1].IdEquipo1), G1);
                    cargar(banderita(lsAuxPartidos[54 - 1].IdEquipo2), H2);
                }
                else if (iter.IdPartido == 55)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido55.Enabled = true;
                        P55F1.Text = "-";
                        P55E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P55F1.Text = Convert.ToString(lsMarcadores[55 - 1].PuntosE1);
                        P55E2.Text = Convert.ToString(lsMarcadores[55 - 1].PuntosE2);
                        partido55.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[55 - 1].IdEquipo1), F1);
                    cargar(banderita(lsAuxPartidos[55 - 1].IdEquipo2), E2);
                }
                else if (iter.IdPartido == 56)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido56.Enabled = true;
                        P56H1.Text = "-";
                        P56G2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P56H1.Text = Convert.ToString(lsMarcadores[56 - 1].PuntosE1);
                        P56G2.Text = Convert.ToString(lsMarcadores[56 - 1].PuntosE2);
                        partido56.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[56 - 1].IdEquipo1), H1);
                    cargar(banderita(lsAuxPartidos[56 - 1].IdEquipo2), G2);
                }
                else if (iter.IdPartido == 57)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido57.Enabled = true;
                        P57E1.Text = "-";
                        P57E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P57E1.Text = Convert.ToString(lsMarcadores[57 - 1].PuntosE1);
                        P57E2.Text = Convert.ToString(lsMarcadores[57 - 1].PuntosE2);
                        partido57.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[57 - 1].IdEquipo1), G49);
                    cargar(banderita(lsAuxPartidos[57 - 1].IdEquipo2), G50);
                }
                else if (iter.IdPartido == 58)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido58.Enabled = true;
                        P58E1.Text = "-";
                        P58E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P58E1.Text = Convert.ToString(lsMarcadores[58 - 1].PuntosE1);
                        P58E2.Text = Convert.ToString(lsMarcadores[58 - 1].PuntosE2);
                        partido58.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[58 - 1].IdEquipo1), G53);
                    cargar(banderita(lsAuxPartidos[58 - 1].IdEquipo2), G54);
                }
                else if (iter.IdPartido == 59)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido59.Enabled = true;
                        P59E1.Text = "-";
                        P59E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P59E1.Text = Convert.ToString(lsMarcadores[59 - 1].PuntosE1);
                        P59E2.Text = Convert.ToString(lsMarcadores[59 - 1].PuntosE2);
                        partido59.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[59 - 1].IdEquipo1), G55);
                    cargar(banderita(lsAuxPartidos[59 - 1].IdEquipo2), G56);
                }
                else if (iter.IdPartido == 60)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido60.Enabled = true;
                        P60E1.Text = "-";
                        P60E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P60E1.Text = Convert.ToString(lsMarcadores[60 - 1].PuntosE1);
                        P60E2.Text = Convert.ToString(lsMarcadores[60 - 1].PuntosE2);
                        partido60.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[60 - 1].IdEquipo1), G51);
                    cargar(banderita(lsAuxPartidos[60 - 1].IdEquipo2), G52);
                }
                else if (iter.IdPartido == 60)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido60.Enabled = true;
                        P60E1.Text = "-";
                        P60E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P60E1.Text = Convert.ToString(lsMarcadores[60 - 1].PuntosE1);
                        P60E2.Text = Convert.ToString(lsMarcadores[60 - 1].PuntosE2);
                        partido60.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[60 - 1].IdEquipo1), G51);
                    cargar(banderita(lsAuxPartidos[60 - 1].IdEquipo2), G52);
                }
                else if (iter.IdPartido == 61)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido61.Enabled = true;
                        P61E1.Text = "-";
                        P61E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P61E1.Text = Convert.ToString(lsMarcadores[61 - 1].PuntosE1);
                        P61E2.Text = Convert.ToString(lsMarcadores[61 - 1].PuntosE2);
                        partido61.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[61 - 1].IdEquipo1), G57);
                    cargar(banderita(lsAuxPartidos[61 - 1].IdEquipo2), G58);
                }
                else if (iter.IdPartido == 62)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido62.Enabled = true;
                        P62E1.Text = "-";
                        P62E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P62E1.Text = Convert.ToString(lsMarcadores[62 - 1].PuntosE1);
                        P62E2.Text = Convert.ToString(lsMarcadores[62 - 1].PuntosE2);
                        partido62.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[62 - 1].IdEquipo1), G60);
                    cargar(banderita(lsAuxPartidos[62 - 1].IdEquipo2), G59);
                }
                else if (iter.IdPartido == 64)
                {
                    if (iter.Estado.Equals("p"))
                    {
                        partido64.Enabled = true;
                        P64E1.Text = "-";
                        P64E2.Text = "-";
                    }
                    else
                    {
                        List<Marcador> lsMarcadores = new List<Marcador>();
                        lsMarcadores = MarcadorDAO.obtenerMarcador();
                        P64E1.Text = Convert.ToString(lsMarcadores[64 - 1].PuntosE1);
                        P64E2.Text = Convert.ToString(lsMarcadores[64 - 1].PuntosE2);
                        partido64.Enabled = false;

                    }
                    cargar(banderita(lsAuxPartidos[64 - 1].IdEquipo1), G61);
                    cargar(banderita(lsAuxPartidos[64 - 1].IdEquipo2), G62);
                }







            }
        }

        private void cargar(string imagen,PictureBox picture)
        {
            picture.Image = Image.FromFile(@"C:\Users\PERSONAL\Documents\POLI\6 Semestre\Programación con Herramientas Visuales\Proyecto2 BIM\8.0\Proyecto2B\Proyecto2B\Resources\" + imagen);
        }

        private string banderita(int nombreEquipo)
        {
            

            if (nombreEquipo == 1) { return "Rusia.png"; }
            else if (nombreEquipo == 2) { return "Arabia_Saudita.png"; }
            else if (nombreEquipo == 3) { return "Egipto.png"; }
            else if (nombreEquipo == 4) { return "Uruguay.png"; }
            else if (nombreEquipo == 5) { return "Portugal.png"; }
            else if (nombreEquipo == 6) { return "España.png"; }
            else if (nombreEquipo == 7) { return "Marruecos.png"; }
            else if (nombreEquipo == 8) { return "Iran.png"; }
            else if (nombreEquipo == 9) { return "Francia.png"; }
            else if (nombreEquipo == 10) { return "Australia.png"; }
            else if (nombreEquipo == 11) { return "Peru.png"; }
            else if (nombreEquipo == 12) { return "Dinamarca.png"; }
            else if (nombreEquipo == 13) { return "Argentina.png"; }
            else if (nombreEquipo == 14) { return "Islandia.png"; }
            else if (nombreEquipo == 15) { return "Croacia.png"; }
            else if (nombreEquipo == 16) { return "Nigeria.png"; }
            else if (nombreEquipo == 17) { return "Brasil.png"; }
            else if (nombreEquipo == 18) { return "Suiza.png"; }
            else if (nombreEquipo == 19) { return "Costa_Rica.png"; }
            else if (nombreEquipo == 20) { return "Serbia.png"; }
            else if (nombreEquipo == 21) { return "Alemania.png"; }
            else if (nombreEquipo == 22) { return "Mexico.png"; }
            else if (nombreEquipo == 23) { return "Suecia.png"; }
            else if (nombreEquipo == 24) { return "Corea_del_Sur.png"; }
            else if (nombreEquipo == 25) { return "Belgica.png"; }
            else if (nombreEquipo == 26) { return "Panama.png"; }
            else if (nombreEquipo == 27) { return "Tunez.png"; }
            else if (nombreEquipo == 28) { return "Inglaterra.png"; }
            else if (nombreEquipo == 29) { return "Polonia.png"; }
            else if (nombreEquipo == 30) { return "Senegal.png"; }
            else if (nombreEquipo == 31) { return "Colombia.png"; }
            else if (nombreEquipo == 32) { return "Japon.png"; }
            return " ";

           
        }
    }
}
