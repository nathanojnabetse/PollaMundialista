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
    public partial class frmReglasGrupo : Form
    {
        List<int> lsOpciones = new List<int>();
        List<int> listaOpciones2 = new List<int>();
        Usuario usuario;
        public Usuario Usuario { get => usuario; set => usuario = value; }

        public frmReglasGrupo()
        {
            InitializeComponent();
        }

        private void cargarCombos()
        {
            lsOpciones.Add(1); lsOpciones.Add(2); lsOpciones.Add(3); lsOpciones.Add(4); lsOpciones.Add(5);
            lsOpciones.Add(6); lsOpciones.Add(7); lsOpciones.Add(8); lsOpciones.Add(9); lsOpciones.Add(10);

            listaOpciones2.Add(0); listaOpciones2.Add(10); listaOpciones2.Add(20); listaOpciones2.Add(30); listaOpciones2.Add(40);
            listaOpciones2.Add(50); listaOpciones2.Add(60); listaOpciones2.Add(70); listaOpciones2.Add(80); listaOpciones2.Add(90);

            cbxMArcadorExactoAcertado.Items.Clear();
            cbxGanadorAcertado.Items.Clear();
            cbxGolAcertado.Items.Clear();
            cbxBonoClasificadosOctavos.Items.Clear();
            cbxBonoClasificadosCuartos.Items.Clear();
            cbxBonoClasificadosSeminifnales.Items.Clear();
            cbxBonoFinal.Items.Clear();
            cbxPrimerLugar.Items.Clear();
            cbxSegundoLugar.Items.Clear();
            cbxTercerLugar.Items.Clear();

            foreach (var iter in lsOpciones)
            {
                cbxMArcadorExactoAcertado.Items.Add(iter);
                cbxGanadorAcertado.Items.Add(iter);
                cbxGolAcertado.Items.Add(iter);
                cbxBonoClasificadosOctavos.Items.Add(iter);
                cbxBonoClasificadosCuartos.Items.Add(iter);
                cbxBonoClasificadosSeminifnales.Items.Add(iter);
                cbxBonoFinal.Items.Add(iter);
            }

            foreach (var iter in listaOpciones2)
            {

                cbxPrimerLugar.Items.Add(iter);
                cbxSegundoLugar.Items.Add(iter);
                cbxTercerLugar.Items.Add(iter);
            }

            cbxMArcadorExactoAcertado.SelectedIndex = 4;
            cbxGanadorAcertado.SelectedIndex = 1;
            cbxGolAcertado.SelectedIndex = 0;
            cbxBonoClasificadosOctavos.SelectedIndex = 7;
            cbxBonoClasificadosCuartos.SelectedIndex = 3;
            cbxBonoClasificadosSeminifnales.SelectedIndex = 1;
            cbxBonoFinal.SelectedIndex = 4;

            cbxPrimerLugar.SelectedIndex = 6;
            cbxSegundoLugar.SelectedIndex = 3;
            cbxTercerLugar.SelectedIndex = 1;

        }

        private void frmReglasGrupo_Load(object sender, EventArgs e)
        {
            cargarCombos();
            panel1.Visible = false;
            btnFinalizar.Visible = false;
        }

        private void tblSiguiente_Click(object sender, EventArgs e)
        {
            Reglas nuevaRegla = new Reglas();
            int total = (int)cbxPrimerLugar.SelectedItem + (int)cbxSegundoLugar.SelectedItem + (int)cbxTercerLugar.SelectedItem;
            int num = 0;

            try
            {
                if (total == 100 && Convert.ToInt32(cbxValorApuesta.Text) > 0)
                {
                    nuevaRegla.MarcadorExactoAcertado = (int)cbxMArcadorExactoAcertado.SelectedItem;
                    nuevaRegla.GanadorAcertado = (int)cbxGanadorAcertado.SelectedItem;
                    nuevaRegla.GolAcertado = (int)cbxGolAcertado.SelectedItem;
                    nuevaRegla.BonoOctavos = (int)cbxBonoClasificadosOctavos.SelectedItem;
                    nuevaRegla.BonoCuartos = (int)cbxBonoClasificadosCuartos.SelectedItem;
                    nuevaRegla.BonoSemi = (int)cbxBonoClasificadosSeminifnales.SelectedItem;
                    nuevaRegla.Bonofinal = (int)cbxBonoFinal.SelectedItem;
                    nuevaRegla.PrimerLugar = (int)cbxPrimerLugar.SelectedItem;
                    nuevaRegla.SegundoLuar = (int)cbxSegundoLugar.SelectedItem;
                    nuevaRegla.TercerLugar = (int)cbxTercerLugar.SelectedItem;
                    nuevaRegla.ValorApuesta = Convert.ToInt32(cbxValorApuesta.Text);
                    ReglasDAO.crearReglas(nuevaRegla);

                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is Label)
                        {
                            ctrl.Visible = false;
                        }
                        if (ctrl is TextBox)
                        {
                            ctrl.Visible = false;
                        }
                        if (ctrl is ComboBox)
                        {
                            ctrl.Visible = false;
                        }
                    }
                    btnSiguiente.Visible = false;
                    panel1.Visible = true;
                }

                else
                {
                    MessageBox.Show("Error en los datos.");
                }
            }

            catch
            {
                if (!int.TryParse(cbxValorApuesta.Text, out num))
                {
                    MessageBox.Show("Ingrese un valor numérico");
                    return; //Salimos
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grupo nuevoGrupo = new Grupo();
            nuevoGrupo.Nombre = txtNombreGrupo.Text;
            nuevoGrupo.Codigo = txtNombreGrupo.Text;
            List<Reglas> lsReglasAUX = ReglasDAO.ultimoIngresado();

            nuevoGrupo.Reglas = lsReglasAUX[0];

            GrupoDAO.crearGrupo(nuevoGrupo);
            /////////////////
            UsuarioDAO.ingresarprimerUsuarioGrupo(usuario, nuevoGrupo);

            lblCodigo.Text = txtNombreGrupo.Text;

            button1.Visible = false;
            btnFinalizar.Visible = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
