/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 06/07/2022
 * Hora: 10:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;

namespace LoDeLali
{
	/// <summary>
	/// Description of VerCuenta.
	/// </summary>
	public partial class VerCuenta : Form
	{
		//CONSTRUCTOR
		public VerCuenta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//VARIABLE QUE CONTIENE EL FORMULARIO PADRE/RAIZ
		public MainForm formularioPadre;
		public Cliente cliente;
		public CuentasCorrientes ultimoRegistro = new CuentasCorrientes();
		DataTable datosCuentasCorrientes = new DataTable(), datosCliente = new DataTable();
		
		
		public void limpiarFormularioDeRegistro()
		{
			checkBoxEntrega.Checked = false;
			textBoxProducto.Text = "";
			textBoxPrecio.Text = "";
		}
		
		public void ActualizarLista()
		{
			string consulta = "SELECT * FROM cuentascorrientes WHERE cliente_idCliente = " + cliente.Id + ";";
			
			//DATOSTABLA ES UN TIPO DATETABLE INICIALIZADA GLOBAL PARA USAR EN CUALQUIER METODO
			dataGridViewCuentas.DataSource = formularioPadre.GetBD(consulta);
			dataGridViewCuentas.Columns["cliente_idCliente"].Visible = false;
			dataGridViewCuentas.Columns[0].Width = 85;
			dataGridViewCuentas.Columns[1].Width = 250;
			dataGridViewCuentas.Columns[2].Width = 45;
			dataGridViewCuentas.Columns[3].Width = 45;
			dataGridViewCuentas.Columns[4].Width = 45;
			dataGridViewCuentas.Columns[5].Width = 45;

		}
		
		
		//CARGAMOS LAS TABLAS AL ABRIR EL FORMULARIO
		void VerCuentaShown(object sender, EventArgs e)
		{
			if (cliente.Condicional)
			{
				labelAvisoCondicional.Visible = true;
			}

			ultimoRegistro = formularioPadre.cargarUltimoRegistro(cliente.Id);
			if (ultimoRegistro.Saldo <= 0) {
				labelAvisoCuentaPagada.Visible = true;
				labelAvisoCuentaPagada.Text = "¡CLIENTE AL DÍA!";
				checkBoxEntrega.Visible = false;
			}
			else
			{
				labelAvisoCuentaPagada.Visible = false;
				checkBoxEntrega.Visible = true;
			}

			ActualizarLista();
			//GUARDAMOS LOS VALORES QUE ESTÁN EN LA TABLA.			
			labelNombreCliente.Text = cliente.Nombre;
			labelCelular.Text = cliente.Celular;
		}
		
		void ButtonAgregarRegistroClick(object sender, EventArgs e)
		{
			
			if (cliente.Habilitado) {
				buttonDescargar.Visible = false;
				panel2.Visible = false;
				panel1.Visible = true;
				buttonAtras.Visible = false;
			}
			else
			{
				MessageBox.Show("Para agregar registros se debe habilitar al cliente desde la lista de borrados...",
				                "Falta Autorización", 
				                MessageBoxButtons.OK,MessageBoxIcon.Stop);
				Close();
			}
			
		}
		
		void ButtonNuevoRegistroClick(object sender, EventArgs e)
		{	
			this.ControlBox = false;
			ultimoRegistro = formularioPadre.cargarUltimoRegistro(cliente.Id);
			try {
				double total = 0, entrega = Convert.ToDouble(textBoxPrecio.Text), saldo = 0, 
						compra = entrega;
				string descripcion = textBoxProducto.Text;

				//TOMAMOS EL VALOR DE LA FECHA 
				string fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm");/*dateTimePicker1.Value.ToString()/*dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm")*/;
				
				string consulta = "SELECT * FROM cuentascorrientes WHERE cliente_idCliente = " 
					+ cliente.Id + ";";
				
				datosCuentasCorrientes = formularioPadre.GetBD(consulta);
				//datosCuentasCorrientes.Columns["producto"].ToString() == "ENTREGA";
				
				if (checkBoxEntrega.Checked) {
					total = ultimoRegistro.Saldo;
				 	saldo = total;
					saldo -= entrega;
					compra = 0;
				}
				else
				{
					total = ultimoRegistro.Saldo;
				 	saldo = total;
					saldo += compra;
					entrega = 0;
				}

				try{
					consulta = "INSERT INTO cuentascorrientes(fecha,descripcion,compra,total,entrega,saldo,cliente_idcliente)"+
					"VALUES('" + fecha + "', '" + descripcion.ToUpper() + "', " + compra + ", " + total + ", " + entrega  + ", " + 
						saldo + ", " + cliente.Id + ");";
					
					formularioPadre.CrudBD(consulta);
					
					limpiarFormularioDeRegistro();
					
					MessageBox.Show("Nuevo Registro Agregado");
					
					if (saldo == 0.00) {
						checkBoxEntrega.Visible = false;
						consulta = "UPDATE cliente SET habilitado = 0 WHERE idCliente = " + cliente.Id + ";";
						formularioPadre.CrudBD(consulta);
						
						DialogResult mensaje = MessageBox.Show("¿Desea eliminar el historial de este usuario?", 
						                                       "ATENCIÓN", MessageBoxButtons.YesNo,
						                                       MessageBoxIcon.Exclamation, 
						                                       MessageBoxDefaultButton.Button1);
						
						consulta = "DELETE FROM cuentascorrientes WHERE cliente_idCliente = " + cliente.Id + ";";
						if (mensaje == DialogResult.Yes) {
							formularioPadre.CrudBD(consulta);
						}
						
						checkBoxEntrega.Checked = false;
						
						Close();
						
					}
					else
					{
						checkBoxEntrega.Visible = true;
					}
					
					
				}catch(Exception ex){
					MessageBox.Show("ERROR: " + ex);
				}
				
			} catch (Exception ex) {
				MessageBox.Show("Controle datos ingresados  ---->> " + ex);
			}
		}
		
