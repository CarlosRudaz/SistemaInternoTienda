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
using LoDeLali.Clases;

namespace LoDeLali
{
	/// <summary>
	/// Description of AgregarCliente.
	/// </summary>
	public partial class Form_AgregarCliente : Form
	{
		public Form_AgregarCliente()
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
		public int ModificarSi { get; set; }

		private Cliente cliente; 

        private Conexion con = new Conexion();
		
		
		void ButtonAgregarClick(object sender, EventArgs e)
		{			

			string celular = textBoxCelular.Text,
			nombre = textBoxNombre.Text.ToUpper();

			if (ModificarSi == 1) {
				con.RecibirDatosDeBD("UPDATE IdCliente SET Nombre = '" + cliente.Nombre + "', celular = '" + cliente.Celular + "' WHERE idcliente =" + FormularioPadre.IdCliente + ";");
				FormularioPadre.Show();
				FormularioPadre.ActualizarListaClientes();
				this.Close();
			}
			else if (nombre != "" && celular != "")
            {
				con.ModificarDatosBD("INSERT INTO IdCliente(Nombre,celular)VALUES('" + nombre + "', '" + celular + "' );");
				FormularioPadre.Show();
				FormularioPadre.ActualizarListaClientes();
				this.Close();
			}
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

		void AgregarClienteFormClosed(object sender, FormClosedEventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormularioPadre.Show();
			Close();
		}

		void AgregarClienteLoad(object sender, EventArgs e)
		{
            cliente = con.CargarCliente(FormularioPadre.IdCliente);
            if (ModificarSi == 1) 
			{
				buttonAgregar.Text = "MODIFICAR";
				textBoxNombre.Text = cliente.Nombre;
				textBoxCelular.Text = cliente.Celular;
			}
			else
			{
				buttonAgregar.Text = "AGREGAR";
			}
		}
		
		
	}
}
