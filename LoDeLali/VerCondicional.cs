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
	public partial class VerCondicional : Form
	{
		public VerCondicional()
		{
			InitializeComponent();
		}

		public MainForm formularioPadre;
		public ListaCondicionales listaCondicionales;
		public int idCliente;
		string consulta;
		Cliente cliente = new Cliente();

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
            consulta = "SELECT * FROM condicional WHERE cliente_idcliente = " + idCliente + ";";
			DataTable condicionalCliente = new DataTable();
			condicionalCliente = formularioPadre.GetBD(consulta);
			dataGridViewCondicional.DataSource = condicionalCliente;

			labelFecha.Text = Convert.ToDateTime(dataGridViewCondicional.Rows[0].Cells["fecha"].Value).ToString("dd/MM/yyyy");

			FormatoDataGridView();
			
			
			cliente = formularioPadre.cargarCliente(idCliente);

			labelNombre.Text = cliente.Nombre;
			labelCelular.Text = cliente.Celular;
			this.Text = "Condicional cliente: " + cliente.Nombre;


		}

        private void VerCondicional_FormClosed(object sender, FormClosedEventArgs e)
        {
			listaCondicionales.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
			

			try
			{
				double total = 0, saldo = 0, compra = 0;
				string descripcion = "", fecha = "";
				//TOMAMOS EL VALOR DE LA FECHA 

				for (int i = 0; i < dataGridViewCondicional.Rows.Count; i++)
				{
					double precioUni = Convert.ToDouble(dataGridViewCondicional.Rows[i].Cells["precioUni"].Value);
					int cantidad = Convert.ToInt16(dataGridViewCondicional.Rows[i].Cells["cantidad"].Value);
					compra = (precioUni * cantidad);

					if (Convert.ToBoolean(dataGridViewCondicional.Rows[i].Cells[0].Value))
					{
						CuentasCorrientes ultimoRegistro = formularioPadre.cargarUltimoRegistro(idCliente);

						fecha = dataGridViewCondicional.Rows[i].Cells["fecha"].Value.ToString();
						descripcion = cantidad.ToString() + " " + dataGridViewCondicional.Rows[i].Cells["producto"].Value.ToString() + " c/u " + precioUni.ToString();
						total = ultimoRegistro.Saldo;
						saldo = total;
						saldo += compra;

						consulta = "INSERT INTO cuentascorrientes(fecha,descripcion,compra,total,entrega,saldo,cliente_idcliente)" +
									"VALUES('" + fecha + "', '" + descripcion.ToUpper() + "', " + compra + ", " + ultimoRegistro.Saldo + ", " + 0 + ", " +
									saldo + ", " + idCliente + ");";

						formularioPadre.CrudBD(consulta);
					}
				}

				consulta = "UPDATE cliente SET condicional = 0 WHERE idcliente = " + idCliente + ";";
				formularioPadre.CrudBD(consulta);
				consulta = "DELETE FROM condicional WHERE cliente_idcliente = " + idCliente + ";";
				formularioPadre.CrudBD(consulta);
				dataGridViewCondicional.DataSource = null;
				MessageBox.Show("El condicional de " + cliente.Nombre + " fue borrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				formularioPadre.Show(); 
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Controle datos ingresados  ---->> " + ex);
			}

        }

		private void buttonAtras_Click(object sender, EventArgs e)
		{
			listaCondicionales.Show();
			Close();
        }
	}
}
