using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLali.Clases
{
    internal class ConexionBD
    {
        string servidor, puerto, usuario, contraseña, baseDeDatos;

        public ConexionBD()
        {
            this.servidor = "192.168.0.102";
            this.puerto = "3306";
            this.baseDeDatos = "lo_de_lali2022";
            this.usuario = "tiendaOnline";
            this.contraseña = "CarlosRudaz89";
        }

        public string Servidor
        {
            get { return this.servidor; }
            set { this.servidor = value; }
        }

        public string Puerto
        {   get { return this.puerto; }
            set { this.puerto = value; }
        }

        public string BaseDeDatos
        {
            get { return this.baseDeDatos; }
            set{ this.baseDeDatos = value; }
        }

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Contraseña
        {
            get { return this.contraseña; }
            set { contraseña = value; }
        }
    }
}
