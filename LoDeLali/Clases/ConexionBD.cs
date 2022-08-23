using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLali.Clases
{
    class ConexionBD
    {
        string servidor, puerto, baseDeDatos, usuario, contrasena;

        public ConexionBD()
        {
            this.servidor = "127.0.0.1";
            this.puerto = "3306";
            this.baseDeDatos = "lo_de_lali2022";
            this.usuario = "root";
            this.contrasena = "CarlosRudaz89";
        }

        public string Servidor { get { return this.servidor; } }
        public string Puerto { get { return this.puerto; } }
        public string BaseDeDatos { get { return this.baseDeDatos; } }
        public string Usuario { get { return this.usuario; } }
        public string Contrasena { get { return this.contrasena; } }




    }
}