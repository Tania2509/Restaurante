namespace RestauranteTania
{
    partial class VentasView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cbGaseosa = new System.Windows.Forms.CheckBox();
            this.cbPapas = new System.Windows.Forms.CheckBox();
            this.cbHamburguesa = new System.Windows.Forms.CheckBox();
            this.rbParaLlevar = new System.Windows.Forms.RadioButton();
            this.rbComerAqui = new System.Windows.Forms.RadioButton();
            this.pbComida = new System.Windows.Forms.PictureBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbComida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizar.Location = new System.Drawing.Point(662, 364);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(168, 87);
            this.btnFinalizar.TabIndex = 23;
            this.btnFinalizar.Text = "Finalizar Venta";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(470, 364);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 87);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Metodo de Pago";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(557, 303);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(205, 29);
            this.cmbMetodoPago.TabIndex = 20;
            // 
            // cbGaseosa
            // 
            this.cbGaseosa.AutoSize = true;
            this.cbGaseosa.Location = new System.Drawing.Point(80, 387);
            this.cbGaseosa.Name = "cbGaseosa";
            this.cbGaseosa.Size = new System.Drawing.Size(182, 25);
            this.cbGaseosa.TabIndex = 19;
            this.cbGaseosa.Text = "Gaseosa en Lata\r\n";
            this.cbGaseosa.UseVisualStyleBackColor = true;
            // 
            // cbPapas
            // 
            this.cbPapas.AutoSize = true;
            this.cbPapas.Location = new System.Drawing.Point(80, 328);
            this.cbPapas.Name = "cbPapas";
            this.cbPapas.Size = new System.Drawing.Size(134, 25);
            this.cbPapas.TabIndex = 18;
            this.cbPapas.Text = "Papas Fritas";
            this.cbPapas.UseVisualStyleBackColor = true;
            // 
            // cbHamburguesa
            // 
            this.cbHamburguesa.AutoSize = true;
            this.cbHamburguesa.Location = new System.Drawing.Point(80, 265);
            this.cbHamburguesa.Name = "cbHamburguesa";
            this.cbHamburguesa.Size = new System.Drawing.Size(231, 25);
            this.cbHamburguesa.TabIndex = 17;
            this.cbHamburguesa.Text = "Hamburguesa premiun";
            this.cbHamburguesa.UseVisualStyleBackColor = true;
            // 
            // rbParaLlevar
            // 
            this.rbParaLlevar.AutoSize = true;
            this.rbParaLlevar.Location = new System.Drawing.Point(295, 184);
            this.rbParaLlevar.Name = "rbParaLlevar";
            this.rbParaLlevar.Size = new System.Drawing.Size(127, 25);
            this.rbParaLlevar.TabIndex = 16;
            this.rbParaLlevar.TabStop = true;
            this.rbParaLlevar.Text = "Para Llevar";
            this.rbParaLlevar.UseVisualStyleBackColor = true;
            // 
            // rbComerAqui
            // 
            this.rbComerAqui.AutoSize = true;
            this.rbComerAqui.Location = new System.Drawing.Point(127, 184);
            this.rbComerAqui.Name = "rbComerAqui";
            this.rbComerAqui.Size = new System.Drawing.Size(138, 25);
            this.rbComerAqui.TabIndex = 15;
            this.rbComerAqui.TabStop = true;
            this.rbComerAqui.Text = "Comer Aqui";
            this.rbComerAqui.UseVisualStyleBackColor = true;
            // 
            // pbComida
            // 
            this.pbComida.Image = global::RestauranteTania.Properties.Resources.icons8_hamburguesa_100;
            this.pbComida.Location = new System.Drawing.Point(561, 25);
            this.pbComida.Name = "pbComida";
            this.pbComida.Size = new System.Drawing.Size(135, 127);
            this.pbComida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComida.TabIndex = 14;
            this.pbComida.TabStop = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(264, 77);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(211, 30);
            this.txtNombreCliente.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // VentasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 531);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.cbGaseosa);
            this.Controls.Add(this.cbPapas);
            this.Controls.Add(this.cbHamburguesa);
            this.Controls.Add(this.rbParaLlevar);
            this.Controls.Add(this.rbComerAqui);
            this.Controls.Add(this.pbComida);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentasView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pbComida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.CheckBox cbGaseosa;
        private System.Windows.Forms.CheckBox cbPapas;
        private System.Windows.Forms.CheckBox cbHamburguesa;
        private System.Windows.Forms.RadioButton rbParaLlevar;
        private System.Windows.Forms.RadioButton rbComerAqui;
        private System.Windows.Forms.PictureBox pbComida;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
    }
}

