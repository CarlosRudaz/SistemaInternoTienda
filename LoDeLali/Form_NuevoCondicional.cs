/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 23/07/2022
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using LoDeLali.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoDeLali
{
	/// <summary>
	/// Description of Condicional.
	/// </summary>
	public partial class Form_NuevoCondicional : Form
	{
		public Form_NuevoCondicional()
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
		public bool EsCliente { get; set; }

		//GRABADO SE USA PARA QUE AL NO SER CLIENTE SE GENERE UN SOLO CLIENTE Y NO SE PUEDA MODIFICAR
		private bool grabado = true;
		private Cliente cliente = new Cliente();
		private string consulta;
		private Conexion con = new Conexion();

		private Cliente ObtenerNoCliente(string nombre)
        {
			grabado = false;
			DataTable tabla = con.RecibirDatosDeBD("SELECT * FROM nocliente WHERE Nombre = '" + nombre + "';");
			
			cliente.Nombre = tabla.Rows[0]["Nombre"].ToString();
			cliente.Id = Convert.ToInt32(tabla.Rows[0]["idNoCliente"]);
			cliente.Celular = tabla.Rows[0]["celular"].ToString();

			return cliente;
		}

        private void buttonAgregarFila_Click(object sender, EventArgs e)
        {
            if (EsCliente)
            {
                try
                {
					if (grabado)
					{
						con.ModificarDatosBD("UPDATE IdCliente SET condicional = true WHERE idcliente = " + IdCliente + ";");
						grabado = false;
					}

					Condicional condicional = new Condicional(cliente.Nombre,
						dateTimePickerFecha.Value.ToString("dd/MM/yyyy HH:mm"), producto1.Text.ToUpper(), Convert.ToDouble(precioUni1.Text),
						Convert.ToInt32(numericUpDownCantidad.Text));

					con.ModificarDatosBD("INSERT INTO condicional (fecha,producto,precioUni,precioTotal,cantidad,cliente_idcliente) " +
										"VALUES('" + condicional.Fecha + "','" + condicional.Producto + "'," +
										condicional.PreciosUni + "," + condicional.PrecioTotal + "," +
										condicional.Cantidades + "," + cliente.Id + ");");

					richTextBoxCondicional.Text += condicional.Cantidades.ToString() + "###" + condicional.Producto.ToString() + "###" +
												condicional.PreciosUni.ToString() + "###" + condicional.PrecioTotal.ToString() + Environment.NewLine;
				}
                catch (Exception)
                {
					MessageBox.Show("¡Revise los datos ingresados!");
				}
			}
            else
            {
                try
                {
					if (grabado)
                    {
						con.ModificarDatosBD("INSERT INTO nocliente(Nombre,celular) VALUES('" + textBoxNombre.Text.ToUpper() + "','" + textBoxCelular.Text + "'); ");
						
						cliente = ObtenerNoCliente(textBoxNombre.Text);

						textBoxCelular.Text = cliente.Celular;
						textBoxNombre.Text = cliente.Nombre;
						textBoxCelular.Enabled = false;
						textBoxNombre.Enabled = false;

						grabado = false;
					}
					
					Condicional condicional = new Condicional(cliente.Nombre.ToUpper(),
																dateTimePickerFecha.Value.ToString("dd/MM/yyyy HH:mm"), 
																producto1.Text.ToUpper(), 
																Convert.ToDouble(precioUni1.Text),
																Convert.ToInt32(numericUpDownCantidad.Text));

					con.ModificarDatosBD("INSERT INTO condicional (fecha,cantidad,producto,precioUni,precioTotal,nocliente_idNoCliente) " +
									"VALUES('" + condicional.Fecha + "'," + condicional.Cantidades + ",'" +
									condicional.Producto + "'," + condicional.PreciosUni + "," +
									condicional.PrecioTotal + "," + cliente.Id + ");");

					richTextBoxCondicional.Text +=  condicional.Cantidades.ToString() + "  ###  " + condicional.Producto + "             ###  " +
												condicional.PreciosUni.ToString() + "  ###  " + condicional.PrecioTotal.ToString() + Environment.NewLine;
				}
                catch
                {
					MessageBox.Show("¡Revise los datos ingresados!");

				}
			}
			numericUpDownCantidad.ResetText();
			producto1.Text = "";
			precioUni1.Text = "";
		}

		DataTable dt = new DataTable();	
		
		private void AutoCompletarNombreCliente()
        {
			AutoCompleteStringCollection lista = new AutoCompleteStringCollection();

            dt = con.RecibirDatosDeBD("SELECT * FROM noCliente;");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(dt.Rows[i]["Nombre"].ToString());
            }

			textBoxNombre.AutoCompleteCustomSource = lista;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void NuevoCondicional_Load(object sender, EventArgs e)
        {
			AutoCompletarNombreCliente();
			if (EsCliente)
			{
				cliente = con.CargarCliente(IdCliente);
				textBoxCelular.Text = cliente.Celular;
				textBoxNombre.Text = cliente.Nombre;
				textBoxCelular.Enabled = false;
				textBoxNombre.Enabled = false;
			}
		}
    }
}
