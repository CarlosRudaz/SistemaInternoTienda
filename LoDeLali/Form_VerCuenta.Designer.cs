/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 06/07/2022
 * Hora: 10:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LoDeLali
{
	partial class Form_VerCuenta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelNombreCliente;
		private System.Windows.Forms.Label labelCelular;
		private System.Windows.Forms.DataGridView dataGridViewCuentas;
		private System.Windows.Forms.Button buttonAgregarRegistro;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonFinalizar;
		private System.Windows.Forms.Button buttonNuevoRegistro;
		private System.Windows.Forms.TextBox textBoxPrecio;
		private System.Windows.Forms.TextBox textBoxProducto;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label labelPrecio;
		private System.Windows.Forms.Label labelProducto;
		private System.Windows.Forms.Label labelFecha;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox checkBoxEntrega;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelAvisoCuentaPagada;
		private System.Windows.Forms.Button buttonDescargar;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerCuenta));
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.dataGridViewCuentas = new System.Windows.Forms.DataGridView();
            this.buttonAgregarRegistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxEntrega = new System.Windows.Forms.CheckBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonNuevoRegistro = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelProducto = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxProducto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAvisoCondicional = new System.Windows.Forms.Label();
            this.labelAvisoCuentaPagada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDescargar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNombreCliente.Location = new System.Drawing.Point(14, 15);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(208, 57);
            this.labelNombreCliente.TabIndex = 0;
            this.labelNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCelular
            // 
            this.labelCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCelular.Location = new System.Drawing.Point(247, 15);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(208, 57);
            this.labelCelular.TabIndex = 0;
            this.labelCelular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCuentas
            // 
            this.dataGridViewCuentas.AllowUserToAddRows = false;
            this.dataGridViewCuentas.AllowUserToDeleteRows = false;
            this.dataGridViewCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewCuentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentas.Location = new System.Drawing.Point(3, 97);
            this.dataGridViewCuentas.MultiSelect = false;
            this.dataGridViewCuentas.Name = "dataGridViewCuentas";
            this.dataGridViewCuentas.ReadOnly = true;
            this.dataGridViewCuentas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewCuentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCuentas.RowTemplate.ReadOnly = true;
            this.dataGridViewCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuentas.ShowEditingIcon = false;
            this.dataGridViewCuentas.Size = new System.Drawing.Size(672, 295);
            this.dataGridViewCuentas.TabIndex = 0;
            // 
            // buttonAgregarRegistro
            // 
            this.buttonAgregarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAgregarRegistro.FlatAppearance.BorderSize = 0;
            this.buttonAgregarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregarRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregarRegistro.Location = new System.Drawing.Point(497, 15);
            this.buttonAgregarRegistro.Name = "buttonAgregarRegistro";
            this.buttonAgregarRegistro.Size = new System.Drawing.Size(73, 57);
            this.buttonAgregarRegistro.TabIndex = 1;
            this.buttonAgregarRegistro.Text = "✔";
            this.buttonAgregarRegistro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonAgregarRegistro.UseVisualStyleBackColor = false;
            this.buttonAgregarRegistro.Click += new System.EventHandler(this.ButtonAgregarRegistroClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBoxEntrega);
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Controls.Add(this.buttonFinalizar);
            this.panel1.Controls.Add(this.labelPrecio);
            this.panel1.Controls.Add(this.buttonNuevoRegistro);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelProducto);
            this.panel1.Controls.Add(this.textBoxPrecio);
            this.panel1.Controls.Add(this.textBoxProducto);
            this.panel1.Location = new System.Drawing.Point(20, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 404);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // checkBoxEntrega
            // 
            this.checkBoxEntrega.Location = new System.Drawing.Point(350, 117);
            this.checkBoxEntrega.Name = "checkBoxEntrega";
            this.checkBoxEntrega.Size = new System.Drawing.Size(104, 24);
            this.checkBoxEntrega.TabIndex = 6;
            this.checkBoxEntrega.Text = "ENTREGA";
            this.checkBoxEntrega.UseVisualStyleBackColor = true;
            this.checkBoxEntrega.CheckedChanged += new System.EventHandler(this.CheckBoxEntregaCheckedChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(146, 18);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(121, 40);
            this.labelFecha.TabIndex = 0;
            this.labelFecha.Text = "FECHA";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.Location = new System.Drawing.Point(336, 289);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(170, 55);
            this.buttonFinalizar.TabIndex = 5;
            this.buttonFinalizar.Text = "FINALIZAR";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.ButtonCancelarClick);
            // 
            // labelPrecio
            // 
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(146, 199);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(254, 40);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "PRECIO/MONTO";
            // 
            // buttonNuevoRegistro
            // 
            this.buttonNuevoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoRegistro.Location = new System.Drawing.Point(146, 289);
            this.buttonNuevoRegistro.Name = "buttonNuevoRegistro";
            this.buttonNuevoRegistro.Size = new System.Drawing.Size(170, 55);
            this.buttonNuevoRegistro.TabIndex = 4;
            this.buttonNuevoRegistro.Text = "REGISTRAR";
            this.buttonNuevoRegistro.UseVisualStyleBackColor = true;
            this.buttonNuevoRegistro.Click += new System.EventHandler(this.ButtonNuevoRegistroClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 61);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 7, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(360, 30);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 6, 0, 0, 0, 0);
            // 
            // labelProducto
            // 
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.Location = new System.Drawing.Point(146, 108);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(218, 40);
            this.labelProducto.TabIndex = 0;
            this.labelProducto.Text = "PRODUCTO";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrecio.Location = new System.Drawing.Point(146, 242);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(360, 30);
            this.textBoxPrecio.TabIndex = 3;
            // 
            // textBoxProducto
            // 
            this.textBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProducto.Location = new System.Drawing.Point(146, 151);
            this.textBoxProducto.Name = "textBoxProducto";
            this.textBoxProducto.Size = new System.Drawing.Size(360, 30);
            this.textBoxProducto.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.labelAvisoCondicional);
            this.panel2.Controls.Add(this.labelAvisoCuentaPagada);
            this.panel2.Controls.Add(this.dataGridViewCuentas);
            this.panel2.Controls.Add(this.labelCelular);
            this.panel2.Controls.Add(this.labelNombreCliente);
            this.panel2.Controls.Add(this.buttonAgregarRegistro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(28, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 395);
            this.panel2.TabIndex = 4;
            // 
            // labelAvisoCondicional
            // 
            this.labelAvisoCondicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelAvisoCondicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoCondicional.Location = new System.Drawing.Point(4, 354);
            this.labelAvisoCondicional.Name = "labelAvisoCondicional";
            this.labelAvisoCondicional.Size = new System.Drawing.Size(672, 25);
            this.labelAvisoCondicional.TabIndex = 8;
            this.labelAvisoCondicional.Text = "CLIENTE CON CONDICIONAL PENDIENTE";
            this.labelAvisoCondicional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAvisoCondicional.Visible = false;
            // 
            // labelAvisoCuentaPagada
            // 
            this.labelAvisoCuentaPagada.BackColor = System.Drawing.Color.Red;
            this.labelAvisoCuentaPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisoCuentaPagada.ForeColor = System.Drawing.Color.White;
            this.labelAvisoCuentaPagada.Location = new System.Drawing.Point(79, 164);
            this.labelAvisoCuentaPagada.Name = "labelAvisoCuentaPagada";
            this.labelAvisoCuentaPagada.Size = new System.Drawing.Size(519, 156);
            this.labelAvisoCuentaPagada.TabIndex = 6;
            this.labelAvisoCuentaPagada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAvisoCuentaPagada.Visible = false;
            this.labelAvisoCuentaPagada.Click += new System.EventHandler(this.LabelAvisoCuentaPagadaClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Registro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(180, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "(*)SI EL MONTO DEL SALDO ES 0 (CERO), LOS REGISTROS HISTORICOS SE BORRAN.";
            // 
            // buttonDescargar
            // 
            this.buttonDescargar.BackColor = System.Drawing.Color.Transparent;
            this.buttonDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDescargar.FlatAppearance.BorderSize = 0;
            this.buttonDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescargar.Image = ((System.Drawing.Image)(resources.GetObject("buttonDescargar.Image")));
            this.buttonDescargar.Location = new System.Drawing.Point(107, 18);
            this.buttonDescargar.Name = "buttonDescargar";
            this.buttonDescargar.Size = new System.Drawing.Size(49, 44);
            this.buttonDescargar.TabIndex = 7;
            this.buttonDescargar.UseVisualStyleBackColor = false;
            this.buttonDescargar.Click += new System.EventHandler(this.ButtonDescargarClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(180, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(514, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "(*)PARA QUE EL REGISTRO TENGA SENTIDO, DEBE ESTAR ORDENADO POR FECHA.";
            // 
            // buttonAtras
            // 
            this.buttonAtras.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtras.FlatAppearance.BorderSize = 0;
            this.buttonAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtras.Image")));
            this.buttonAtras.Location = new System.Drawing.Point(23, 18);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 44);
            this.buttonAtras.TabIndex = 8;
            this.buttonAtras.TabStop = false;
            this.buttonAtras.Text = "<<<<<<<";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // VerCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 502);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonDescargar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Corriente";
            this.Shown += new System.EventHandler(this.VerCuentaShown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAvisoCondicional;
        private System.Windows.Forms.Button buttonAtras;
    }
}
