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

namespace LoDeLali
{
	/// <summary>
	/// Description of Morosos.
	/// </summary>
	public partial class Morosos : Form
	{
		public Morosos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public MainForm formularioPadre;
		int cliente;
		
		
		void MorososLoad(object sender, EventArgs e)
		{
			
			string consulta, fechaUltimaEntrega;
			
			DateTime fechaActual = DateTime.Now.Date;
			TimeSpan diferenciaDeDias;
			DataTable listaDeEntregas = new DataTable();
			DataTable listaClientes = new DataTable();
			listaClientes = formularioPadre.GetBD("SELECT * FROM cliente WHERE habilitado = "+ 1 + ";");
			DataTable listaMorosos = new DataTable();
			//LE DAMOS EL FORMATO DE LAS TABLAS CON LAS QUE ESTAMOS TRABAJANDO, ASI NO 
			//GENERA PROBLEMAS AL IMPORTAR FILAS
			listaMorosos = listaClientes.Clone();
			
			for (int i = 0; i < listaClientes.Rows.Count; i++) {
				cliente = Convert.ToInt32(listaClientes.Rows[i]["idCliente"]);
				consulta = "SELECT * FROM cuentascorrientes WHERE cliente_idCliente = "+ cliente + " AND descripcion = 'ENTREGA';";
				listaDeEntregas = formularioPadre.GetBD(consulta);
				
				try 
				{
					fechaUltimaEntrega = listaDeEntregas.Rows[listaDeEntregas.Rows.Count-1]["fecha"].ToString();
					
					diferenciaDeDias = fechaActual.Subtract(Convert.ToDateTime(fechaUltimaEntrega));
					
					if (diferenciaDeDias.Days > 30)
					{
						//PARA ESTE PASO CLONAMOS LA TABLA MAS ARRIBA
						listaMorosos.ImportRow(listaClientes.Rows[i]);
						consulta = "UPDATE cliente SET moroso = " + 1 + " WHERE idcliente =" + cliente + ";";
						formularioPadre.CrudBD(consulta);
					}
				} catch (Exception) {
					
					continue;
				}
			}

			dataGridViewMorosos.DataSource = listaMorosos;
			dataGridViewMorosos.Columns["habilitado"].Visible = false;
			dataGridViewMorosos.Columns["idCliente"].Visible = false;
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
			cliente = Convert.ToInt32(dataGridViewMorosos.CurrentRow.Cells["idCliente"].Value.ToString());
			
			//CREAMOS UN NUEVO FORMULARIO DE VERCUENTA Y GUARDAMOS EL FORMULARIO PRINCIPAL EN FORMULARIOPADRE
			VerCuenta verCuenta = new VerCuenta();
			verCuenta.formularioPadre = formularioPadre;
			verCuenta.cliente = formularioPadre.cargarCliente(cliente);
			
			
			verCuenta.ShowDialog();
		}
		
		void ButtonWhatsappClick(object sender, EventArgs e)
		{
			string celular = dataGridViewMorosos.CurrentRow.Cells["celular"].Value.ToString();
			Process.Start("https://wa.me/+54" + celular);
		}
		
		
		
		
	}
}
