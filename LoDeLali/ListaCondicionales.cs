using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLali
{
    public partial class ListaCondicionales : Form
    {
        public ListaCondicionales()
        {
            InitializeComponent();
        }


        public MainForm formularioPadre;

        public void ListaCondicionales_Load(object sender, EventArgs e)
        {

            string consulta = "SELECT * FROM cliente WHERE condicional = " + 1 + ";";
            DataTable clientesConCondicional = new DataTable();
            clientesConCondicional = formularioPadre.GetBD(consulta);


            consulta = "SELECT * FROM nocliente;";
            DataTable noClientesConCondicional = new DataTable();
            noClientesConCondicional = formularioPadre.GetBD(consulta);

            //MOSTRAMOS DATA GRID DE CLIENTES CON CONDICIONAL
            dataGridViewAgendados.DataSource = clientesConCondicional;
            dataGridViewAgendados.Columns["idCliente"].Visible = false;
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
            consulta = "SELECT * FROM condicional";
            tabla = formularioPadre.GetBD(consulta);

            dataGridViewSinAgendar.ClearSelection();
            dataGridViewAgendados.ClearSelection();

            //RECORREMOS "TABLA" PARA SACAR LAS DIFERENCIAS DE FECHA CON LA FECHA ACTUAL
            for (int i = 0; i < tabla.Rows.Count-1; i++)
            {
                fecha = tabla.Rows[i]["fecha"].ToString();
                TimeSpan diferenciaDeDias = fechaActual.Subtract(Convert.ToDateTime(fecha));
                //MessageBox.Show(fecha + "  " +diferenciaDeDias.Days);
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
                //MessageBox.Show(tabla.Rows[i]["nocliente_idNoCliente"].ToString());
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
            int idCliente = Convert.ToInt32(dataGridViewAgendados.CurrentRow.Cells["idcliente"].Value.ToString());

            VerCondicional verCondicional = new VerCondicional();
            verCondicional.formularioPadre = formularioPadre;
            verCondicional.idCliente = idCliente;
            verCondicional.listaCondicionales = this;
            //this.Close();
            verCondicional.ShowDialog();
        }

        private void dataGridViewSinAgendar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idCliente = Convert.ToInt32(dataGridViewSinAgendar.CurrentRow.Cells["idNoCliente"].Value.ToString());

            VerCondicionalNoCliente verCondicional = new VerCondicionalNoCliente();
            
            verCondicional.formularioPadre = formularioPadre;
            verCondicional.idCliente = idCliente;
            verCondicional.listaCondicionales = this;
            //this.Hide();
            verCondicional.ShowDialog();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Close();
            formularioPadre.Show();
        }
    }
}
