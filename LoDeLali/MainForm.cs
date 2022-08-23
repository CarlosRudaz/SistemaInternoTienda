using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

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
		public MySqlConnection miBaseDeDatos;
		public DataTable datosClientes = new DataTable(), datosCuentasCorrientes = new DataTable();
		Clases.ConexionBD con = new Clases.ConexionBD();
		
		

		//CON ESTE METODO NOS ENCARGAMOS QUE AL INICIAR EL PROGRAMA, LOS DATOS DE LA BASE YA ESTEN CARGADOS
		private void MainForm_Load(object sender, EventArgs e)
		{
			//LE DAMOS LOS VALORES PARA ARRANCAR LA BASE DE DATOS.
			miBaseDeDatos = new MySqlConnection("server=" + con.Servidor +  "; PORT=" + con.Puerto + "; database= " + con.BaseDeDatos + "; uid=" + con.Usuario  +"; pwd=" + con.Contrasena);
            
            //miBaseDeDatos = new MySqlConnection("server=192.168.0.113; database=lo_de_lali2022; uid=tienda;pwd=1234");  /*PARA TRABAJAR EN RED*/
            miBaseDeDatos.Open();
			//GENERAMOS CONSULTA PARA QUE NOS LISTE TODOS LOS CLIENTES
			MySqlCommand listaClientes = new MySqlCommand("SELECT * FROM cliente WHERE habilitado = " + 1 + " ORDER BY nombre;", miBaseDeDatos);

			//DATAADAPTER RECIBE LA QUERY DE LA BASE DE DATOS Y LA TRADUCE A UNA TABLA DEL LENGUAJE
			MySqlDataAdapter traductorDeTablas = new MySqlDataAdapter(listaClientes);

			//FILL CARGA LOS DATOS QUE RECIBIMOS DE LA BASE DE DATOS Y LAS CARGA EN NUESTRA NUEVA TABLA
			traductorDeTablas.Fill(datosClientes);

			mostrarDataGrid(datosClientes);

			miBaseDeDatos.Close();
		}

		public void ActualizarListaCuentasCorrientes()
		{
            string consulta = "SELECT * FROM cuentascorrientes WHERE cliente_idCliente = "
                + idCliente
                + ";";
			
			datosCuentasCorrientes = GetBD(consulta);
			dataGridViewBuscarCuentasCorrientes.DataSource = datosCuentasCorrientes;
			dataGridViewBuscarCuentasCorrientes.ClearSelection();
			
		}
		
		public void ActualizarListaClientes()
		{
			string consulta;
			
			if (checkBoxUsuariosBorrados.Checked) {
				consulta = "SELECT * FROM cliente ORDER BY nombre;";
			}
			else
			{
				consulta = "SELECT * FROM cliente WHERE habilitado = " + 1 + " ORDER BY nombre;";
			}
			
			datosClientes = GetBD(consulta); 		

			mostrarDataGrid(datosClientes);
			
			buttonRecuperarCliente.Visible = false;
			buttonEliminarCliente.Visible = false;
			idCliente = -1;
			
		}
		
		public Cliente cargarCliente(int idCliente)
		{
			string consulta = "SELECT * FROM cliente WHERE idCliente = " + idCliente + ";";
			miBaseDeDatos.Open();
			MySqlCommand buscarClientes = new MySqlCommand(consulta, miBaseDeDatos);
			
			//DATAADAPTER RECIBE LA QUERY DE LA BASE DE DATOS Y LA TRADUCE A UNA TABLA DEL LENGUAJE
			MySqlDataAdapter traductorDeTablas = new MySqlDataAdapter(buscarClientes);
			miBaseDeDatos.Close();
			
			//BIBLIOTECA DE C# QUE CREA UNA TABLA DE DATOS
			DataTable tabla = new DataTable();
			
			//FILL CARGA LOS DATOS QUE RECIBIMOS DE LA BASE DE DATOS Y LAS CARGA EN NUESTRA NUEVA TABLA
			traductorDeTablas.Fill(tabla);
			
			// Get the DataTable of a DataSet
		    //DataRow[] rows = tabla.Select();
		    
		    Cliente cliente1 = new Cliente(idCliente, 
		                                   tabla.Rows[0]["nombre"].ToString(),
										   tabla.Rows[0]["celular"].ToString(), 
		                                   Convert.ToBoolean(tabla.Rows[0]["habilitado"]), 
		                                   Convert.ToBoolean(tabla.Rows[0]["moroso"]),
										   Convert.ToBoolean(tabla.Rows[0]["condicional"]));
			
			return cliente1;
		}
		
		//COMO MAINFORM ES UNA CLASE, CREO ESTA VARIABLE PARA TRABAJAR CON UN USUARIO EN PARTICULAR USANDO SU ID
		private int idCliente;
		public int IdCliente
		{
			get{return idCliente;}
			set{idCliente = value;}
		}
		
		public void mostrarDataGrid(DataTable tabla)
		{
			dataGridViewBuscarCuentasCorrientes.DataSource = datosClientes;
			dataGridViewBuscarCuentasCorrientes.Columns["habilitado"].Visible = false;
			dataGridViewBuscarCuentasCorrientes.Columns["idCliente"].Visible = false;
			dataGridViewBuscarCuentasCorrientes.Columns["moroso"].Visible = false;
			dataGridViewBuscarCuentasCorrientes.Columns["condicional"].Visible = false;

			dataGridViewBuscarCuentasCorrientes.ClearSelection();
		}
		
		//PROCEDIMIENTO QUE SE ENCARGA DE INSERTAR, MODIFICAR O ELIMINAR DEPENDIENDO DE LA CONSULTA QUE RECIBE
		public void CrudBD(string consulta)
		{
			try{
				//SIEMPRE ANTES DE CADA ACTIVIDAD CON LA BASE DE DATOS SE DEBE ABRIR Y LUEGO CERRAR
				miBaseDeDatos.Open();
				
				MySqlCommand accionBaseDeDatos = new MySqlCommand(consulta, miBaseDeDatos);
				
				// EXECUTENONQUERY ES EL METODO ENCARGADO DE AGREGAR, MODIFICAR O ELIMINAR ELEMENTOS DE LA BD
				accionBaseDeDatos.ExecuteNonQuery();
				
				miBaseDeDatos.Close();
				
			}catch(Exception ex)
			{
				MessageBox.Show("ERROR CON BASE DE DATOS    ---->> saqué la excepción" + ex );
				miBaseDeDatos.Close();
			}
		}
		
		//FUNCION QUE USAMOS EN TODOS LOS FORMS PARA LEER VALORES EN LA BASE DE DATOS
		public DataTable GetBD(string consulta)
		{
			miBaseDeDatos.Open();
			MySqlCommand buscarClientes = new MySqlCommand(consulta, miBaseDeDatos);
			
			//DATAADAPTER RECIBE LA QUERY DE LA BASE DE DATOS Y LA TRADUCE A UNA TABLA DEL LENGUAJE
			MySqlDataAdapter traductorDeTablas = new MySqlDataAdapter(buscarClientes);
			miBaseDeDatos.Close();
			
			//BIBLIOTECA DE C# QUE CREA UNA TABLA DE DATOS
			DataTable tabla = new DataTable();
			
			//FILL CARGA LOS DATOS QUE RECIBIMOS DE LA BASE DE DATOS Y LAS CARGA EN NUESTRA NUEVA TABLA
			traductorDeTablas.Fill(tabla);
			
			return tabla;
		}
		
		public CuentasCorrientes cargarUltimoRegistro(int idCliente)
		{
			string consulta = "SELECT * FROM cuentascorrientes WHERE cliente_idCliente = " + idCliente + ";";
			miBaseDeDatos.Open();
			MySqlCommand buscarClientes = new MySqlCommand(consulta, miBaseDeDatos);
			
			//DATAADAPTER RECIBE LA QUERY DE LA BASE DE DATOS Y LA TRADUCE A UNA TABLA DEL LENGUAJE
			MySqlDataAdapter traductorDeTablas = new MySqlDataAdapter(buscarClientes);
			miBaseDeDatos.Close();
			
			//BIBLIOTECA DE C# QUE CREA UNA TABLA DE DATOS
			DataTable tabla = new DataTable();
			
			//FILL CARGA LOS DATOS QUE RECIBIMOS DE LA BASE DE DATOS Y LAS CARGA EN NUESTRA NUEVA TABLA
			traductorDeTablas.Fill(tabla);
			
			if(tabla.Rows.Count > 0)
			{
				// Get the DataTable of a DataSet
				//DataRow[] rows = tabla.Select();
				//string fecha = tabla.Rows[tabla.Rows.Count-1]["fecha"].ToString();
				//MessageBox.Show(fecha);


				CuentasCorrientes ultimoRegistro = new CuentasCorrientes(tabla.Rows[tabla.Rows.Count - 1]["fecha"].ToString(),
																		 tabla.Rows[tabla.Rows.Count - 1]["descripcion"].ToString(),
				                                                        Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["compra"]), 
				                                                        Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["total"]),
				                                                        Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["entrega"]), 
			                                                            Convert.ToDouble(tabla.Rows[tabla.Rows.Count - 1]["saldo"]),
			                                                            Convert.ToInt32(tabla.Rows[tabla.Rows.Count - 1]["cliente_idcliente"]));
				return ultimoRegistro;
			} 
			else
			{
				DataRow[] rows = tabla.Select();
				
			    CuentasCorrientes ultimoRegistro = new CuentasCorrientes("",
				                                                         "----------",
				                                                        0, 
				                                                        0,
				                                                        0, 
			                                                            0,
			                                                            idCliente);
				return ultimoRegistro;
			
			}
			
			
		}
		
		//PANTALLA PRINCIPAL
		void ButtonEfectivoClick(object sender, EventArgs e)
		{
			Form1 formulario = new Form1();
			
			//LE PASAMOS EL FORMULARIO ACTUAL, A LA NUEVA INSTANCIA DE FORM1 PARA PODER VOLVER A ÉSTE
			formulario.formularioPadre = this;
			
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
			idCliente = Convert.ToInt32(dataGridViewBuscarCuentasCorrientes.CurrentRow.Cells["idCliente"].Value);
			
			//CREAMOS UN NUEVO FORMULARIO DE VERCUENTA Y GUARDAMOS EL FORMULARIO PRINCIPAL EN FORMULARIOPADRE
			VerCuenta verCuenta = new VerCuenta();
			verCuenta.formularioPadre = this;
			verCuenta.cliente = cargarCliente(idCliente);
			
			
			verCuenta.ShowDialog();
			ActualizarListaClientes();
		}
		
		//EN CUENTAS CORRIENTES
		void ButtonAgregarClienteClick(object sender, EventArgs e)
		{
			AgregarCliente nuevoCliente = new AgregarCliente();
			
			nuevoCliente.formularioPadre = this;
			nuevoCliente.modificarSi = 0;
			
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

			string palabra = textBoxBuscar.Text, consulta;
			
			if (checkBoxUsuariosBorrados.Checked) {
				consulta = "SELECT * FROM cliente WHERE nombre LIKE '%" +
										palabra + "%' ORDER BY nombre;";
			}
			else
			{
				consulta = "SELECT * FROM cliente WHERE nombre LIKE '%" + 
					palabra + 
					"%' AND habilitado = " + 1 + " ORDER BY nombre;";
			}

			dataGridViewBuscarCuentasCorrientes.DataSource = GetBD(consulta);
		}
		
		//EN CUENTAS CORRIENTES
		void ButtonEliminarClienteClick(object sender, EventArgs e)
		{
			string consulta = "UPDATE cliente SET habilitado = " + 0 + " WHERE idcliente =" + idCliente + ";";
			CrudBD(consulta);	
			ActualizarListaClientes();
		}
		
		void DataGridViewBuscarCuentasCorrientesCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//ESTO ES LO ULTIMO QUE MODIFIQUÉ EN idCliente
			idCliente = Convert.ToInt32(dataGridViewBuscarCuentasCorrientes.Rows[e.RowIndex].Cells["idcliente"].Value);
			Cliente cliente = cargarCliente(idCliente);

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
			AgregarCliente modificarCliente = new AgregarCliente();
			modificarCliente.formularioPadre = this;
			modificarCliente.modificarSi = 1;
			modificarCliente.ShowDialog();
		}

		void AgregarCondicional(Object sender, EventArgs e)
        {
			NuevoCondicional nuevoCondicional = new NuevoCondicional();
			nuevoCondicional.formularioPadre = this;
			nuevoCondicional.idCliente = idCliente;
			nuevoCondicional.esCliente = true;
			nuevoCondicional.ShowDialog();
        }
		
		void ButtonRecuperarClienteClick(object sender, EventArgs e)
		{
			string consulta = "UPDATE cliente SET habilitado = " + 1 + " WHERE idcliente =" + idCliente + ";";
			CrudBD(consulta);
			checkBoxUsuariosBorrados.Checked = false;
			ActualizarListaClientes();
		}
		
		void ButtonTarjetasClick(object sender, EventArgs e)
		{
			TarjetasCredito compraTarjeta = new TarjetasCredito();
			compraTarjeta.formularioPadre = this;
			compraTarjeta.ShowDialog();
		}
		
		void ButtonMorososClick(object sender, EventArgs e)
		{
			Morosos morosos = new Morosos();
			morosos.formularioPadre = this;
			morosos.ShowDialog();
		}

        private void buttonPresupuestos_Click(object sender, EventArgs e)
        {
			MensajeCondicional mensaje = new MensajeCondicional();
			mensaje.formularioPadre = this;
			mensaje.idCliente = idCliente;
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

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		void LinkLabel1Click(object sender, EventArgs e)
		{
			Process.Start("https://drive.google.com/file/d/1MV7DKZDDJsDnCc5CamAy3ieb7Rn6MPMn/view?usp=sharing");
		}
		
		
	}
}
