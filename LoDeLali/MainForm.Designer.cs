/*
 * Creado por SharpDevelop.
 * Usuario: carlo
 * Fecha: 03/07/2022
 * Hora: 12:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace LoDeLali
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonPresupuestos;
		private System.Windows.Forms.Button buttonTarjetas;
		private System.Windows.Forms.Button buttonEfectivo;
		private System.Windows.Forms.Button buttonCuentaCorriente;
		private System.Windows.Forms.GroupBox groupBoxCuentasCorrientes;
		private System.Windows.Forms.Panel panelBuscarCuentasCorrientes;
		private System.Windows.Forms.TextBox textBoxBuscar;
		private System.Windows.Forms.Button buttonBuscarCuentasCorrientes;
		private System.Windows.Forms.DataGridView dataGridViewBuscarCuentasCorrientes;
		private System.Windows.Forms.Button buttonAtrasVolver;
		private System.Windows.Forms.Button buttonAgregarCliente;
		private System.Windows.Forms.Button buttonEliminarCliente;
		private System.Windows.Forms.Panel panelInicial;
		private System.Windows.Forms.CheckBox checkBoxUsuariosBorrados;
		private System.Windows.Forms.Button buttonRecuperarCliente;
		private System.Windows.Forms.Button buttonMorosos;
		private System.Windows.Forms.Panel panelBotonesInicio;
		private System.Windows.Forms.LinkLabel linkLabelPrecios;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPresupuestos = new System.Windows.Forms.Button();
            this.buttonTarjetas = new System.Windows.Forms.Button();
            this.buttonEfectivo = new System.Windows.Forms.Button();
            this.buttonCuentaCorriente = new System.Windows.Forms.Button();
            this.groupBoxCuentasCorrientes = new System.Windows.Forms.GroupBox();
            this.dataGridViewBuscarCuentasCorrientes = new System.Windows.Forms.DataGridView();
            this.panelBuscarCuentasCorrientes = new System.Windows.Forms.Panel();
            this.checkBoxUsuariosBorrados = new System.Windows.Forms.CheckBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscarCuentasCorrientes = new System.Windows.Forms.Button();
            this.buttonAtrasVolver = new System.Windows.Forms.Button();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.panelInicial = new System.Windows.Forms.Panel();
            this.buttonRecuperarCliente = new System.Windows.Forms.Button();
            this.buttonMorosos = new System.Windows.Forms.Button();
            this.panelBotonesInicio = new System.Windows.Forms.Panel();
            this.linkLabelPrecios = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCuentasCorrientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarCuentasCorrientes)).BeginInit();
            this.panelBuscarCuentasCorrientes.SuspendLayout();
            this.panelInicial.SuspendLayout();
            this.panelBotonesInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPresupuestos
            // 
            this.buttonPresupuestos.BackColor = System.Drawing.Color.Transparent;
            this.buttonPresupuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPresupuestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPresupuestos.FlatAppearance.BorderSize = 0;
            this.buttonPresupuestos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPresupuestos.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPresupuestos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPresupuestos.Location = new System.Drawing.Point(34, 296);
            this.buttonPresupuestos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPresupuestos.Name = "buttonPresupuestos";
            this.buttonPresupuestos.Size = new System.Drawing.Size(152, 50);
            this.buttonPresupuestos.TabIndex = 3;
            this.buttonPresupuestos.Text = "Condicional";
            this.buttonPresupuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPresupuestos.UseVisualStyleBackColor = false;
            this.buttonPresupuestos.Click += new System.EventHandler(this.buttonPresupuestos_Click);
            this.buttonPresupuestos.MouseLeave += new System.EventHandler(this.buttonPresupuestos_MouseLeave);
            this.buttonPresupuestos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonPresupuestos_MouseMove);
            // 
            // buttonTarjetas
            // 
            this.buttonTarjetas.BackColor = System.Drawing.Color.Transparent;
            this.buttonTarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTarjetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTarjetas.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonTarjetas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTarjetas.Location = new System.Drawing.Point(34, 130);
            this.buttonTarjetas.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTarjetas.Name = "buttonTarjetas";
            this.buttonTarjetas.Size = new System.Drawing.Size(152, 50);
            this.buttonTarjetas.TabIndex = 1;
            this.buttonTarjetas.Text = "Tarjeta de Crédito";
            this.buttonTarjetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTarjetas.UseVisualStyleBackColor = false;
            this.buttonTarjetas.Click += new System.EventHandler(this.ButtonTarjetasClick);
            this.buttonTarjetas.MouseLeave += new System.EventHandler(this.buttonTarjetas_MouseLeave);
            this.buttonTarjetas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonTarjetas_MouseMove);
            // 
            // buttonEfectivo
            // 
            this.buttonEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.buttonEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEfectivo.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEfectivo.Location = new System.Drawing.Point(34, 213);
            this.buttonEfectivo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEfectivo.Name = "buttonEfectivo";
            this.buttonEfectivo.Size = new System.Drawing.Size(152, 50);
            this.buttonEfectivo.TabIndex = 2;
            this.buttonEfectivo.Text = "Contado - Efectivo";
            this.buttonEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEfectivo.UseVisualStyleBackColor = false;
            this.buttonEfectivo.Click += new System.EventHandler(this.ButtonEfectivoClick);
            this.buttonEfectivo.MouseLeave += new System.EventHandler(this.buttonEfectivo_MouseLeave);
            this.buttonEfectivo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonEfectivo_MouseMove);
            // 
            // buttonCuentaCorriente
            // 
            this.buttonCuentaCorriente.BackColor = System.Drawing.Color.Transparent;
            this.buttonCuentaCorriente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCuentaCorriente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCuentaCorriente.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCuentaCorriente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCuentaCorriente.Location = new System.Drawing.Point(34, 377);
            this.buttonCuentaCorriente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCuentaCorriente.Name = "buttonCuentaCorriente";
            this.buttonCuentaCorriente.Size = new System.Drawing.Size(152, 50);
            this.buttonCuentaCorriente.TabIndex = 4;
            this.buttonCuentaCorriente.Text = "Cuentas Corrientes";
            this.buttonCuentaCorriente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCuentaCorriente.UseVisualStyleBackColor = false;
            this.buttonCuentaCorriente.Click += new System.EventHandler(this.ButtonCuentaCorrienteClick);
            this.buttonCuentaCorriente.MouseLeave += new System.EventHandler(this.buttonCuentaCorriente_MouseLeave);
            this.buttonCuentaCorriente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonCuentaCorriente_MouseMove);
            // 
            // groupBoxCuentasCorrientes
            // 
            this.groupBoxCuentasCorrientes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCuentasCorrientes.Controls.Add(this.dataGridViewBuscarCuentasCorrientes);
            this.groupBoxCuentasCorrientes.Controls.Add(this.panelBuscarCuentasCorrientes);
            this.groupBoxCuentasCorrientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBoxCuentasCorrientes.Location = new System.Drawing.Point(35, 103);
            this.groupBoxCuentasCorrientes.Name = "groupBoxCuentasCorrientes";
            this.groupBoxCuentasCorrientes.Size = new System.Drawing.Size(667, 344);
            this.groupBoxCuentasCorrientes.TabIndex = 1;
            this.groupBoxCuentasCorrientes.TabStop = false;
            this.groupBoxCuentasCorrientes.Text = "CUENTAS CORRIENTES";
            // 
            // dataGridViewBuscarCuentasCorrientes
            // 
            this.dataGridViewBuscarCuentasCorrientes.AllowUserToAddRows = false;
            this.dataGridViewBuscarCuentasCorrientes.AllowUserToDeleteRows = false;
            this.dataGridViewBuscarCuentasCorrientes.AllowUserToResizeRows = false;
            this.dataGridViewBuscarCuentasCorrientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBuscarCuentasCorrientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscarCuentasCorrientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBuscarCuentasCorrientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBuscarCuentasCorrientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarCuentasCorrientes.ColumnHeadersVisible = false;
            this.dataGridViewBuscarCuentasCorrientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewBuscarCuentasCorrientes.Location = new System.Drawing.Point(6, 124);
            this.dataGridViewBuscarCuentasCorrientes.MultiSelect = false;
            this.dataGridViewBuscarCuentasCorrientes.Name = "dataGridViewBuscarCuentasCorrientes";
            this.dataGridViewBuscarCuentasCorrientes.ReadOnly = true;
            this.dataGridViewBuscarCuentasCorrientes.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBuscarCuentasCorrientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBuscarCuentasCorrientes.RowTemplate.Height = 35;
            this.dataGridViewBuscarCuentasCorrientes.RowTemplate.ReadOnly = true;
            this.dataGridViewBuscarCuentasCorrientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarCuentasCorrientes.Size = new System.Drawing.Size(655, 214);
            this.dataGridViewBuscarCuentasCorrientes.TabIndex = 1;
            this.dataGridViewBuscarCuentasCorrientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewBuscarCuentasCorrientesCellMouseClick);
            this.dataGridViewBuscarCuentasCorrientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewBuscarCuentasCorrientesCellMouseDoubleClick);
            // 
            // panelBuscarCuentasCorrientes
            // 
            this.panelBuscarCuentasCorrientes.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscarCuentasCorrientes.Controls.Add(this.checkBoxUsuariosBorrados);
            this.panelBuscarCuentasCorrientes.Controls.Add(this.textBoxBuscar);
            this.panelBuscarCuentasCorrientes.Controls.Add(this.buttonBuscarCuentasCorrientes);
            this.panelBuscarCuentasCorrientes.Location = new System.Drawing.Point(131, 48);
            this.panelBuscarCuentasCorrientes.Name = "panelBuscarCuentasCorrientes";
            this.panelBuscarCuentasCorrientes.Size = new System.Drawing.Size(419, 67);
            this.panelBuscarCuentasCorrientes.TabIndex = 0;
            // 
            // checkBoxUsuariosBorrados
            // 
            this.checkBoxUsuariosBorrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBoxUsuariosBorrados.ForeColor = System.Drawing.Color.Black;
            this.checkBoxUsuariosBorrados.Location = new System.Drawing.Point(3, 38);
            this.checkBoxUsuariosBorrados.Name = "checkBoxUsuariosBorrados";
            this.checkBoxUsuariosBorrados.Size = new System.Drawing.Size(129, 24);
            this.checkBoxUsuariosBorrados.TabIndex = 2;
            this.checkBoxUsuariosBorrados.Text = "INCLUIR BORRADOS";
            this.checkBoxUsuariosBorrados.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(3, 5);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(308, 30);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.ButtonBuscarCuentasCorrientesClick);
            // 
            // buttonBuscarCuentasCorrientes
            // 
            this.buttonBuscarCuentasCorrientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonBuscarCuentasCorrientes.Location = new System.Drawing.Point(317, 3);
            this.buttonBuscarCuentasCorrientes.Name = "buttonBuscarCuentasCorrientes";
            this.buttonBuscarCuentasCorrientes.Size = new System.Drawing.Size(94, 35);
            this.buttonBuscarCuentasCorrientes.TabIndex = 0;
            this.buttonBuscarCuentasCorrientes.Text = "&Buscar";
            this.buttonBuscarCuentasCorrientes.UseVisualStyleBackColor = true;
            this.buttonBuscarCuentasCorrientes.Click += new System.EventHandler(this.ButtonBuscarCuentasCorrientesClick);
            // 
            // buttonAtrasVolver
            // 
            this.buttonAtrasVolver.BackColor = System.Drawing.Color.Transparent;
            this.buttonAtrasVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAtrasVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtrasVolver.FlatAppearance.BorderSize = 0;
            this.buttonAtrasVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtrasVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrasVolver.Image = ((System.Drawing.Image)(resources.GetObject("buttonAtrasVolver.Image")));
            this.buttonAtrasVolver.Location = new System.Drawing.Point(23, 18);
            this.buttonAtrasVolver.Name = "buttonAtrasVolver";
            this.buttonAtrasVolver.Size = new System.Drawing.Size(75, 44);
            this.buttonAtrasVolver.TabIndex = 2;
            this.buttonAtrasVolver.Text = "<<<<<<<";
            this.buttonAtrasVolver.UseVisualStyleBackColor = false;
            this.buttonAtrasVolver.Click += new System.EventHandler(this.ButtonAtrasVolverClick);
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarCliente.FlatAppearance.BorderSize = 0;
            this.buttonAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCliente.Image")));
            this.buttonAgregarCliente.Location = new System.Drawing.Point(570, 16);
            this.buttonAgregarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(49, 50);
            this.buttonAgregarCliente.TabIndex = 3;
            this.buttonAgregarCliente.UseVisualStyleBackColor = false;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.ButtonAgregarClienteClick);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminarCliente.FlatAppearance.BorderSize = 0;
            this.buttonEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarCliente.Image")));
            this.buttonEliminarCliente.Location = new System.Drawing.Point(624, 16);
            this.buttonEliminarCliente.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.buttonEliminarCliente.Size = new System.Drawing.Size(49, 50);
            this.buttonEliminarCliente.TabIndex = 3;
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            this.buttonEliminarCliente.Visible = false;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.ButtonEliminarClienteClick);
            // 
            // panelInicial
            // 
            this.panelInicial.BackColor = System.Drawing.Color.Transparent;
            this.panelInicial.BackgroundImage = global::LoDeLali.Properties.Resources.fondo_color_rosa_agua_69859_14;
            this.panelInicial.Controls.Add(this.buttonAtrasVolver);
            this.panelInicial.Controls.Add(this.groupBoxCuentasCorrientes);
            this.panelInicial.Controls.Add(this.buttonRecuperarCliente);
            this.panelInicial.Controls.Add(this.buttonEliminarCliente);
            this.panelInicial.Controls.Add(this.buttonAgregarCliente);
            this.panelInicial.Location = new System.Drawing.Point(0, 0);
            this.panelInicial.Name = "panelInicial";
            this.panelInicial.Size = new System.Drawing.Size(747, 502);
            this.panelInicial.TabIndex = 4;
            this.panelInicial.Visible = false;
            // 
            // buttonRecuperarCliente
            // 
            this.buttonRecuperarCliente.BackColor = System.Drawing.Color.Transparent;
            this.buttonRecuperarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecuperarCliente.FlatAppearance.BorderSize = 0;
            this.buttonRecuperarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecuperarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecuperarCliente.Image")));
            this.buttonRecuperarCliente.Location = new System.Drawing.Point(518, 16);
            this.buttonRecuperarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRecuperarCliente.Name = "buttonRecuperarCliente";
            this.buttonRecuperarCliente.Size = new System.Drawing.Size(49, 50);
            this.buttonRecuperarCliente.TabIndex = 3;
            this.buttonRecuperarCliente.UseVisualStyleBackColor = false;
            this.buttonRecuperarCliente.Visible = false;
            this.buttonRecuperarCliente.Click += new System.EventHandler(this.ButtonRecuperarClienteClick);
            // 
            // buttonMorosos
            // 
            this.buttonMorosos.BackColor = System.Drawing.Color.Transparent;
            this.buttonMorosos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMorosos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMorosos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMorosos.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonMorosos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMorosos.Location = new System.Drawing.Point(34, 52);
            this.buttonMorosos.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMorosos.Name = "buttonMorosos";
            this.buttonMorosos.Size = new System.Drawing.Size(152, 50);
            this.buttonMorosos.TabIndex = 0;
            this.buttonMorosos.Text = "Clientes Atrasados";
            this.buttonMorosos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMorosos.UseVisualStyleBackColor = false;
            this.buttonMorosos.Click += new System.EventHandler(this.ButtonMorososClick);
            this.buttonMorosos.MouseLeave += new System.EventHandler(this.buttonMorosos_MouseLeave);
            this.buttonMorosos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMorosos_MouseMove);
            // 
            // panelBotonesInicio
            // 
            this.panelBotonesInicio.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesInicio.Controls.Add(this.linkLabelPrecios);
            this.panelBotonesInicio.Controls.Add(this.button1);
            this.panelBotonesInicio.Controls.Add(this.buttonMorosos);
            this.panelBotonesInicio.Controls.Add(this.buttonEfectivo);
            this.panelBotonesInicio.Controls.Add(this.buttonCuentaCorriente);
            this.panelBotonesInicio.Controls.Add(this.buttonPresupuestos);
            this.panelBotonesInicio.Controls.Add(this.buttonTarjetas);
            this.panelBotonesInicio.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesInicio.Name = "panelBotonesInicio";
            this.panelBotonesInicio.Size = new System.Drawing.Size(747, 502);
            this.panelBotonesInicio.TabIndex = 5;
            // 
            // linkLabelPrecios
            // 
            this.linkLabelPrecios.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPrecios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelPrecios.LinkColor = System.Drawing.Color.Black;
            this.linkLabelPrecios.Location = new System.Drawing.Point(53, 461);
            this.linkLabelPrecios.Name = "linkLabelPrecios";
            this.linkLabelPrecios.Size = new System.Drawing.Size(92, 41);
            this.linkLabelPrecios.TabIndex = 5;
            this.linkLabelPrecios.TabStop = true;
            this.linkLabelPrecios.Text = "Precios";
            this.linkLabelPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelPrecios.Click += new System.EventHandler(this.LinkLabel1Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(670, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 50);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 502);
            this.Controls.Add(this.panelInicial);
            this.Controls.Add(this.panelBotonesInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoDeLali";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxCuentasCorrientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarCuentasCorrientes)).EndInit();
            this.panelBuscarCuentasCorrientes.ResumeLayout(false);
            this.panelBuscarCuentasCorrientes.PerformLayout();
            this.panelInicial.ResumeLayout(false);
            this.panelBotonesInicio.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.Button button1;
    }
}
