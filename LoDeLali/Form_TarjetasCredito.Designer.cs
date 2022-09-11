/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 11/07/2022
 * Hora: 10:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LoDeLali
{
	partial class Form_TarjetasCredito
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelCuota4;
		private System.Windows.Forms.Label labelCuota3;
		private System.Windows.Forms.Label labelCuota2;
		private System.Windows.Forms.Label labelCuota1;
		private System.Windows.Forms.Label labelCuotaSeleccionada;
		private System.Windows.Forms.TextBox textBoxMonto;
		private System.Windows.Forms.ComboBox comboBoxCuotas;
		private System.Windows.Forms.ComboBox comboBoxTarjetas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TarjetasCredito));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCuota4 = new System.Windows.Forms.Label();
            this.labelCuota3 = new System.Windows.Forms.Label();
            this.labelCuota2 = new System.Windows.Forms.Label();
            this.labelCuota1 = new System.Windows.Forms.Label();
            this.labelCuotaSeleccionada = new System.Windows.Forms.Label();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.comboBoxCuotas = new System.Windows.Forms.ComboBox();
            this.comboBoxTarjetas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelCuota4);
            this.panel1.Controls.Add(this.labelCuota3);
            this.panel1.Controls.Add(this.labelCuota2);
            this.panel1.Controls.Add(this.labelCuota1);
            this.panel1.Controls.Add(this.labelCuotaSeleccionada);
            this.panel1.Controls.Add(this.textBoxMonto);
            this.panel1.Controls.Add(this.comboBoxCuotas);
            this.panel1.Controls.Add(this.comboBoxTarjetas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 234);
            this.panel1.TabIndex = 0;
            // 
            // labelCuota4
            // 
            this.labelCuota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota4.Location = new System.Drawing.Point(62, 194);
            this.labelCuota4.Name = "labelCuota4";
            this.labelCuota4.Size = new System.Drawing.Size(369, 19);
            this.labelCuota4.TabIndex = 3;
            this.labelCuota4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCuota3
            // 
            this.labelCuota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota3.Location = new System.Drawing.Point(62, 175);
            this.labelCuota3.Name = "labelCuota3";
            this.labelCuota3.Size = new System.Drawing.Size(369, 19);
            this.labelCuota3.TabIndex = 3;
            this.labelCuota3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCuota2
            // 
            this.labelCuota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota2.Location = new System.Drawing.Point(62, 156);
            this.labelCuota2.Name = "labelCuota2";
            this.labelCuota2.Size = new System.Drawing.Size(369, 19);
            this.labelCuota2.TabIndex = 3;
            this.labelCuota2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCuota1
            // 
            this.labelCuota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota1.Location = new System.Drawing.Point(62, 137);
            this.labelCuota1.Name = "labelCuota1";
            this.labelCuota1.Size = new System.Drawing.Size(369, 19);
            this.labelCuota1.TabIndex = 3;
            this.labelCuota1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCuotaSeleccionada
            // 
            this.labelCuotaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuotaSeleccionada.Location = new System.Drawing.Point(24, 103);
            this.labelCuotaSeleccionada.Name = "labelCuotaSeleccionada";
            this.labelCuotaSeleccionada.Size = new System.Drawing.Size(449, 34);
            this.labelCuotaSeleccionada.TabIndex = 3;
            this.labelCuotaSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Enabled = false;
            this.textBoxMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMonto.Location = new System.Drawing.Point(352, 49);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(121, 30);
            this.textBoxMonto.TabIndex = 2;
            this.textBoxMonto.Text = "0";
            this.textBoxMonto.TextChanged += new System.EventHandler(this.TextBoxMontoTextChanged);
            // 
            // comboBoxCuotas
            // 
            this.comboBoxCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCuotas.FormattingEnabled = true;
            this.comboBoxCuotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCuotas.Location = new System.Drawing.Point(192, 49);
            this.comboBoxCuotas.Name = "comboBoxCuotas";
            this.comboBoxCuotas.Size = new System.Drawing.Size(121, 33);
            this.comboBoxCuotas.TabIndex = 1;
            this.comboBoxCuotas.SelectionChangeCommitted += new System.EventHandler(this.TextBoxMontoTextChanged);
            // 
            // comboBoxTarjetas
            // 
            this.comboBoxTarjetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTarjetas.FormattingEnabled = true;
            this.comboBoxTarjetas.Items.AddRange(new object[] {
            "NARANJA",
            "TUYA",
            "VISA",
            "MASTERCARD"});
            this.comboBoxTarjetas.Location = new System.Drawing.Point(24, 49);
            this.comboBoxTarjetas.Name = "comboBoxTarjetas";
            this.comboBoxTarjetas.Size = new System.Drawing.Size(121, 33);
            this.comboBoxTarjetas.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "MONTO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "CUOTAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TARJETA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtras.BackgroundImage")));
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtras.FlatAppearance.BorderSize = 0;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Location = new System.Drawing.Point(31, 12);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 51);
            this.buttonAtras.TabIndex = 1;
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // TarjetasCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 315);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TarjetasCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TarjetasCredito";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button buttonAtras;
    }
}
