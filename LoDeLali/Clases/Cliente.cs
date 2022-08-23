/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 04/07/2022
 * Hora: 10:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

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
		
		int id;
		string nombre, celular;
		bool habilitado, moroso, condicional;
		
		public Cliente(int id, string nombre, string celular, bool habilitado, bool moroso)
		{
			this.id = id;
			this.nombre = nombre;
			this.celular = celular;
			this.habilitado = habilitado;
			this.moroso = moroso;
			this.condicional = false;
		}
		public Cliente(int id, string nombre, string celular, bool habilitado, bool moroso, bool condicional)
		{
			this.id = id;
			this.nombre = nombre;
			this.celular = celular;
			this.habilitado = habilitado;
			this.moroso = moroso;
			this.condicional = condicional;
		}

		public bool Moroso
		{
			get{return moroso;}
			set{moroso = value;}
		}
		
		public int Id
		{
			get{return id;}
			set{id = value;}
		}
		
		public string Nombre
		{
			get{return nombre;}
			set{nombre = value;}
		}
		
		public string Celular
		{
			get{return celular;}
			set{celular = value;}
		}
		
		public bool Habilitado
		{
			get{return habilitado;}
			set{habilitado = value;}
		}

		public bool Condicional
        {
			get{return condicional;}
			set{condicional = value;}
        }
		
	}
}
