using LoDeLali.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoDeLali
{
	public partial class Form_VerCondicionalNoCliente : Form
    {
        public Form_VerCondicionalNoCliente()
        {
            InitializeComponent();
        }

		public MainForm FormularioPadre { get; set; }
		public Form_ListaCondicionales ListaCondicionales { get; set; }
		public int IdCliente { get; set; }
		
		private int idNoCliente;

        private bool dejoAlgo = false;

		private NoCliente noCliente;
		
		private DataTable noClienteTabla = new DataTable();

		private DataTable condicionalCliente = new DataTable();

		Conexion con = new Conexion();

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
			condicionalCliente = con.RecibirDatosDeBD("SELECT * FROM condicional WHERE nocliente_idNoCliente = " + idNoCliente + ";");
            dataGridViewCondicional.DataSource = condicionalCliente;

            labelFecha.Text = Convert.ToDateTime(dataGridViewCondicional.Rows[0].Cells["fecha"].Value).ToString("dd/MM/yyyy");

            FormatoDataGridView();

			noClienteTabla = con.RecibirDatosDeBD("SELECT * FROM noCliente WHERE idNoCliente = " + idNoCliente + ";");


			noCliente = new NoCliente(idNoCliente, noClienteTabla.Rows[0]["Nombre"].ToString(), noClienteTabla.Rows[0]["celular"].ToString());

			labelNombre.Text = noCliente.Nombre;
			labelCelular.Text = noCliente.Celular;

			this.Text = "Condicional IdCliente: " + noCliente.Nombre;
		}

        private void VerCondicionalNoCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
			ListaCondicionales.Show();
		}

        private void buttonConfirmar_Click_1(object sender, EventArgs e)
        {
			noCliente = new NoCliente();

			for (int i = 0; i < dataGridViewCondicional.Rows.Count-1; i++)
            {
                if (Convert.ToBoolean(dataGridViewCondicional.Rows[i].Cells[0].Value))
                {
					dejoAlgo = true;
                }
            }

            if (dejoAlgo)
            {
				try
				{
					for (int i = 0; i < dataGridViewCondicional.Rows.Count - 1; i++)
					{
						if (Convert.ToBoolean(dataGridViewCondicional.Rows[i].Cells[0].Value))
						{
							//agrega nuevo IdCliente y genera calculos con los datos de los registros confirmados
							noCliente.AgregarCondicionalYCliente(Convert.ToInt16(dataGridViewCondicional.Rows[i].Cells["cantidad"].Value),
                                                                    Convert.ToDouble(dataGridViewCondicional.Rows[i].Cells["precioUni"].Value),
                                                                    dataGridViewCondicional.Rows[i].Cells["producto"].Value.ToString());
						}
					}
					//borra todos los registros generados como condicional
					noCliente.BorrarCondicional();
					
					//cambia a false el bool de IdCliente.Condicional
					noCliente.SinCondicional();

                    MessageBox.Show("El condicional de " + noCliente.Nombre + " fue borrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
				catch (Exception ex)
				{
					MessageBox.Show("Controle datos ingresados  ---->> " + ex);
				}
            }

            dataGridViewCondicional.DataSource = null;

            Close();
            ListaCondicionales.Close();
			FormularioPadre.Show();
		}

		private void buttonAtras_Click(object sender, EventArgs e)
		{
			ListaCondicionales.Show();
			Close();
		}
	}
}
