using LoDeLali.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoDeLali
{
    public partial class Form_ListaCondicionales : Form
    {
        public Form_ListaCondicionales()
        {
            InitializeComponent();
        }

        public MainForm FormularioPadre { get; set; }

        private DataTable clientesConCondicional, noClientesConCondicional;
        private Conexion con = new Conexion();
        private int idCliente;

        public void ListaCondicionales_Load(object sender, EventArgs e)
        {
            //tabla con los condicionales de clientes registrados
            clientesConCondicional = con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE condicional = " + 1 + ";");

            //tabla con los condicionales de personas que son clientes y no cuentan con cuenta corriente
            noClientesConCondicional = con.RecibirDatosDeBD("SELECT * FROM nocliente;");

            //MOSTRAMOS DATA GRID DE CLIENTES CON CONDICIONAL
            dataGridViewAgendados.DataSource = clientesConCondicional;
            dataGridViewAgendados.Columns["IdCliente"].Visible = false;
            dataGridViewAgendados.Columns["moroso"].Visible = false;
            dataGridViewAgendados.Columns["habilitado"].Visible = false;
            dataGridViewAgendados.Columns["condicional"].Visible = false;
            dataGridViewAgendados.Columns["celular"].Visible = false;

            //MOSTRAMOS DATA GRID DE NO CLIENTES CON CONDICIONALES
            dataGridViewSinAgendar.DataSource = noClientesConCondicional;
            dataGridViewSinAgendar.Columns["idNoCliente"].Visible = false;
            dataGridViewSinAgendar.Columns["celular"].Visible = false;
            
            //BUSCAMOS TODOS LOS REGISTROS DE CONDICIONAL PARA VER CUALES ESTÁN FUERA DE TÉRMINO
            DateTime fechaActual = DateTime.Now;
            string fecha;
            DataTable tabla = new DataTable();
            tabla = con.RecibirDatosDeBD("SELECT * FROM condicional");

            //limpiamos selección
            dataGridViewSinAgendar.ClearSelection();
            dataGridViewAgendados.ClearSelection();

            //RECORREMOS "TABLA" PARA SACAR LAS DIFERENCIAS DE FECHA CON LA FECHA ACTUAL
            for (int i = 0; i < tabla.Rows.Count-1; i++)
            {
                fecha = tabla.Rows[i]["fecha"].ToString();
                TimeSpan diferenciaDeDias = fechaActual.Subtract(Convert.ToDateTime(fecha));
                //Recorremos todos los condicionales de clientes para ver si alguno está registrado hace más de un día
                if (diferenciaDeDias.Hours >= 24 && tabla.Rows[i]["cliente_idcliente"] != null)
                {
                    for (int j = 0; j < dataGridViewAgendados.Rows.Count-1; j++)
                    {
                        if (dataGridViewAgendados.Rows[j].Cells["idcliente"].Value.ToString() == tabla.Rows[i]["cliente_idcliente"].ToString())
                        {
                            dataGridViewAgendados.Rows[j].DefaultCellStyle.BackColor = Color.Red;
                        }
                        
                    }
                    
                }
                //Recorremos todos los condicionales de NO clientes para ver si alguno está registrado hace más de un día
                if (diferenciaDeDias.Hours >= 24 && tabla.Rows[i]["nocliente_idNoCliente"] != null)
                {
                    for (int j = 0; j < dataGridViewSinAgendar.Rows.Count - 1; j++)
                    {
                        if (dataGridViewSinAgendar.Rows[j].Cells["idNoCliente"].Value.ToString() == tabla.Rows[i]["nocliente_idNoCliente"].ToString())
                        {
                            dataGridViewSinAgendar.Rows[j].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void dataGridViewAgendados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idCliente = Convert.ToInt32(dataGridViewAgendados.CurrentRow.Cells["idcliente"].Value.ToString());

            Form_VerCondicional verCondicional = new Form_VerCondicional();
            verCondicional.FormularioPadre = FormularioPadre;
            verCondicional.IdCliente = idCliente;
            verCondicional.ListaCondicionales = this;
            //this.Close();
            verCondicional.ShowDialog();
        }

        private void dataGridViewSinAgendar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idCliente = Convert.ToInt32(dataGridViewSinAgendar.CurrentRow.Cells["idNoCliente"].Value.ToString());

            Form_VerCondicionalNoCliente verCondicional = new Form_VerCondicionalNoCliente();
            verCondicional.FormularioPadre = FormularioPadre;
            verCondicional.IdCliente = idCliente;
            verCondicional.ListaCondicionales = this;
            //this.Hide();
            verCondicional.ShowDialog();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Close();
            FormularioPadre.Show();
        }
    }
}
