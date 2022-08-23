/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 05/07/2022
 * Hora: 23:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace LoDeLali
{
	/// <summary>
	/// Description of VentasContado.
	/// </summary>
	public class VentasContado
	{
		public VentasContado()
		{
		}
		
		double monto;
		string venta;
		
		public VentasContado(double monto, string venta)
		{
			this.monto = monto;
			this.venta = venta;
		}
		
		public double Monto
		{
			get{return monto;}
			set{monto = value;}
		}
		
		public string Venta
		{
			get{return venta;}
			set{venta = value;}
		}
		
	}
}
