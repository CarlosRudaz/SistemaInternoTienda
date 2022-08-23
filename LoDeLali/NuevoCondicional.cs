/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 23/07/2022
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoDeLali
{
	/// <summary>
	/// Description of Condicional.
	/// </summary>
	public partial class NuevoCondicional : Form
	{
		public NuevoCondicional()
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
		public int idCliente;
		public bool esCliente;

		//GRABADO SE USA PARA QUE AL NO SER CLIENTE SE GENERE UN SOLO CLIENTE Y NO SE PUEDA MODIFICAR
		bool grabado = true;
		Cliente cliente = new Cliente();
		string consulta;

		private Cliente ObtenerNoCliente(string nombre)
        {
			grabado = false;
			string consulta = "SELECT * FROM nocliente WHERE nombre = '" + nombre + "';";
			DataTable tabla = new DataTable();
			tabla = formularioPadre.GetBD(consulta);

			Cliente cliente = new Cliente();
			
			cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
			cliente.Id = Convert.ToInt32(tabla.Rows[0]["idNoCliente"]);
			cliente.Celular = tabla.Rows[0]["celular"].ToString();

			return cliente;
		}

        private void buttonAgregarFila_Click(object sender, EventArgs e)
        {
			
            if (esCliente)
            {
                try
                {
					if (grabado)
					{
						consulta = "UPDATE cliente SET condicional = true WHERE idcliente = " + idCliente + ";";
						formularioPadre.CrudBD(consulta);
						grabado = false;
					}
					Clases.Condicional condicional = new Clases.Condicional(cliente.Nombre,
						dateTimePickerFecha.Value.ToString("dd/MM/yyyy HH:mm"), producto1.Text.ToUpper(), Convert.ToDouble(precioUni1.Text),
						Convert.ToInt32(numericUpDownCantidad.Text));

					consulta = "INSERT INTO condicional (fecha,producto,precioUni,precioTotal,cantidad,cliente_idcliente) " +
										"VALUES('" + condicional.Fecha + "','" + condicional.Producto + "'," +
										condicional.PreciosUni + "," + condicional.PrecioTotal + "," +
										condicional.Cantidades + "," + cliente.Id + ");";

					formularioPadre.CrudBD(consulta);

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
						consulta = "INSERT INTO nocliente(nombre,celular) VALUES('" + textBoxNombre.Text.ToUpper() + "','" + textBoxCelular.Text + "'); ";
						formularioPadre.CrudBD(consulta);
						
						cliente = ObtenerNoCliente(textBoxNombre.Text);

						textBoxCelular.Text = cliente.Celular;
						textBoxNombre.Text = cliente.Nombre;
						textBoxCelular.Enabled = false;
						textBoxNombre.Enabled = false;

						grabado = false;
					}

					Clases.Condicional condicional = new Clases.Condicional(cliente.Nombre.ToUpper(),
																			dateTimePickerFecha.Value.ToString("dd/MM/yyyy HH:mm"), 
																			producto1.Text.ToUpper(), 
																			Convert.ToDouble(precioUni1.Text),
																			Convert.ToInt32(numericUpDownCantidad.Text));

					consulta = "INSERT INTO condicional (fecha,cantidad,producto,precioUni,precioTotal,nocliente_idNoCliente) " +
									"VALUES('" + condicional.Fecha + "'," + condicional.Cantidades + ",'" +
									condicional.Producto + "'," + condicional.PreciosUni + "," +
									condicional.PrecioTotal + "," + cliente.Id + ");";

					

					formularioPadre.CrudBD(consulta);

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

			consulta = "SELECT * FROM noCliente;";
			dt = formularioPadre.GetBD(consulta);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lista.Add(dt.Rows[i]["nombre"].ToString());
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
			if (esCliente)
			{
				cliente = formularioPadre.cargarCliente(idCliente);
				textBoxCelular.Text = cliente.Celular;
				textBoxNombre.Text = cliente.Nombre;
				textBoxCelular.Enabled = false;
				textBoxNombre.Enabled = false;
			}
		}
    }
}
