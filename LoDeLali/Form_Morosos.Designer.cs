/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 14/07/2022
 * Hora: 20:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LoDeLali
{
	partial class Form_Morosos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridViewMorosos;
		private System.Windows.Forms.Button buttonVolver;
		private System.Windows.Forms.Button buttonWhatsapp;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Morosos));
            this.dataGridViewMorosos = new System.Windows.Forms.DataGridView();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonWhatsapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorosos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMorosos
            // 
            this.dataGridViewMorosos.AllowUserToAddRows = false;
            this.dataGridViewMorosos.AllowUserToDeleteRows = false;
            this.dataGridViewMorosos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMorosos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMorosos.ColumnHeadersVisible = false;
            this.dataGridViewMorosos.Location = new System.Drawing.Point(19, 18);
            this.dataGridViewMorosos.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dataGridViewMorosos.MultiSelect = false;
            this.dataGridViewMorosos.Name = "dataGridViewMorosos";
            this.dataGridViewMorosos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMorosos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMorosos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMorosos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMorosos.Size = new System.Drawing.Size(582, 446);
            this.dataGridViewMorosos.TabIndex = 0;
            this.dataGridViewMorosos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewMorososCellMouseDoubleClick);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVolver.BackgroundImage")));
            this.buttonVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVolver.Location = new System.Drawing.Point(636, 119);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(95, 48);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.UseVisualStyleBackColor = false;
            this.buttonVolver.Click += new System.EventHandler(this.Button2Click);
            // 
            // buttonWhatsapp
            // 
            this.buttonWhatsapp.BackColor = System.Drawing.Color.Transparent;
            this.buttonWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWhatsapp.FlatAppearance.BorderSize = 0;
            this.buttonWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhatsapp.Image = ((System.Drawing.Image)(resources.GetObject("buttonWhatsapp.Image")));
            this.buttonWhatsapp.Location = new System.Drawing.Point(636, 18);
            this.buttonWhatsapp.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonWhatsapp.Name = "buttonWhatsapp";
            this.buttonWhatsapp.Size = new System.Drawing.Size(95, 96);
            this.buttonWhatsapp.TabIndex = 1;
            this.buttonWhatsapp.UseVisualStyleBackColor = false;
            this.buttonWhatsapp.Click += new System.EventHandler(this.ButtonWhatsappClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 140);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Si el contacto \r\ndel IdCliente no \r\nposee número \r\nde celular, no \r\nserá posible \r" +
    "\nconectarse con \r\nwhatsapp web.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Morosos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(756, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWhatsapp);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewMorosos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "Morosos";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morosos";
            this.Load += new System.EventHandler(this.MorososLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMorosos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label1;
    }
}
