using System;
using System.Windows.Forms;

namespace LoDeLali
{
    public partial class MensajeCondicional : Form
    {
        public MensajeCondicional()
        {
            InitializeComponent();
        }
        public MainForm formularioPadre;
        public int idCliente;

        private void buttonNuevoCondicional_Click(object sender, EventArgs e)
        {
            NuevoCondicional condicional = new NuevoCondicional();
            condicional.formularioPadre = formularioPadre;
            condicional.idCliente = idCliente;
            Hide();
            condicional.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaCondicionales listaCondicionales = new ListaCondicionales();
            listaCondicionales.formularioPadre = formularioPadre;
            Hide();
            listaCondicionales.ShowDialog();

        }
    }
}
