namespace LoDeLali
{
    partial class Form_MensajeCondicional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MensajeCondicional));
            this.buttonNuevoCondicional = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNuevoCondicional
            // 
            this.buttonNuevoCondicional.BackColor = System.Drawing.Color.Transparent;
            this.buttonNuevoCondicional.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.buttonNuevoCondicional.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonNuevoCondicional.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.buttonNuevoCondicional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.buttonNuevoCondicional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevoCondicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoCondicional.Location = new System.Drawing.Point(42, 106);
            this.buttonNuevoCondicional.Name = "buttonNuevoCondicional";
            this.buttonNuevoCondicional.Size = new System.Drawing.Size(461, 55);
            this.buttonNuevoCondicional.TabIndex = 0;
            this.buttonNuevoCondicional.Text = "Generar nuevo condicional";
            this.buttonNuevoCondicional.UseVisualStyleBackColor = false;
            this.buttonNuevoCondicional.Click += new System.EventHandler(this.buttonNuevoCondicional_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(461, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Revisar lista de condicionales";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Qué desea realizar?";
            // 
            // MensajeCondicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(531, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNuevoCondicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MensajeCondicional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MensajeCondicional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevoCondicional;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}