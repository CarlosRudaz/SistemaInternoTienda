/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 05/07/2022
 * Hora: 18:13
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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//VARIABLE QUE NOS PERMITE TENER EL VALOR DEL FORMULARIO PADRE
		public MainForm FormularioPadre { get; set; }

		private Conexion con = new Conexion();
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
				string producto = textBoxProducto.Text;
				double monto = Convert.ToDouble(textBoxMonto.Text);
				
				//GENERAMOS LA CONSULTA QUE ENVIAMOS A LA BASE DE DATOS
				con.ModificarDatosBD("INSERT INTO ventas(producto,monto)VALUES('" + producto +"', " + monto + " );");

				Close();
			} catch (Exception ex) {
				MessageBox.Show("Revise los datos ingresados... ERROR --->>" + ex);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormularioPadre.Show();
			Close();
		}
	}
}
