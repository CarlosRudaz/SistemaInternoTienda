using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLali.Clases
{
    internal class Condicional
    {
        public Condicional()
        {

        }

        public Condicional(string nombre, string fecha, string producto, double precioUni, int cantidades)
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.producto = producto;
            this.precioUni = precioUni;
            this.cantidades = cantidades;
            this.precioTotal = precioUni * cantidades;
            this.confirmado = false;

        }

        string fecha, nombre;
        double precioUni, precioTotal;
        string producto;
        int cantidades;
        bool confirmado;
        
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Producto { get { return producto; } set {producto = value; } }
        public double PreciosUni { get { return precioUni; } set { precioUni = value; } }
        public int Cantidades { get { return cantidades; } set{ cantidades = value; } }
        public double PrecioTotal { get { return precioTotal; } set { precioTotal = value; } }
        public bool Confirmado { get { return confirmado; } set { confirmado = value; } }



    }
}
