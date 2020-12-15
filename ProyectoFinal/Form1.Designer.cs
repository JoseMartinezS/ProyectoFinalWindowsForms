namespace ProyectoFinal
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbSalida = new System.Windows.Forms.TextBox();
            this.txbIngresa = new System.Windows.Forms.TextBox();
            this.cobIngresa = new System.Windows.Forms.ComboBox();
            this.cobSalida = new System.Windows.Forms.ComboBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversor de Temperatura";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(520, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 26);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbSalida
            // 
            this.txbSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSalida.Location = new System.Drawing.Point(344, 82);
            this.txbSalida.Name = "txbSalida";
            this.txbSalida.Size = new System.Drawing.Size(122, 29);
            this.txbSalida.TabIndex = 3;
            // 
            // txbIngresa
            // 
            this.txbIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIngresa.Location = new System.Drawing.Point(115, 82);
            this.txbIngresa.Name = "txbIngresa";
            this.txbIngresa.Size = new System.Drawing.Size(122, 29);
            this.txbIngresa.TabIndex = 4;
            this.txbIngresa.TextChanged += new System.EventHandler(this.txbIngresa_TextChanged);
            // 
            // cobIngresa
            // 
            this.cobIngresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobIngresa.FormattingEnabled = true;
            this.cobIngresa.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cobIngresa.Location = new System.Drawing.Point(115, 124);
            this.cobIngresa.Name = "cobIngresa";
            this.cobIngresa.Size = new System.Drawing.Size(122, 32);
            this.cobIngresa.TabIndex = 5;
            this.cobIngresa.SelectedIndexChanged += new System.EventHandler(this.cobIngresa_SelectedIndexChanged);
            // 
            // cobSalida
            // 
            this.cobSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobSalida.FormattingEnabled = true;
            this.cobSalida.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cobSalida.Location = new System.Drawing.Point(344, 124);
            this.cobSalida.Name = "cobSalida";
            this.cobSalida.Size = new System.Drawing.Size(122, 32);
            this.cobSalida.TabIndex = 6;
            this.cobSalida.SelectedIndexChanged += new System.EventHandler(this.cobSalida_SelectedIndexChanged);
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(281, 105);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(24, 25);
            this.lblIgual.TabIndex = 7;
            this.lblIgual.Text = "=";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.fondo_nubes_cielo_azul_estilo_dibujos_animados_plano_cielo_nube_escena_cielo_nublado_capas_222220_69;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(597, 209);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 207);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.cobSalida);
            this.Controls.Add(this.cobIngresa);
            this.Controls.Add(this.txbIngresa);
            this.Controls.Add(this.txbSalida);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbSalida;
        private System.Windows.Forms.TextBox txbIngresa;
        private System.Windows.Forms.ComboBox cobIngresa;
        private System.Windows.Forms.ComboBox cobSalida;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

