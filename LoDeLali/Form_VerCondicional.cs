using LoDeLali.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLali
{
	public partial class Form_VerCondicional : Form
	{
		public Form_VerCondicional()
		{
			InitializeComponent();
		}

		public MainForm FormularioPadre { get; set; }
		public Form_ListaCondicionales ListaCondicionales { get; set; }
		public int IdCliente { get; set; }

		private Cliente cliente = new Cliente();

		void FormatoDataGridView()
        {
			dataGridViewCondicional.Columns[0].Width = 45;
			dataGridViewCondicional.Columns[1].Width = 45;
			dataGridViewCondicional.Columns[2].Width = 45;
			dataGridViewCondicional.Columns[3].Width = 250;
			dataGridViewCondicional.Columns[4].Width = 45;
			dataGridViewCondicional.Columns["fecha"].Visible = false;
			dataGridViewCondicional.Columns["cliente_idcliente"].Visible = false;
			dataGridViewCondicional.Columns["nocliente_idNoCliente"].Visible = false;
		}


		private void VerCondicional_Load(object sender, EventArgs e)
        {
			Conexion con = new Conexion();
			DataTable condicionalCliente = new DataTable();
			condicionalCliente = con.RecibirDatosDeBD("SELECT * FROM condicional WHERE cliente_idcliente = " + IdCliente + ";");
			dataGridViewCondicional.DataSource = condicionalCliente;

			labelFecha.Text = Convert.ToDateTime(dataGridViewCondicional.Rows[0].Cells["fecha"].Value).ToString("dd/MM/yyyy");

			FormatoDataGridView();
			
			cliente = con.CargarCliente(IdCliente);

			labelNombre.Text = cliente.Nombre;
			labelCelular.Text = cliente.Celular;
			this.Text = "Condicional IdCliente: " + cliente.Nombre;
		}

        private void VerCondicional_FormClosed(object sender, FormClosedEventArgs e)
        {
			ListaCondicionales.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
			try
			{
				for (int i = 0; i < dataGridViewCondicional.Rows.Count; i++)
				{
					if (Convert.ToBoolean(dataGridViewCondicional.Rows[i].Cells[0].Value))
					{
						cliente.CargarCondicional(Convert.ToInt16(dataGridViewCondicional.Rows[i].Cells["cantidad"].Value),
                                                    Convert.ToDouble(dataGridViewCondicional.Rows[i].Cells["precioUni"].Value),
                                                    dataGridViewCondicional.Rows[i].Cells["producto"].Value.ToString());
					}
				}

				cliente.SinCondicional();
				cliente.BorrarCondicional();

				MessageBox.Show("El condicional de " + cliente.Nombre + " fue borrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Controle datos ingresados  ---->> " + ex);
			}

            FormularioPadre.Show();
            Close();
        }

		private void buttonAtras_Click(object sender, EventArgs e)
		{
			ListaCondicionales.Show();
			Close();
        }
	}
}