		void ButtonCancelarClick(object sender, EventArgs e)
		{
			buttonDescargar.Visible = true;
			panel2.Visible = true;
			panel1.Visible = false;
			buttonAtras.Visible = true;
			
			ActualizarLista();
			
			limpiarFormularioDeRegistro();
			
			this.ControlBox = true;
			
		}
		
		void CheckBoxEntregaCheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEntrega.Checked) {
				textBoxProducto.Text = "ENTREGA";
				textBoxProducto.Enabled = false;
			}
			else
			{
				textBoxProducto.Text = "";
				textBoxProducto.Enabled = true;
			}
		}
		
		void LabelAvisoCuentaPagadaClick(object sender, EventArgs e)
		{
			labelAvisoCuentaPagada.Visible = false;
		}

		private void buttonAtras_Click(object sender, EventArgs e)
		{
			this.Close();
			formularioPadre.Show();
		}

        //IMPRESION ################################################################
        void ButtonDescargarClick(object sender, EventArgs e)
		{
			//INICIALIZAMOS EL FORMULARIO DE IMPRESIÓN
			PrintDocument doc = new PrintDocument();
			doc.DefaultPageSettings.Landscape = true;
			doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
			
			//MÉTODO QUE NOS PERMITE TOMAR LA PARTE QUE DESEAMOS IMPRIMIR Y DARLE FORMATO DE TABLA
			doc.PrintPage += new PrintPageEventHandler(ImprimirResumen);
			doc.Print();
        }

		//VARIABLES QUE USO PARA PODER SEGUIR IMPRIMIENDO EN OTRA HOJA SI LA PRIMERA SE COMPLETA
		int index = 0, bandera = 0, bottom = 0, contador = 0;
        
        public void ImprimirResumen (object ev, PrintPageEventArgs ep)
		{
            const int DGV_ALTO = 30; //Alto de la fila
            int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top; 
			//startupPath nos da la dirección donde se encuentra el archivo de arranque del programa
			string path = Application.StartupPath + "/static/bordePagina.png";

            Image img = Image.FromFile(path);
			//Bitmap imgbitmap = new Bitmap(img);
			ep.Graphics.DrawImageUnscaled(img, new Point(0, 0));
			top += 140; //90
				
			ep.Graphics.DrawString("CUENTA CORRIENTE", new Font("Segoe UI", 30, FontStyle.Bold), Brushes.Black, left + 230, top);
			top += 65;//85
				
			ep.Graphics.DrawString("CLIENTE: " + cliente.Nombre, new Font("Segoe UI", 30, FontStyle.Bold), Brushes.Black, left, top);
			top += 70; //85

            if (dataGridViewCuentas.Rows.Count < 12)
            {
                bottom = top + (dataGridViewCuentas.RowCount + 1) * DGV_ALTO;
			}
			else
			{
                bottom = top + (14 * DGV_ALTO);
            }

            if (bandera == 0)
            {
				contador = 0;
                index = 0;
            }
            else
            {
                bottom = top + (dataGridViewCuentas.RowCount - index + 1) * DGV_ALTO;
                contador = 0;
            }

            foreach (DataGridViewColumn col in dataGridViewCuentas.Columns) 
			{
				if (col.HeaderText != "cliente_idCliente") 
				{
					ep.Graphics.DrawString(col.HeaderText.ToUpper(), new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Brown, left, top);
					left += col.Width + 50;
					
					if (col.Index < dataGridViewCuentas.ColumnCount - 2) 
					{

						ep.Graphics.DrawLine(Pens.Gray, left-10,top,left -10, bottom/*top + (dataGridViewCuentas.RowCount + 1) * DGV_ALTO*/);
					}
				}
			}
				
			left = ep.MarginBounds.Left;
			ep.Graphics.FillRectangle(Brushes.DarkGray, left, top+28, ep.MarginBounds.Right - left, 4);
			top += 30; //43

			//foreach (DataGridViewRow row in dataGridViewCuentas.Rows) NO USO EL FOREACH PORQUE NECESITO MODIFICAR EL INDEX
			for (int i = index; i < dataGridViewCuentas.RowCount; i++)
			{
				DataGridViewRow row = new DataGridViewRow();
				row = dataGridViewCuentas.Rows[i];
                //if (row.Index == dataGridViewCuentas.RowCount) break;

                left = ep.MarginBounds.Left;


				foreach (DataGridViewCell cell in row.Cells)
				{
                    if (cell.ColumnIndex != 6 && cell.ColumnIndex != 7)
					{
						ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 12), Brushes.Black, left, top);
						left += cell.OwningColumn.Width + 50;
					}
					ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
				}

				top += DGV_ALTO;

                //HACE LA ULTIMA LINEA DIVISORIA
                ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);

                if (contador >= 12)
				{
                    ep.HasMorePages = true;
					index = row.Index + 1;
					bandera = 1;
					contador = 0;
					return;
                }
				else
				{
					contador++;
					bandera = 0;
					ep.HasMorePages = false;	
				}
			}
			

        }

	}
}
