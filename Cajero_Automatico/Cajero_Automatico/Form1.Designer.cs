namespace Cajero_Automatico
{
    partial class Form1
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
            this.groupBoxIngreso = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.button1acceder = new System.Windows.Forms.Button();
            this.groupBoxIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngreso
            // 
            this.groupBoxIngreso.Controls.Add(this.maskedTextBoxTarjeta);
            this.groupBoxIngreso.Controls.Add(this.textBoxPin);
            this.groupBoxIngreso.Controls.Add(this.labelPIN);
            this.groupBoxIngreso.Controls.Add(this.labelTarjeta);
            this.groupBoxIngreso.Location = new System.Drawing.Point(23, 12);
            this.groupBoxIngreso.Name = "groupBoxIngreso";
            this.groupBoxIngreso.Size = new System.Drawing.Size(266, 101);
            this.groupBoxIngreso.TabIndex = 0;
            this.groupBoxIngreso.TabStop = false;
            this.groupBoxIngreso.Text = "Ingreso";
            // 
            // maskedTextBoxTarjeta
            // 
            this.maskedTextBoxTarjeta.Location = new System.Drawing.Point(115, 19);
            this.maskedTextBoxTarjeta.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxTarjeta.Name = "maskedTextBoxTarjeta";
            this.maskedTextBoxTarjeta.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTarjeta.TabIndex = 2;
            // 
            // textBoxPin
            // 
            this.textBoxPin.Location = new System.Drawing.Point(115, 62);
            this.textBoxPin.MaxLength = 4;
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.PasswordChar = '*';
            this.textBoxPin.Size = new System.Drawing.Size(100, 20);
            this.textBoxPin.TabIndex = 1;
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Location = new System.Drawing.Point(11, 69);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(25, 13);
            this.labelPIN.TabIndex = 1;
            this.labelPIN.Text = "PIN";
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Location = new System.Drawing.Point(11, 25);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(98, 13);
            this.labelTarjeta.TabIndex = 0;
            this.labelTarjeta.Text = "Numero de Tarjeta ";
            // 
            // button1acceder
            // 
            this.button1acceder.Location = new System.Drawing.Point(125, 120);
            this.button1acceder.Name = "button1acceder";
            this.button1acceder.Size = new System.Drawing.Size(75, 23);
            this.button1acceder.TabIndex = 1;
            this.button1acceder.Text = "ACCEDER";
            this.button1acceder.UseVisualStyleBackColor = true;
            this.button1acceder.Click += new System.EventHandler(this.button1acceder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 155);
            this.Controls.Add(this.button1acceder);
            this.Controls.Add(this.groupBoxIngreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxIngreso.ResumeLayout(false);
            this.groupBoxIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngreso;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarjeta;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.Button button1acceder;
    }
}

