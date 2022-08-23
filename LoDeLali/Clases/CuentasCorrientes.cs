/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 03/07/2022
 * Hora: 15:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace LoDeLali
{
	/// <summary>
	/// Description of CuentasCorrientes.
	/// </summary>
	public class CuentasCorrientes
	{
		public CuentasCorrientes()
		{
		}
		
		int cliente_idCliente;
		double total, entrega, saldo, compra;
		string descripcion;
		string fecha;
		
		public CuentasCorrientes(string fecha,string descripcion, double compra, double total, double entrega, double saldo, int cliente_idCliente)
		{
			this.fecha = fecha;
			this.saldo = saldo;
			this.compra = compra;
			this.total = total;
			this.descripcion = descripcion;
			this.entrega = entrega;
			this.cliente_idCliente = cliente_idCliente;
		}
		
		
				
		public double Total
		{
			get{return total;}
			set{total = value;}
		}
		
		public double Saldo
		{
			get{return saldo;}
			set{saldo = value;}
		}
		
		public double Compra
		{
			get{return compra;}
			set{compra = value;}
		}
				
		public string Descripcion
		{
			get{return descripcion;}
			set{descripcion = value;}
		}
		
		public string Fecha
		{
			get{return fecha;}
			set{fecha = value;}
		}
		
		public int Cliente_idCliente
		{
			get{return cliente_idCliente;}
			set{cliente_idCliente = value;}
		}
		
	}
}
