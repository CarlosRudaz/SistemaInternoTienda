using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLali.Clases
{
    internal class Conexion
    {
        private MySqlConnection MiBaseDeDatos;
        private Datos_ConexionBD con = new Datos_ConexionBD();
        private DataTable datosClientes = new DataTable();



        public DataTable RecibirDatosDeBD(string consulta)
        {
            //LE DAMOS LOS VALORES PARA ARRANCAR LA BASE DE DATOS.
            this.MiBaseDeDatos = new MySqlConnection("server=" + con.Servidor + "; PORT=" + con.Puerto + "; database= " + con.BaseDeDatos + "; uid=" + con.Usuario + "; pwd=" + con.Contrasena);

            //miBaseDeDatos = new MySqlConnection("server=192.168.0.113; database=lo_de_lali2022; uid=tienda;pwd=1234");  /*PARA TRABAJAR EN RED*/
            this.MiBaseDeDatos.Open();

            //GENERAMOS CONSULTA PARA QUE NOS LISTE TODOS LOS CLIENTES
            MySqlCommand listaClientes = new MySqlCommand(consulta, this.MiBaseDeDatos);
            //"SELECT * FROM IdCliente WHERE habilitado = " + 1 + " ORDER BY Nombre;"

            //DATAADAPTER RECIBE LA QUERY DE LA BASE DE DATOS Y LA TRADUCE A UNA TABLA DEL LENGUAJE
            MySqlDataAdapter traductorDeTablas = new MySqlDataAdapter(listaClientes);

            //FILL CARGA LOS DATOS QUE RECIBIMOS DE LA BASE DE DATOS Y LAS CARGA EN NUESTRA NUEVA TABLA
            traductorDeTablas.Fill(datosClientes);

            this.MiBaseDeDatos.Close();

            return datosClientes;
        }

        public Cliente CargarCliente(int idCliente)
        {
            //BIBLIOTECA DE C# QUE CREA UNA TABLA DE DATOS
            DataTable tabla = new DataTable();
            tabla = this.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE IdCliente = " + idCliente + ";");

            Cliente cliente = new Cliente(idCliente,
                                           tabla.Rows[0]["Nombre"].ToString(),
                                           tabla.Rows[0]["celular"].ToString(),
                                           Convert.ToBoolean(tabla.Rows[0]["habilitado"]),
                                           Convert.ToBoolean(tabla.Rows[0]["moroso"]),
                                           Convert.ToBoolean(tabla.Rows[0]["condicional"]));

            return cliente;
        }


        //PROCEDIMIENTO QUE SE ENCARGA DE INSERTAR, MODIFICAR O ELIMINAR DEPENDIENDO DE LA CONSULTA QUE RECIBE
		public void ModificarDatosBD(string consulta)
		{
			try{
				//SIEMPRE ANTES DE CADA ACTIVIDAD CON LA BASE DE DATOS SE DEBE ABRIR Y LUEGO CERRAR
				this.MiBaseDeDatos.Open();
				
				MySqlCommand accionBaseDeDatos = new MySqlCommand(consulta, this.MiBaseDeDatos);
				
				// EXECUTENONQUERY ES EL METODO ENCARGADO DE AGREGAR, MODIFICAR O ELIMINAR ELEMENTOS DE LA BD
				accionBaseDeDatos.ExecuteNonQuery();
				
				this.MiBaseDeDatos.Close();
				
			}catch(Exception ex)
			{
				MessageBox.Show("ERROR CON BASE DE DATOS    ---->> saqué la excepción" + ex );
				this.MiBaseDeDatos.Close();
			}
		}











    }
}
