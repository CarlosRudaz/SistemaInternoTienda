/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 06/07/2022
 * Hora: 2:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace LoDeLali
{
	/// <summary>
	/// Description of AgregarCliente.
	/// </summary>
	public partial class AgregarCliente : Form
	{
		public AgregarCliente()
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
		public int modificarSi;
		string celular, nombre;
		
		
		void ButtonAgregarClick(object sender, EventArgs e)
		{			
			celular = textBoxCelular.Text;
			nombre = textBoxNombre.Text.ToUpper();
			//GENERAMOS LA CONSULTA QUE ENVIAMOS A LA BASE DE DATOS
			string consulta = "INSERT INTO cliente(nombre,celular)VALUES('" + nombre +"', '" + celular + "' );";
			
			if (modificarSi == 1) {
				consulta = "UPDATE cliente SET nombre = '" + nombre + "', celular = '" + celular + "' WHERE idcliente =" + formularioPadre.IdCliente + ";";
				formularioPadre.CrudBD(consulta);
				
				formularioPadre.Show();
				
				formularioPadre.ActualizarListaClientes();
				this.Close();
			}
			else
			{
				//METODO UBICADO EN MAINFORM QUE RECIBE CONSULTA Y SE COMUNICA CON LA BD
				if (nombre != "" && celular != "") {
					formularioPadre.CrudBD(consulta);
				
					formularioPadre.Show();
					
					formularioPadre.ActualizarListaClientes();
					
					this.Close();
				}else{
					MessageBox.Show("Datos Incorrectos");
				}
			}
		}
		void AgregarClienteFormClosed(object sender, FormClosedEventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			formularioPadre.Show();
			Close();
		}

		void AgregarClienteLoad(object sender, EventArgs e)
		{
			DataTable cliente = new DataTable();
			cliente = formularioPadre.GetBD("SELECT * FROM cliente WHERE idCliente = " + formularioPadre.IdCliente + ";");
			
			if (modificarSi == 1) {
				buttonAgregar.Text = "MODIFICAR";
				nombre = textBoxNombre.Text = cliente.Rows[0]["nombre"].ToString();
				celular = textBoxCelular.Text = cliente.Rows[0]["celular"].ToString();
			}else{
				buttonAgregar.Text = "AGREGAR";
			}
		}
		
		
	}
}
