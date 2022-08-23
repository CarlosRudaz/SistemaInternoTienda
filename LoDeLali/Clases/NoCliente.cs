using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLali.Clases
{
    internal class NoCliente
    {

        public NoCliente()
        {

        }

        string nombre, celular;
        int idNoCliente;

        public NoCliente(int idNoCliente, string nombre, string celular)
        {
            this.idNoCliente = idNoCliente;
            this.nombre = nombre;
            this.celular = celular;
        }

        public int IdNoCliente
        {
            get { return idNoCliente; }
            set { idNoCliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }


    }
}
