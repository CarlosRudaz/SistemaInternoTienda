/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 23/07/2022
 * Hora: 17:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LoDeLali
{
	partial class NuevoCondicional
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBoxNuevoCondicional;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelFecha;
		private System.Windows.Forms.TextBox precioUni1;
		private System.Windows.Forms.TextBox producto1;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoCondicional));
            this.groupBoxNuevoCondicional = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxCondicional = new System.Windows.Forms.RichTextBox();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.buttonAgregarFila = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.precioUni1 = new System.Windows.Forms.TextBox();
            this.producto1 = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.groupBoxNuevoCondicional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxNuevoCondicional
            // 
            this.groupBoxNuevoCondicional.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxNuevoCondicional.Controls.Add(this.pictureBox1);
            this.groupBoxNuevoCondicional.Controls.Add(this.label3);
            this.groupBoxNuevoCondicional.Controls.Add(this.label2);
            this.groupBoxNuevoCondicional.Controls.Add(this.label1);
            this.groupBoxNuevoCondicional.Controls.Add(this.textBoxCelular);
            this.groupBoxNuevoCondicional.Controls.Add(this.dateTimePickerFecha);
            this.groupBoxNuevoCondicional.Controls.Add(this.panel1);
            this.groupBoxNuevoCondicional.Controls.Add(this.numericUpDownCantidad);
            this.groupBoxNuevoCondicional.Controls.Add(this.buttonAgregarFila);
            this.groupBoxNuevoCondicional.Controls.Add(this.textBoxNombre);
            this.groupBoxNuevoCondicional.Controls.Add(this.labelNombre);
            this.groupBoxNuevoCondicional.Controls.Add(this.labelFecha);
            this.groupBoxNuevoCondicional.Controls.Add(this.precioUni1);
            this.groupBoxNuevoCondicional.Controls.Add(this.producto1);
            this.groupBoxNuevoCondicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNuevoCondicional.Location = new System.Drawing.Point(12, 68);
            this.groupBoxNuevoCondicional.Name = "groupBoxNuevoCondicional";
            this.groupBoxNuevoCondicional.Size = new System.Drawing.Size(723, 422);
            this.groupBoxNuevoCondicional.TabIndex = 3;
            this.groupBoxNuevoCondicional.TabStop = false;
            this.groupBoxNuevoCondicional.Text = "NUEVO CONDICIONAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 110);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRECIO UNI.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "CANTIDAD";
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCelular.Location = new System.Drawing.Point(112, 97);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(329, 23);
            this.textBoxCelular.TabIndex = 1;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(624, 1);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(93, 23);
            this.dateTimePickerFecha.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxCondicional);
            this.panel1.Location = new System.Drawing.Point(6, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 234);
            this.panel1.TabIndex = 6;
            // 
            // richTextBoxCondicional
            // 
            this.richTextBoxCondicional.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxCondicional.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCondicional.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxCondicional.Name = "richTextBoxCondicional";
            this.richTextBoxCondicional.Size = new System.Drawing.Size(705, 213);
            this.richTextBoxCondicional.TabIndex = 0;
            this.richTextBoxCondicional.TabStop = false;
            this.richTextBoxCondicional.Text = "";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCantidad.Location = new System.Drawing.Point(27, 166);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(37, 23);
            this.numericUpDownCantidad.TabIndex = 2;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAgregarFila
            // 
            this.buttonAgregarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarFila.Location = new System.Drawing.Point(581, 161);
            this.buttonAgregarFila.Name = "buttonAgregarFila";
            this.buttonAgregarFila.Size = new System.Drawing.Size(133, 33);
            this.buttonAgregarFila.TabIndex = 5;
            this.buttonAgregarFila.Text = "+ Agregar";
            this.buttonAgregarFila.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregarFila.UseVisualStyleBackColor = true;
            this.buttonAgregarFila.Click += new System.EventHandler(this.buttonAgregarFila_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(112, 56);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(329, 23);
            this.textBoxNombre.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(33, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 23);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "NOMBRE:";
            // 
            // labelFecha
            // 
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(33, 97);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(83, 23);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "CELULAR:";
            // 
            // precioUni1
            // 
            this.precioUni1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioUni1.Location = new System.Drawing.Point(462, 166);
            this.precioUni1.Name = "precioUni1";
            this.precioUni1.Size = new System.Drawing.Size(113, 23);
            this.precioUni1.TabIndex = 4;
            // 
            // producto1
            // 
            this.producto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto1.Location = new System.Drawing.Point(82, 166);
            this.producto1.Name = "producto1";
            this.producto1.Size = new System.Drawing.Size(374, 23);
            this.producto1.TabIndex = 3;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmar.Image")));
            this.buttonConfirmar.Location = new System.Drawing.Point(23, 18);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 44);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.TabStop = false;
            this.buttonConfirmar.Text = "<<<<<<<";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // NuevoCondicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 502);
            this.Controls.Add(this.groupBoxNuevoCondicional);
            this.Controls.Add(this.buttonConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoCondicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condicional";
            this.Load += new System.EventHandler(this.NuevoCondicional_Load);
            this.groupBoxNuevoCondicional.ResumeLayout(false);
            this.groupBoxNuevoCondicional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.Button buttonAgregarFila;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.RichTextBox richTextBoxCondicional;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
