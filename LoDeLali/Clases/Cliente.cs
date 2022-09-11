/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 04/07/2022
 * Hora: 10:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using LoDeLali.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoDeLali
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		public Cliente()
		{
		}
		
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Celular { get; set; }
		public bool Habilitado { get; set; }
		public bool Moroso { get; set; }
		public bool Condicional { get; set; }

		private Conexion con = new Conexion();

        public Cliente(int id, string nombre, string celular, bool habilitado, bool moroso)
		{
			this.Id = id;
			this.Nombre = nombre;
			this.Celular = celular;
			this.Habilitado = habilitado;
			this.Moroso = moroso;
			this.Condicional = false;
		}
		public Cliente(int id, string nombre, string celular, bool habilitado, bool moroso, bool condicional)
		{
			this.Id = id;
			this.Nombre = nombre;
			this.Celular = celular;
			this.Habilitado = habilitado;
			this.Moroso = moroso;
			this.Condicional = condicional;
		}

		public void CargarCondicional(int cantidad, double precioUni, string producto)
		{
			MainForm FormularioPadre = new MainForm();
			double total = 0, saldo = 0;
			
            CuentasCorrientes ultimoRegistro = FormularioPadre.cargarUltimoRegistro(this.Id);

            string descripcion = cantidad.ToString() + " " + producto + " c/u " + precioUni.ToString();
            total = ultimoRegistro.Saldo;
            saldo = total;
            saldo += (precioUni * cantidad);

            con.ModificarDatosBD("INSERT INTO cuentascorrientes(fecha,descripcion,compra,total,entrega,saldo,cliente_idcliente)" +
                        "VALUES('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "', '" + descripcion.ToUpper() + "', " + (precioUni * cantidad) + ", " + ultimoRegistro.Saldo + ", " + 0 + ", " +
                        saldo + ", " + this.Id + ");");           
        }

        public void SinCondicional()
		{
            con.ModificarDatosBD("UPDATE IdCliente SET condicional = 0 WHERE idcliente = " + this.Id + ";");
        }

        public void BorrarCondicional()
		{
            con.ModificarDatosBD("DELETE FROM condicional WHERE cliente_idcliente = " + this.Id + ";");
        }


    }
}
