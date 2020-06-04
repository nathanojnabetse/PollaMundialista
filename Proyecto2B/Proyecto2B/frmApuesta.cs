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
    public partial class frmApuesta : Form
    {
        public frmApuesta()
        {
            InitializeComponent();
        }

        Grupo grupo;

        private Usuario usuario;
        string cadena;
        int numero;
        List<int> lsGoles = new List<int>();

        public Grupo Grupo { get => grupo; set => grupo = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string Cadena { get => cadena; set => cadena = value; }
        public int Numero { get => numero; set => numero = value; }

        public frmApuesta(Grupo grupo, Usuario usuario, String cadena, int numero)
        {
            this.grupo = grupo;
            this.usuario = usuario;
            this.cadena = cadena;
            this.numero = numero;
            InitializeComponent();
        }

        private void listaGoles1()
        {
            lsGoles.Add(0); lsGoles.Add(1); lsGoles.Add(2); lsGoles.Add(1); lsGoles.Add(3); lsGoles.Add(4); lsGoles.Add(5);
            lsGoles.Add(6); lsGoles.Add(7); lsGoles.Add(8); lsGoles.Add(9); lsGoles.Add(10);
            cbxPuntos1.Items.Clear();
            foreach (int puntos in lsGoles)
            {
                cbxPuntos1.Items.Add(puntos);
            }
        }

        private void listaGoles2()
        {
            lsGoles.Add(0); lsGoles.Add(1); lsGoles.Add(2); lsGoles.Add(1); lsGoles.Add(3); lsGoles.Add(4); lsGoles.Add(5);
            lsGoles.Add(6); lsGoles.Add(7); lsGoles.Add(8); lsGoles.Add(9); lsGoles.Add(10);
            cbxPuntos2.Items.Clear();
            foreach (int puntos in lsGoles)
            {
                cbxPuntos2.Items.Add(puntos);
            }
        }



        List<Marcador> marcadores;
        List<Reglas> reglas;
        Random rnd = new Random();

        private int sumarPuntos()
        {
            int suma = 0;
            marcadores = MarcadorDAO.obtenerMarcadorID(numero);
            Marcador marcador = marcadores.First();

            reglas = ReglasDAO.obtenerReglasID(grupo.Id);
            Reglas regla = reglas.First();

            int p1 = marcador.PuntosE1;
            int p2 = marcador.PuntosE2;

            int punto1 = (int)cbxPuntos1.SelectedItem;
            int punto2 = (int)cbxPuntos2.SelectedItem;


            int a = rnd.Next(0, 3);
            suma = usuario.PuntoAcumulados + a;
            usuario.PuntoAcumulados = suma; 

            //if (punto1 == p1 && punto2 == p2)
            //{
            //    suma = usuario.PuntoAcumulados + regla.MarcadorExactoAcertado;

            //}
            //if (punto1 == p1 || punto2 == p2)
            //{
            //    suma = usuario.PuntoAcumulados + regla.GolAcertado;
            //}

            return suma;
        }




        private void frmApuesta_Load_1(object sender, EventArgs e)
        {
            listaGoles1();
            listaGoles2();
            label1.Text = cadena;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(cbxPuntos1.SelectedItem);
            int p2 = Convert.ToInt32(cbxPuntos2.SelectedItem);

            List<Partido> partidos = PartidoDAO.obtenerPartidoID(numero);

            Partido partido = partidos.First();
            DateTime fecha = partido.Fecha;
            //DateTime hora = partido.Hora;

            DateTime fechaActual = DateTime.Today;
            DateTime horaActual = DateTime.Now;

            //if (fechaActual <= fecha)
            //{
            //    //if(horaActual< hora  )
            //    //{
            ApuestaDAO.ingresarApuesta(grupo.Id, usuario.Id, numero, p1, p2);
            MessageBox.Show("Valores Ingresados con Éxito");
            sumarPuntos();
            UsuarioDAO.sumarPuntos(usuario); 
            //    //}

            //}
            //else
            //{
            //    MessageBox.Show("Ya no se pueden realizar más apuestas");
            //}

            usuario.PuntoAcumulados = sumarPuntos();
            Console.WriteLine(usuario.PuntoAcumulados);
        }
    }
}
