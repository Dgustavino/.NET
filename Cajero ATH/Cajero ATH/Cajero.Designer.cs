namespace Cajero_ATH
{
    partial class Cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajero));
            this.btnAcceder = new System.Windows.Forms.Button();
            this.GB_Ingreso = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPin = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.L_pin = new System.Windows.Forms.Label();
            this.L_NumTarjeta = new System.Windows.Forms.Label();
            this.GB_Ingreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(263, 264);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(75, 23);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // GB_Ingreso
            // 
            this.GB_Ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GB_Ingreso.Controls.Add(this.maskedTextBoxPin);
            this.GB_Ingreso.Controls.Add(this.maskedTextBoxTarjeta);
            this.GB_Ingreso.Controls.Add(this.L_pin);
            this.GB_Ingreso.Controls.Add(this.L_NumTarjeta);
            this.GB_Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Ingreso.Location = new System.Drawing.Point(77, 50);
            this.GB_Ingreso.Name = "GB_Ingreso";
            this.GB_Ingreso.Size = new System.Drawing.Size(434, 159);
            this.GB_Ingreso.TabIndex = 1;
            this.GB_Ingreso.TabStop = false;
            this.GB_Ingreso.Text = "Ingreso";
            // 
            // maskedTextBoxPin
            // 
            this.maskedTextBoxPin.Location = new System.Drawing.Point(160, 119);
            this.maskedTextBoxPin.Name = "maskedTextBoxPin";
            this.maskedTextBoxPin.PasswordChar = '*';
            this.maskedTextBoxPin.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxPin.TabIndex = 3;
            // 
            // maskedTextBoxTarjeta
            // 
            this.maskedTextBoxTarjeta.Location = new System.Drawing.Point(160, 53);
            this.maskedTextBoxTarjeta.Name = "maskedTextBoxTarjeta";
            this.maskedTextBoxTarjeta.Size = new System.Drawing.Size(190, 23);
            this.maskedTextBoxTarjeta.TabIndex = 2;
            // 
            // L_pin
            // 
            this.L_pin.AutoSize = true;
            this.L_pin.Location = new System.Drawing.Point(43, 110);
            this.L_pin.Name = "L_pin";
            this.L_pin.Size = new System.Drawing.Size(28, 17);
            this.L_pin.TabIndex = 1;
            this.L_pin.Text = "Pin";
            this.L_pin.Click += new System.EventHandler(this.label2_Click);
            // 
            // L_NumTarjeta
            // 
            this.L_NumTarjeta.AutoSize = true;
            this.L_NumTarjeta.Location = new System.Drawing.Point(40, 53);
            this.L_NumTarjeta.Name = "L_NumTarjeta";
            this.L_NumTarjeta.Size = new System.Drawing.Size(107, 17);
            this.L_NumTarjeta.TabIndex = 0;
            this.L_NumTarjeta.Text = "Numero Tarjeta";
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cajero_ATH.Properties.Resources._9754856_código_ensamblador_de_programa_con_código_hexadecimal_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 310);
            this.Controls.Add(this.GB_Ingreso);
            this.Controls.Add(this.btnAcceder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cajero";
            this.Text = "Cajero";
            this.GB_Ingreso.ResumeLayout(false);
            this.GB_Ingreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.GroupBox GB_Ingreso;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarjeta;
        private System.Windows.Forms.Label L_pin;
        private System.Windows.Forms.Label L_NumTarjeta;
    }
}