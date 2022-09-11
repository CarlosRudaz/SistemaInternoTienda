/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 14/07/2022
 * Hora: 20:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;
using LoDeLali.Clases;

namespace LoDeLali
{
	/// <summary>
	/// Description of Morosos.
	/// </summary>
	public partial class Form_Morosos : Form
	{
		public Form_Morosos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public MainForm FormularioPadre { get; set; }

		public int IdCliente { get; set; }

		private Conexion con = new Conexion();
		
		
		void MorososLoad(object sender, EventArgs e)
		{
			
			string fechaUltimaEntrega;
			
			DateTime fechaActual = DateTime.Now.Date;
			TimeSpan diferenciaDeDias;

			DataTable listaMorosos = new DataTable();

			DataTable listaDeEntregas = new DataTable();

			DataTable listaClientes = con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE habilitado = " + 1 + ";");
			
			//LE DAMOS EL FORMATO DE LAS TABLAS CON LAS QUE ESTAMOS TRABAJANDO, ASI NO 
			//GENERA PROBLEMAS AL IMPORTAR FILAS
			listaMorosos = listaClientes.Clone();
			
			for (int i = 0; i < listaClientes.Rows.Count; i++) 
			{
				IdCliente = Convert.ToInt32(listaClientes.Rows[i]["IdCliente"]);
				listaDeEntregas = con.RecibirDatosDeBD("SELECT * FROM cuentascorrientes WHERE cliente_idCliente = " + IdCliente + " AND descripcion = 'ENTREGA';");
				
				try 
				{
					fechaUltimaEntrega = listaDeEntregas.Rows[listaDeEntregas.Rows.Count-1]["fecha"].ToString();
					
					diferenciaDeDias = fechaActual.Subtract(Convert.ToDateTime(fechaUltimaEntrega));
					
					if (diferenciaDeDias.Days > 30)
					{
						//PARA ESTE PASO CLONAMOS LA TABLA MAS ARRIBA
						listaMorosos.ImportRow(listaClientes.Rows[i]);
						con.ModificarDatosBD("UPDATE IdCliente SET moroso = " + 1 + " WHERE idcliente =" + IdCliente + ";");
					}
				} 
				catch (Exception) 
				{
					
					continue;
				}
			}

			dataGridViewMorosos.DataSource = listaMorosos;
			dataGridViewMorosos.Columns["habilitado"].Visible = false;
			dataGridViewMorosos.Columns["IdCliente"].Visible = false;
			dataGridViewMorosos.Columns["moroso"].Visible = false;
			dataGridViewMorosos.Columns["condicional"].Visible = false;
			dataGridViewMorosos.ClearSelection();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void DataGridViewMorososCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//VARIABLE GLOBAL			
			IdCliente = Convert.ToInt32(dataGridViewMorosos.CurrentRow.Cells["IdCliente"].Value.ToString());
			
			//CREAMOS UN NUEVO FORMULARIO DE VERCUENTA Y GUARDAMOS EL FORMULARIO PRINCIPAL EN FORMULARIOPADRE
			Form_VerCuenta verCuenta = new Form_VerCuenta();
			verCuenta.FormularioPadre = FormularioPadre;
			verCuenta.Cliente = con.CargarCliente(IdCliente);
			verCuenta.ShowDialog();
		}
		
		void ButtonWhatsappClick(object sender, EventArgs e)
		{
			string celular = dataGridViewMorosos.CurrentRow.Cells["celular"].Value.ToString();
			Process.Start("https://wa.me/+54" + celular);
		}
		
		
		
		
	}
}
