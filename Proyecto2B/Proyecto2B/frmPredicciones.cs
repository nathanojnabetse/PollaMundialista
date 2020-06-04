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
    public partial class frmPredicciones : Form
    {
        public frmPredicciones()
        {
            InitializeComponent();
        }

        Usuario usuario;
        Grupo grupo;
        UserGrupo userGrupo;
        string cadena;

        public frmPredicciones(Grupo grupo, Usuario usuario, String cadena)
        {
            this.grupo = grupo;
            this.usuario = usuario;
            this.cadena = cadena;

            InitializeComponent();
        }

        List<String> lista = new List<string>();

        string a = "Rusia" + "\t\t  JUN 14 - 17:00" + "\t\t  Arabia Saudí";

        string b = "Egipto" + "\t\t  JUN 15 - 14:00" + "\t\t Uruguay";
        string c = "Marruecos" + "\t  JUN 15 - 17:00" + "\t\t Irán";
        string d = "Portugal" + "\t\t  JUN 15 - 20:00" + "\t\t  España";

        string ee = "Francia" + "\t\t  JUN 16 - 12:00" + "\t\t Australia  ";
        string f = "Argentina" + "\t\t  JUN 16 - 15:00" + "\t\t  Islandia";
        string g = "Perú" + "\t\t  JUN 16 - 18:00" + "\t\t  Dinamarca";
        string h = "Croacia" + "\t\t  JUN 16 - 21:00" + "\t\t  Nigeria";

        string i = "Costa Rica" + "\t  JUN 17 - 14:00" + "\t\t  Serbia";
        string j = "Alemania" + "\t\t  JUN 17 - 17:00" + "\t\t  México";
        string k = "Brasil" + "\t\t  JUN 17 - 20:00" + "\t\t  Suiza";

        string l = "Suecia" + "\t\t  JUN 18 - 14:00" + "\t\t  Corea Sur";
        string m = "Bélgica" + "\t\t  JUN 18 - 17:00" + "\t\t  Panamá";
        string n = "Túnez" + "\t\t  JUN 18 - 20:00" + "\t\t  Inglaterra";

        string o = "colombia" + "\t\t  JUN 19 - 14:00" + "\t\t  Japón";
        string p = "Plonia" + "\t\t  JUN 19 - 17:00" + "\t\t  Senegal";
        string q = "Rusia" + "\t\t  JUN 19 - 20:00" + "\t\t  Egipto";

        string r = "Portugal" + "\t\t  JUN 20 - 14:00" + "\t\t  Marruecos";
        string s = "Uruguay" + "\t\t  JUN 20 - 17:00" + "\t\t  Arabia Saudí";
        string t = "Irán" + "\t\t  JUN 20 - 20:00" + "\t\t  España";

        string u = "Dinamarca" + "\t JUN 21 - 14:00" + "\t\t  Australia";
        string v = "Francia" + "\t\t  JUN 21 - 16:00" + "\t\t  Perú";
        string w = "Argentina" + "\t\t  JUN 21 - 20:00" + "\t\t  Croacia";

        string x = "Brasil" + "\t\t  JUN 22 - 14:00" + "\t\t  Costa Rica";
        string y = "Nigeria" + "\t\t  JUN 22 - 27:00" + "\t\t  Islandia";
        string z = "Serbia" + "\t\t  JUN 22 - 20:00" + "\t\t  Suiza";

        string aa = "Bélgica" + "\t\t JUN 23 - 14 :00" + "\t\t  Túnez";
        string ba = "Corea Sur" + "\t  JUN 23 - 17:00" + "\t\t  México";
        string ca = "Alemania" + "\t\t  JUN 23 - 20:00" + "\t\t  Suecia";

        string da = "Inglaterra" + "\t\t JUN 24 - 14:00" + "\t\t  Panamá";
        string ea = "Japón" + "\t\t  JUN 24 - 17:00" + "\t\t  Senegal";
        string fa = "Polona" + "\t\t  JUN 24 - 20:00" + "\t\t  Colombia";

        string ga = "Arabia Saudí" + "\t  JUN 25 - 14:00" + "\t\t  Egipto  ";
        string ha = "Uruguay" + "\t\t JUN 25 - 16:00" + "\t\t  Rusia";
        string ia = "España" + "\t\t  JUN 25 - 20:00" + "\t\t  Marruecos";
        string ja = "Irpan" + "\t\t  JUN 25 - 20:00" + "\t\t  Portugal";

        string ka = "Dinamarca" + "\t  JUN 26 - 16:00" + "\t\t  Francia  ";
        string la = "Australia" + "\t\t  JUN 26 - 16:00" + "\t\t Perú";
        string ma = "Islandia" + "\t\t  JUN 26 - 20:00" + "\t\t  Croacia";
        string na = "Nigeria" + "\t\t  JUN 26 - 20:00" + "\t\t  Argentina";

        string oa = "Corea Sur " + "\t  JUN 27 - 14:00" + "\t\t  Alemania  ";
        string pa = "México" + "\t\t  JUN 27 - 16:00" + "\t\t  Suecia";
        string qa = "Serbia" + "\t\t  JUN 27 - 20:00" + "\t\t  Brasil";
        string ra = "Suiza" + "\t\t  JUN 27 - 20:00" + "\t\t  Costa Rica";

        string sa = "Senegal" + "\t\t  JUN 28 - 16:00" + "\t\t  Colombia  ";
        string ta = "Japón" + "\t\t  JUN 28 - 16:00" + "\t\t  Polonia";
        string ua = "Inglaterra" + "\t\t  JUN 28 - 20:00" + "\t\t  Bélgica";
        string va = "Panamá" + "\t\t  JUN 28 - 20:00" + "\t\t  Túnez";

        public List<string> Lista { get => lista; set => lista = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Grupo Grupo { get => Grupo; set => Grupo = value; }
        public string Cadena { get => cadena; set => cadena = value; }
        internal UserGrupo UserGrupo { get => userGrupo; set => userGrupo = value; }

      

        private void frmPredicciones_Load_1(object sender, EventArgs e)
        {
            Lista.Add(a); Lista.Add(b); Lista.Add(c); Lista.Add(d); Lista.Add(ee); Lista.Add(f); Lista.Add(g); Lista.Add(h); Lista.Add(i);
            Lista.Add(j); Lista.Add(k); Lista.Add(l); Lista.Add(m); Lista.Add(n); Lista.Add(o); Lista.Add(p); Lista.Add(q); Lista.Add(r);
            Lista.Add(s); Lista.Add(t); Lista.Add(u); Lista.Add(v); Lista.Add(w); Lista.Add(x); Lista.Add(y); Lista.Add(z); Lista.Add(aa);
            Lista.Add(ba); Lista.Add(ca); Lista.Add(da); Lista.Add(ea); Lista.Add(fa); Lista.Add(ga); Lista.Add(ha); Lista.Add(ia);
            Lista.Add(ja); Lista.Add(ka); Lista.Add(la); Lista.Add(ma); Lista.Add(na); Lista.Add(oa); Lista.Add(pa); Lista.Add(qa); Lista.Add(ra);
            Lista.Add(sa); Lista.Add(ta); Lista.Add(ua); Lista.Add(va);

            lbxApuestas.Items.Clear();
            foreach (string iter in Lista)
            {
                lbxApuestas.Items.Add(iter);
            }
        }

        private void lbxApuestas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            cadena = (string)lbxApuestas.SelectedItem;
            int numero = (int)lbxApuestas.SelectedIndex + 1;
            Console.WriteLine(numero);
            frmApuesta frmApuesta = new frmApuesta(grupo, usuario, cadena, numero);
            frmApuesta.Show();
        }
    }
}
