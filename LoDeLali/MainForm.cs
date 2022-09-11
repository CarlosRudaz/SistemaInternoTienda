using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using LoDeLali.Clases;

namespace LoDeLali
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//INICIALIZAMOS LA BASE DE DATOS
		
		public DataTable datosClientes = new DataTable(), datosCuentasCorrientes = new DataTable();
        private Conexion con = new Conexion();
        //COMO MAINFORM ES UNA CLASE, CREO ESTA VARIABLE PARA TRABAJAR CON UN USUARIO EN PARTICULAR USANDO SU ID
        public int IdCliente { get; set; }




        //CON ESTE METODO NOS ENCARGAMOS QUE AL INICIAR EL PROGRAMA, LOS DATOS DE LA BASE YA ESTEN CARGADOS
        private void MainForm_Load(object sender, EventArgs e)
		{
			//con es la variable para manejar la conexion a la base de datos en la clase principal
            mostrarDataGrid(con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE habilitado = " + 1 + " ORDER BY Nombre;"));
        }

		public void ActualizarListaCuentasCorrientes()
		{
			dataGridViewBuscarCuentasCorrientes.DataSource = con.RecibirDatosDeBD("SELECT * FROM cuentascorrientes WHERE cliente_idCliente = " + IdCliente + ";");
            dataGridViewBuscarCuentasCorrientes.ClearSelection();
		}
		
		public void ActualizarListaClientes()
		{
			if (checkBoxUsuariosBorrados.Checked) {
				datosClientes = con.RecibirDatosDeBD("SELECT * FROM IdCliente ORDER BY Nombre;");
			}
			else
			{
				datosClientes = con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE habilitado = " + 1 + " ORDER BY Nombre;");
			}
			
			mostrarDataGrid(datosClientes);
			
			buttonRecuperarCliente.Visible = false;
			buttonEliminarCliente.Visible = false;
			IdCliente = -1;
		}
		
		
		
		public void mostrarDataGrid(DataTable tabla)
		{
			dataGridViewBuscarCuentasCorrientes.DataSource = datosClientes;
			dataGridViewBuscarCuentasCorrientes.Columns["habilitado"].Visible = false;
			dataGridViewBuscarCuentasCorrientes.Columns["IdCliente"].Visible = false;
			dataGridViewBuscarCuentasCorrientes.Columns["moroso"].Visible = false;
			dataGridViewBuscarCuentasCorrientes.Columns["condicional"].Visible = false;

			dataGridViewBuscarCuentasCorrientes.ClearSelection();
		}
		
		public CuentasCorrientes cargarUltimoRegistro(int idCliente)
		{
			CuentasCorrientes ultimoRegistro;
            DataTable tabla = new DataTable();
			tabla = con.RecibirDatosDeBD("SELECT * FROM cuentascorrientes WHERE cliente_idCliente = " + idCliente + ";");
			
			if(tabla.Rows.Count > 0)
			{
				ultimoRegistro = new CuentasCorrientes(tabla.Rows[tabla.Rows.Count - 1]["fecha"].ToString(),
														tabla.Rows[tabla.Rows.Count - 1]["descripcion"].ToString(),
				                                        Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["compra"]), 
				                                        Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["total"]),
				                                        Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["entrega"]), 
			                                            Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["saldo"]),
			                                            Convert.ToInt32(tabla.Rows[tabla.Rows.Count - 1]["cliente_idcliente"]));
			} 
			else
			{
			    ultimoRegistro = new CuentasCorrientes("",
				                                        "----------",
				                                        0, 
				                                        0,
				                                        0, 
			                                            0,
			                                            idCliente);
			}
            return ultimoRegistro;
        }
		
		//PANTALLA PRINCIPAL
		void ButtonEfectivoClick(object sender, EventArgs e)
		{
			Form1 formulario = new Form1();
			
			//LE PASAMOS EL FORMULARIO ACTUAL, A LA NUEVA INSTANCIA DE FORM1 PARA PODER VOLVER A ÉSTE
			formulario.FormularioPadre = this;
			
			//SE MUESTRA EL FORMULARIO Y NO NOS PERMITE INTERACTUAR CON LOS DEMAS HASTA QUE SE CIERRE ÉSTE.
			//formulario.ShowDialog();
			formulario.ShowDialog();
			
			//OCULTA EL FORMULARIO, SE VUELVE A MOSTRAR CON SHOW()
			//Hide();
		}
		
		//PANTALLA PRINCIPAL  #### CUENTAS CORRIENTES
		void ButtonCuentaCorrienteClick(object sender, EventArgs e)
		{
			panelInicial.Visible = true;
			panelBotonesInicio.Visible = false;

			buttonRecuperarCliente.Visible = false;
			buttonEliminarCliente.Visible = false;
						
			dataGridViewBuscarCuentasCorrientes.ClearSelection();			
		}
		
		//EN CUENTAS CORRIENTES ####  SELECCIONAR UN CLIENTE DEL DATAGRIDVIEW
		void DataGridViewBuscarCuentasCorrientesCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{		
			//VARIABLE GLOBAL			
			IdCliente = Convert.ToInt32(dataGridViewBuscarCuentasCorrientes.CurrentRow.Cells["IdCliente"].Value);
			
			//CREAMOS UN NUEVO FORMULARIO DE VERCUENTA Y GUARDAMOS EL FORMULARIO PRINCIPAL EN FORMULARIOPADRE
			Form_VerCuenta verCuenta = new Form_VerCuenta();
			verCuenta.FormularioPadre = this;
			verCuenta.Cliente = con.CargarCliente(IdCliente);
			verCuenta.ShowDialog();

			ActualizarListaClientes();
		}
		
		//EN CUENTAS CORRIENTES
		void ButtonAgregarClienteClick(object sender, EventArgs e)
		{
			Form_AgregarCliente nuevoCliente = new Form_AgregarCliente();
			
			nuevoCliente.FormularioPadre = this;
			nuevoCliente.ModificarSi = 0;
			
			nuevoCliente.ShowDialog();
		}
		
		//EN CUENTAS CORRIENTES
		void ButtonAtrasVolverClick(object sender, EventArgs e)
		{
			panelBotonesInicio.Visible = true;
			panelInicial.Visible = false;
		}
		
		//EN CUENTAS CORRIENTES
		void ButtonBuscarCuentasCorrientesClick(object sender, EventArgs e)
		{
			buttonEliminarCliente.Visible = false;
			buttonRecuperarCliente.Visible = false;

			string palabra = textBoxBuscar.Text;
			
			if (checkBoxUsuariosBorrados.Checked) {
                dataGridViewBuscarCuentasCorrientes.DataSource = con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE Nombre LIKE '%" + palabra + "%' ORDER BY Nombre;");
			}
			else
			{
                dataGridViewBuscarCuentasCorrientes.DataSource = con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE Nombre LIKE '%" + palabra + "%' AND habilitado = " + 1 + " ORDER BY Nombre;");
			}
		}
		
		//EN CUENTAS CORRIENTES
		void ButtonEliminarClienteClick(object sender, EventArgs e)
		{
			con.ModificarDatosBD("UPDATE IdCliente SET habilitado = " + 0 + " WHERE idcliente =" + IdCliente + ";");
			ActualizarListaClientes();
		}
		
		void DataGridViewBuscarCuentasCorrientesCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//ESTO ES LO ULTIMO QUE MODIFIQUÉ EN IdCliente
			IdCliente = Convert.ToInt32(dataGridViewBuscarCuentasCorrientes.Rows[e.RowIndex].Cells["idcliente"].Value);
			Cliente cliente = con.CargarCliente(IdCliente);

			if (e.Button == MouseButtons.Left)
		    {
				if (cliente.Habilitado) 
				{
					buttonEliminarCliente.Visible = true;
					buttonRecuperarCliente.Visible = false;
				}
				else
				{
					buttonRecuperarCliente.Visible = true;
					buttonEliminarCliente.Visible = false;
				}
		    }
			else
			{
				dataGridViewBuscarCuentasCorrientes.CurrentCell = dataGridViewBuscarCuentasCorrientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
				var menu = new ContextMenu();
				
				menu.MenuItems.Add(new MenuItem("Modificar", ModificarCliente));
				menu.MenuItems.Add(new MenuItem("Nuevo Condicional", AgregarCondicional));
				
				Rectangle coordenada = dataGridViewBuscarCuentasCorrientes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

				int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
				int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda
				
				//Y para mostrar el menú lo haces de esta forma:  
				int X = anchoCelda + e.X;
				int Y = altoCelda + e.Y;
				
				menu.Show(dataGridViewBuscarCuentasCorrientes, new Point(X, Y));
			}
		}
		
		void ModificarCliente(Object sender, EventArgs e)
		{
			Form_AgregarCliente modificarCliente = new Form_AgregarCliente();
			modificarCliente.FormularioPadre = this;
			modificarCliente.ModificarSi = 1;
			modificarCliente.ShowDialog();
		}

		void AgregarCondicional(Object sender, EventArgs e)
        {
			Form_NuevoCondicional nuevoCondicional = new Form_NuevoCondicional();
			nuevoCondicional.FormularioPadre = this;
			nuevoCondicional.IdCliente = IdCliente;
			nuevoCondicional.EsCliente = true;
			nuevoCondicional.ShowDialog();
        }
		
		void ButtonRecuperarClienteClick(object sender, EventArgs e)
		{
			con.ModificarDatosBD("UPDATE IdCliente SET habilitado = " + 1 + " WHERE idcliente =" + IdCliente + ";");
			checkBoxUsuariosBorrados.Checked = false;
			ActualizarListaClientes();
		}
		
		void ButtonTarjetasClick(object sender, EventArgs e)
		{
			Form_TarjetasCredito compraTarjeta = new Form_TarjetasCredito();
			compraTarjeta.formularioPadre = this;
			compraTarjeta.ShowDialog();
		}
		
		void ButtonMorososClick(object sender, EventArgs e)
		{
			Form_Morosos morosos = new Form_Morosos();
			morosos.FormularioPadre = this;
			morosos.ShowDialog();
		}

        private void buttonPresupuestos_Click(object sender, EventArgs e)
        {
			Form_MensajeCondicional mensaje = new Form_MensajeCondicional();
			mensaje.formularioPadre = this;
			mensaje.idCliente = IdCliente;
			mensaje.ShowDialog();
        }

        private void buttonTarjetas_MouseMove(object sender, MouseEventArgs e)
        {
			string imagePath = Path.Combine(Application.StartupPath, "static/tarjetas.png");
			buttonTarjetas.BackgroundImage = Image.FromFile(imagePath);
		}

        private void buttonTarjetas_MouseLeave(object sender, EventArgs e)
        {
			buttonTarjetas.BackgroundImage = null;
		}

		private void buttonEfectivo_MouseMove(object sender, MouseEventArgs e)
		{
            string imagePath = Path.Combine(Application.StartupPath, "static/contado.png");
            buttonEfectivo.BackgroundImage = Image.FromFile(imagePath);
        }

		private void buttonEfectivo_MouseLeave(object sender, EventArgs e)
		{
            buttonEfectivo.BackgroundImage = null;
        }

		private void buttonPresupuestos_MouseMove(object sender, MouseEventArgs e)
		{
            string imagePath = Path.Combine(Application.StartupPath, "static/condicional.png");
            buttonPresupuestos.BackgroundImage = Image.FromFile(imagePath);
        }

		private void buttonPresupuestos_MouseLeave(object sender, EventArgs e)
		{
			buttonPresupuestos.BackgroundImage= null;
		}

		private void buttonCuentaCorriente_MouseMove(object sender, MouseEventArgs e)
		{
            string imagePath = Path.Combine(Application.StartupPath, "static/probando.png");
            buttonCuentaCorriente.BackgroundImage = Image.FromFile(imagePath);
        }

		private void buttonCuentaCorriente_MouseLeave(object sender, EventArgs e)
		{
			buttonCuentaCorriente.BackgroundImage = null;	
		}

		private void buttonMorosos_MouseMove(object sender, MouseEventArgs e)
		{
            string imagePath = Path.Combine(Application.StartupPath, "static/morosos.png");
            buttonMorosos.BackgroundImage = Image.FromFile(imagePath);
        }

		private void buttonMorosos_MouseLeave(object sender, EventArgs e)
		{
            buttonMorosos.BackgroundImage = null;
        }

		private void buttonCerrar_Click(object sender, EventArgs e)
		{
			Close();
		}

		void LinkLabelListaPrecios_Click(object sender, EventArgs e)
		{
			Process.Start("https://drive.google.com/file/d/1MV7DKZDDJsDnCc5CamAy3ieb7Rn6MPMn/view?usp=sharing");
		}
		
		
	}
}
