namespace LoDeLali
{
    partial class Form_VerCondicionalNoCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VerCondicionalNoCliente));
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.dataGridViewCondicional = new System.Windows.Forms.DataGridView();
            this.confirmado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelFecha = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondicional)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.Color.Red;
            this.buttonConfirmar.Location = new System.Drawing.Point(219, 431);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(282, 49);
            this.buttonConfirmar.TabIndex = 6;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click_1);
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.BackColor = System.Drawing.Color.Transparent;
            this.labelCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.Location = new System.Drawing.Point(321, 72);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(94, 31);
            this.labelCelular.TabIndex = 4;
            this.labelCelular.Text = "celular";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(11, 72);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(105, 31);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // dataGridViewCondicional
            // 
            this.dataGridViewCondicional.AllowUserToResizeRows = false;
            this.dataGridViewCondicional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCondicional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCondicional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCondicional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.confirmado});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCondicional.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCondicional.GridColor = System.Drawing.Color.Fuchsia;
            this.dataGridViewCondicional.Location = new System.Drawing.Point(12, 121);
            this.dataGridViewCondicional.MultiSelect = false;
            this.dataGridViewCondicional.Name = "dataGridViewCondicional";
            this.dataGridViewCondicional.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            this.dataGridViewCondicional.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCondicional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCondicional.Size = new System.Drawing.Size(716, 288);
            this.dataGridViewCondicional.TabIndex = 3;
            // 
            // confirmado
            // 
            this.confirmado.HeaderText = "Confirmar";
            this.confirmado.Name = "confirmado";
            this.confirmado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.confirmado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(575, 72);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(81, 31);
            this.labelFecha.TabIndex = 7;
            this.labelFecha.Text = "fecha";
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
            this.buttonAtras.Text = "<<<<<<<";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // VerCondicionalNoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoDeLali.Properties.Resources.fondo_color_rosa_agua_69859_14;
            this.ClientSize = new System.Drawing.Size(747, 502);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dataGridViewCondicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerCondicionalNoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condicional";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerCondicionalNoCliente_FormClosed);
            this.Load += new System.EventHandler(this.VerCondicionalNoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondicional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.DataGridView dataGridViewCondicional;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmado;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button buttonAtras;
    }
}