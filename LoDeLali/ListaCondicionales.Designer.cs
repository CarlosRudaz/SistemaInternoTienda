namespace LoDeLali
{
    partial class ListaCondicionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCondicionales));
            this.dataGridViewAgendados = new System.Windows.Forms.DataGridView();
            this.dataGridViewSinAgendar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinAgendar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAgendados
            // 
            this.dataGridViewAgendados.AllowUserToAddRows = false;
            this.dataGridViewAgendados.AllowUserToDeleteRows = false;
            this.dataGridViewAgendados.AllowUserToResizeColumns = false;
            this.dataGridViewAgendados.AllowUserToResizeRows = false;
            this.dataGridViewAgendados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgendados.ColumnHeadersVisible = false;
            this.dataGridViewAgendados.Location = new System.Drawing.Point(26, 52);
            this.dataGridViewAgendados.MultiSelect = false;
            this.dataGridViewAgendados.Name = "dataGridViewAgendados";
            this.dataGridViewAgendados.ReadOnly = true;
            this.dataGridViewAgendados.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewAgendados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAgendados.RowTemplate.Height = 30;
            this.dataGridViewAgendados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAgendados.Size = new System.Drawing.Size(320, 257);
            this.dataGridViewAgendados.TabIndex = 1;
            this.dataGridViewAgendados.TabStop = false;
            this.dataGridViewAgendados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAgendados_CellMouseDoubleClick);
            // 
            // dataGridViewSinAgendar
            // 
            this.dataGridViewSinAgendar.AllowUserToAddRows = false;
            this.dataGridViewSinAgendar.AllowUserToDeleteRows = false;
            this.dataGridViewSinAgendar.AllowUserToResizeColumns = false;
            this.dataGridViewSinAgendar.AllowUserToResizeRows = false;
            this.dataGridViewSinAgendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSinAgendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinAgendar.ColumnHeadersVisible = false;
            this.dataGridViewSinAgendar.Location = new System.Drawing.Point(376, 52);
            this.dataGridViewSinAgendar.MultiSelect = false;
            this.dataGridViewSinAgendar.Name = "dataGridViewSinAgendar";
            this.dataGridViewSinAgendar.ReadOnly = true;
            this.dataGridViewSinAgendar.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSinAgendar.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSinAgendar.RowTemplate.Height = 30;
            this.dataGridViewSinAgendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSinAgendar.Size = new System.Drawing.Size(320, 257);
            this.dataGridViewSinAgendar.TabIndex = 1;
            this.dataGridViewSinAgendar.TabStop = false;
            this.dataGridViewSinAgendar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSinAgendar_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CLIENTES SIN AGENDAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTES AGENDADOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewAgendados);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewSinAgendar);
            this.panel1.Location = new System.Drawing.Point(12, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 320);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(586, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "CONDICIONALES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(692, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "(*)PARA MIRAR EL CONDICIONAL HACER DOBLE CLICK SOBRE EL NOMBRE DEL CLIENTE.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonAtras.TabIndex = 3;
            this.buttonAtras.Text = "<<<<<<<";
            this.buttonAtras.UseVisualStyleBackColor = false;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // ListaCondicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 502);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCondicionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Condicionales";
            this.Load += new System.EventHandler(this.ListaCondicionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgendados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinAgendar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgendados;
        private System.Windows.Forms.DataGridView dataGridViewSinAgendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAtras;
    }
}