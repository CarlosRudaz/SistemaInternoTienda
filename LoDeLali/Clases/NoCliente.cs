using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLali.Clases
{
    internal class NoCliente
    {

        public NoCliente()
        {

        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public int IdNoCliente { get; set; }

        private Conexion con;

        private MainForm FormularioPadre = new MainForm();

        public NoCliente(int idNoCliente, string nombre, string celular)
        {
            this.IdNoCliente = idNoCliente;
            this.Nombre = nombre;
            this.Celular = celular;
        }


        public void AgregarCondicionalYCliente(int cantidad, double precioUni, string producto)
        {
            DataTable noCliente = new DataTable();
            DateTime fecha = DateTime.Now;

            this.con.ModificarDatosBD("INSERT INTO IdCliente(Nombre,celular) VALUES('" + this.Nombre + "', '" + this.Celular + "' );");

            noCliente = con.RecibirDatosDeBD("SELECT * FROM IdCliente WHERE Nombre = '" + this.Nombre + "';");

            this.IdCliente = Convert.ToInt32(noCliente.Rows[0]["idcliente"]);
            
            CuentasCorrientes ultimoRegistro = FormularioPadre.cargarUltimoRegistro(IdCliente);

            string descripcion = cantidad.ToString() + " " + producto + " c/u " + precioUni.ToString();
            double total = ultimoRegistro.Saldo,
            saldo = total;
            saldo += (cantidad*precioUni);

            con.ModificarDatosBD("INSERT INTO cuentascorrientes(fecha,descripcion,compra,total,entrega,saldo,cliente_idcliente)" +
                        "VALUES('" + fecha + "', '" + descripcion.ToUpper() + "', " + (cantidad * precioUni) + ", " + total + ", " + 0 + ", " +
                        saldo + ", " + IdCliente + ");");

            con.ModificarDatosBD("UPDATE IdCliente SET condicional = 0 WHERE idcliente = " + IdCliente + ";");
        }

        public void SinCondicional()
        {
            con.ModificarDatosBD("UPDATE IdCliente SET condicional = 0 WHERE idcliente = " + IdCliente + ";");
        }

        public void BorrarCondicional()
        {
            con.ModificarDatosBD("DELETE FROM condicional WHERE nocliente_idNoCliente = " + this.IdNoCliente + ";");
            con.ModificarDatosBD("DELETE FROM noCliente WHERE idNoCliente = " + this.IdNoCliente + ";");
        }




    }
}
