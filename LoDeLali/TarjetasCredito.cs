/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 11/07/2022
 * Hora: 10:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace LoDeLali
{
	/// <summary>
	/// Description of TarjetasCredito.
	/// </summary>
	public partial class TarjetasCredito : Form
	{
		public TarjetasCredito()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public MainForm formularioPadre;
		double totalMostrar;
		
		void TextBoxMontoTextChanged(object sender, EventArgs e)
		{
			textBoxMonto.Enabled = true;
			double monto;
			string tarjeta;
			int cuotas;
			double total, precioPorCuota;
			try {
				monto = Convert.ToDouble(textBoxMonto.Text);
				precioPorCuota = monto;
				tarjeta = comboBoxTarjetas.Text;
				cuotas = Convert.ToInt32(comboBoxCuotas.Text);
				
				switch (cuotas) {
					case 1:
						totalMostrar = total = monto;
						labelCuotaSeleccionada.Text = cuotas.ToString() + "CUOTAS DE $" + total + ".";
						break;
					case 3: case 2:
						
						if (cuotas == 2) {
							totalMostrar = total = monto + (monto*0.13);
							precioPorCuota = total/2;
						}else{
							totalMostrar = total = monto + (monto*0.15);
							precioPorCuota = total/3;
						}
						labelCuotaSeleccionada.Text = cuotas.ToString() + "CUOTAS DE $" + precioPorCuota + ".";
						break;
					case 4: case 5: case 6:
						switch (cuotas) {
							case 4:
								totalMostrar = total = monto + (monto*0.19);
								precioPorCuota = total/4;
								break;
							case 5:
								totalMostrar = total = monto + (monto*0.26);
								precioPorCuota = total/5;
								break;
							case 6:
								totalMostrar = total = monto + (monto*0.26);
								precioPorCuota = total/6;
								break;
						}
						break;
				}
				labelCuotaSeleccionada.Text = cuotas.ToString() + "CUOTAS DE $" + Math.Round(precioPorCuota, 2) + "." +
					" MONTO TOTAL: $" + totalMostrar;
				EscribeLabels(cuotas, monto);
				
			} catch (Exception) {
				
				textBoxMonto.Text = "";
			}
		}
		
		public void EscribeLabels(int cuotas, double monto){
			switch (cuotas) {
					case 1:
					labelCuota1.Text = "2 CUOTAS DE $" + Math.Round((monto + (monto*0.13))/2) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.13));
					labelCuota2.Text = "3 CUOTAS DE $" + Math.Round((monto + (monto*0.15))/3) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.15));
					labelCuota3.Text = "4 CUOTAS DE $" + Math.Round((monto + (monto*0.19))/4) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.19));
					labelCuota4.Text = "6 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/6) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.26));
						break;
					case 3: case 2:
						if (cuotas == 2) {
							labelCuota1.Text = "1 CUOTAS DE $" + (monto) + ". MONTO FINAL $" + (monto);
							labelCuota2.Text = "3 CUOTAS DE $" + Math.Round((monto + (monto*0.15))/3) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.15));
							labelCuota3.Text = "4 CUOTAS DE $" + Math.Round((monto + (monto*0.19))/4) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.19));
							labelCuota4.Text = "6 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/6) + ". MONTO FINAL $" + Math.Round(monto+(monto*0.26));
						}else{
							labelCuota1.Text = "1 CUOTAS DE $" + (monto) + ". MONTO FINAL $" + (monto);
							labelCuota2.Text = "2 CUOTAS DE $" + Math.Round((monto + (monto*0.13))/2) + ". MONTO FINAL $" + (monto+(monto*0.13));
							labelCuota3.Text = "4 CUOTAS DE $" + Math.Round((monto + (monto*0.19))/4) + ". MONTO FINAL $" + (monto+(monto*0.19));
							labelCuota4.Text = "6 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/6) + ". MONTO FINAL $" + (monto+(monto*0.26));
						}
						break;
					case 4: case 5: case 6:
						
						switch (cuotas) {
							case 4:
								labelCuota1.Text = "1 CUOTAS DE $" + (monto) + ". MONTO FINAL $" + (monto);
								labelCuota2.Text = "3 CUOTAS DE $" + Math.Round((monto + (monto*0.15))/3) + ". MONTO FINAL $" + (monto+(monto*0.15));
								labelCuota3.Text = "5 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/5) + ". MONTO FINAL $" + (monto+(monto*0.26));
								labelCuota4.Text = "6 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/6) + ". MONTO FINAL $" + (monto+(monto*0.26));
								break;
							case 5:
								labelCuota1.Text = "1 CUOTAS DE $" + (monto) + ". MONTO FINAL $" + (monto);
								labelCuota2.Text = "3 CUOTAS DE $" + Math.Round((monto + (monto*0.15))/3) + ". MONTO FINAL $" + (monto+(monto*0.15));
								labelCuota3.Text = "4 CUOTAS DE $" + Math.Round((monto + (monto*0.19))/4) + ". MONTO FINAL $" + (monto+(monto*0.19));
								labelCuota4.Text = "6 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/6) + ". MONTO FINAL $" + (monto+(monto*0.26));
								break;
							case 6:
								labelCuota1.Text = "1 CUOTAS DE $" + (monto) + ". MONTO FINAL $" + (monto);
								labelCuota2.Text = "3 CUOTAS DE $" + Math.Round((monto + (monto*0.15))/3) + ". MONTO FINAL $" + (monto+(monto*0.15));
								labelCuota3.Text = "4 CUOTAS DE $" + Math.Round((monto + (monto*0.19))/4) + ". MONTO FINAL $" + (monto+(monto*0.19));
								labelCuota4.Text = "5 CUOTAS DE $" + Math.Round((monto + (monto*0.26))/5) + ". MONTO FINAL $" + (monto+(monto*0.26));
								break;
						}
						break;
				}
		}
	

		private void buttonAtras_Click(object sender, EventArgs e)
		{
			formularioPadre.Show();
			Close();
		}
	}
}
