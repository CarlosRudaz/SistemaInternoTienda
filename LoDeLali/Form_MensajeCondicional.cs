using System;
using System.Windows.Forms;

namespace LoDeLali
{
    public partial class Form_MensajeCondicional : Form
    {
        public Form_MensajeCondicional()
        {
            InitializeComponent();
        }
        public MainForm formularioPadre;
        public int idCliente;

        private void buttonNuevoCondicional_Click(object sender, EventArgs e)
        {
            Form_NuevoCondicional condicional = new Form_NuevoCondicional();
            condicional.FormularioPadre = formularioPadre;
            condicional.IdCliente = idCliente;
            Hide();
            condicional.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ListaCondicionales listaCondicionales = new Form_ListaCondicionales();
            listaCondicionales.FormularioPadre = formularioPadre;
            Hide();
            listaCondicionales.ShowDialog();

        }
    }
}
