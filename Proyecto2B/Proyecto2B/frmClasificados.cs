using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto2B
{
    public partial class frmClasificados : Form
    {
        public frmClasificados()
        {
            InitializeComponent();
        }

        private void frmClasificados_Load(object sender, EventArgs e)
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

          
  
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ1, " ", lsClasificados[0].Equipo11));
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ2, " ", lsClasificados[0].Equipo21));
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ3, " ", lsClasificados[0].Equipo31));
            lsOrdenadosA.Add(string.Concat(lsClasificados[0].PuntosEQ4, " ", lsClasificados[0].Equipo41));

            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ1, " ", lsClasificados[1].Equipo11));
            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ2, " ", lsClasificados[1].Equipo21));
            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ3, " ", lsClasificados[1].Equipo31));
            lsOrdenadosB.Add(string.Concat(lsClasificados[1].PuntosEQ4, " ", lsClasificados[1].Equipo41));

            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ1, " ", lsClasificados[2].Equipo11));
            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ2, " ", lsClasificados[2].Equipo21));
            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ3, " ", lsClasificados[2].Equipo31));
            lsOrdenadosC.Add(string.Concat(lsClasificados[2].PuntosEQ4, " ", lsClasificados[2].Equipo41));

            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ1, " ", lsClasificados[3].Equipo11));
            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ2, " ", lsClasificados[3].Equipo21));
            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ3, " ", lsClasificados[3].Equipo31));
            lsOrdenadosD.Add(string.Concat(lsClasificados[3].PuntosEQ4, " ", lsClasificados[3].Equipo41));

            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ1, " ", lsClasificados[4].Equipo11));
            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ2, " ", lsClasificados[4].Equipo21));
            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ3, " ", lsClasificados[4].Equipo31));
            lsOrdenadosE.Add(string.Concat(lsClasificados[4].PuntosEQ4, " ", lsClasificados[4].Equipo41));

            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ1, " ", lsClasificados[5].Equipo11));
            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ2, " ", lsClasificados[5].Equipo21));
            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ3, " ", lsClasificados[5].Equipo31));
            lsOrdenadosF.Add(string.Concat(lsClasificados[5].PuntosEQ4, " ", lsClasificados[5].Equipo41));

            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ1, " ", lsClasificados[6].Equipo11));
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ2, " ", lsClasificados[6].Equipo21));
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ3, " ", lsClasificados[6].Equipo31));
            lsOrdenadosG.Add(string.Concat(lsClasificados[6].PuntosEQ4, " ", lsClasificados[6].Equipo41));

            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ1, " ", lsClasificados[7].Equipo11));
            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ2, " ", lsClasificados[7].Equipo21));
            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ3, " ", lsClasificados[7].Equipo31));
            lsOrdenadosH.Add(string.Concat(lsClasificados[7].PuntosEQ4, " ", lsClasificados[7].Equipo41));

            lbxOrdenado(lsOrdenadosA, lbxA);
            lbxOrdenado(lsOrdenadosB, lbxB);
            lbxOrdenado(lsOrdenadosC, lbxC);
            lbxOrdenado(lsOrdenadosD, lbxD);
            lbxOrdenado(lsOrdenadosE, lbxE);
            lbxOrdenado(lsOrdenadosF, lbxF);
            lbxOrdenado(lsOrdenadosG, lbxG);
            lbxOrdenado(lsOrdenadosH, lbxH);

        }

        public static void lbxOrdenado(List<String> lsPorOrdenar, ListBox lbx)
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
            lsFinal.Add(lsPorOrdenar[3]);
            lsFinal.Add(lsPorOrdenar[2]);
            lsFinal.Add(lsPorOrdenar[1]);
            lsFinal.Add(lsPorOrdenar[0]);

            foreach (var iter in lsFinal)
            {

                lbx.Items.Add(iter);
            }

        }
    }
}
