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
    public partial class VerCondicionalNoCliente : Form
    {
        public VerCondicionalNoCliente()
        {
            InitializeComponent();
        }

		public MainForm formularioPadre;
		public ListaCondicionales listaCondicionales;
		public int idCliente;
		int idNoCliente;
		string consulta;
		Cliente cliente = new Cliente();
		bool dejoAlgo = false;
		DataTable noCliente = new DataTable();

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
		

        private void VerCondicionalNoCliente_Load(object sender, EventArgs e)
        {
			idNoCliente = idCliente;

			consulta = "SELECT * FROM condicional WHERE nocliente_idNoCliente = " + idNoCliente + ";";
			DataTable condicionalCliente = new DataTable();
			condicionalCliente = formularioPadre.GetBD(consulta);
			dataGridViewCondicional.DataSource = condicionalCliente;


            labelFecha.Text = Convert.ToDateTime(dataGridViewCondicional.Rows[0].Cells["fecha"].Value).ToString("dd/MM/yyyy");

            FormatoDataGridView();

			consulta = "SELECT * FROM noCliente WHERE idNoCliente = " + idNoCliente + ";";
			

			noCliente = formularioPadre.GetBD(consulta);

			cliente.Nombre = noCliente.Rows[0]["nombre"].ToString();
			cliente.Id = idNoCliente;
			cliente.Celular = noCliente.Rows[0]["celular"].ToString();

			//consulta = "INSERT INTO cliente(nombre,celular) VALUES('" + cliente.Nombre + "', '" + cliente.Celular + "' );";
			//formularioPadre.CrudBD(consulta);

			labelNombre.Text = cliente.Nombre;
			labelCelular.Text = cliente.Celular;

			this.Text = "Condicional cliente: " + cliente.Nombre;
		}

        private void VerCondicionalNoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
			listaCondicionales.Show();
		}

        private void buttonConfirmar_Click_1(object sender, EventArgs e)
        {
			double total = 0, saldo = 0, compra = 0, precioUni = 0;
			int cantidad = 0;
			string descripcion = "", fecha = "";

			for (int i = 0; i < dataGridViewCondicional.Rows.Count-1; i++)
            {
                if (Convert.ToBoolean(dataGridViewCondicional.Rows[i].Cells[0].Value))
                {
					dejoAlgo = true;
                }
            }

            if (dejoAlgo)
            {
				consulta = "INSERT INTO cliente(nombre,celular) VALUES('" + cliente.Nombre + "', '" + cliente.Celular + "' );";
				formularioPadre.CrudBD(consulta);

				consulta = "SELECT * FROM cliente WHERE nombre = '" + cliente.Nombre + "';";
				noCliente = formularioPadre.GetBD(consulta);
				idCliente = Convert.ToInt32(noCliente.Rows[0]["idcliente"]);

				try
				{
					
					//TOMAMOS EL VALOR DE LA FECHA 
					fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

					for (int i = 0; i < dataGridViewCondicional.Rows.Count - 1; i++)
					{
						precioUni = Convert.ToDouble(dataGridViewCondicional.Rows[i].Cells["precioUni"].Value);
						cantidad = Convert.ToInt16(dataGridViewCondicional.Rows[i].Cells["cantidad"].Value);
						compra = (precioUni * cantidad);

						if (Convert.ToBoolean(dataGridViewCondicional.Rows[i].Cells[0].Value))
						{
							CuentasCorrientes ultimoRegistro = formularioPadre.cargarUltimoRegistro(idCliente);

							//fecha = dataGridViewCondicional.Rows[i].Cells["fecha"].Value.ToString();
							descripcion = cantidad.ToString() + " " + dataGridViewCondicional.Rows[i].Cells["producto"].Value.ToString() + " c/u " + precioUni.ToString();
							total = ultimoRegistro.Saldo;
							saldo = total;
							saldo += compra;

							consulta = "INSERT INTO cuentascorrientes(fecha,descripcion,compra,total,entrega,saldo,cliente_idcliente)" +
										"VALUES('" + fecha + "', '" + descripcion.ToUpper() + "', " + compra + ", " + total + ", " + 0 + ", " +
										saldo + ", " + idCliente + ");";

							formularioPadre.CrudBD(consulta);
						}
					}

					consulta = "UPDATE cliente SET condicional = 0 WHERE idcliente = " + idCliente + ";";
					formularioPadre.CrudBD(consulta);


				}
				catch (Exception ex)
				{
					MessageBox.Show("Controle datos ingresados  ---->> " + ex);
				}
            }

			
			consulta = "DELETE FROM condicional WHERE nocliente_idNoCliente = " + idNoCliente + ";";
			formularioPadre.CrudBD(consulta);
			consulta = "DELETE FROM noCliente WHERE idNoCliente = " + idNoCliente + ";";
			formularioPadre.CrudBD(consulta);
			dataGridViewCondicional.DataSource = null;
			MessageBox.Show("El condicional de " + cliente.Nombre + " fue borrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
            listaCondicionales.Close();
			formularioPadre.Show();
		}

		private void buttonAtras_Click(object sender, EventArgs e)
		{
			listaCondicionales.Show();
			Close();
		}
	}
}
