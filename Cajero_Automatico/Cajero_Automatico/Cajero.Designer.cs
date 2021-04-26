namespace Cajero_Automatico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRetiro = new System.Windows.Forms.RadioButton();
            this.radioButtonConsuta = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.campo_Monto = new System.Windows.Forms.TextBox();
            this.radioButtonOtro_monto = new System.Windows.Forms.RadioButton();
            this.radioButton20000 = new System.Windows.Forms.RadioButton();
            this.radioButton10_000 = new System.Windows.Forms.RadioButton();
            this.radioButton8000 = new System.Windows.Forms.RadioButton();
            this.radioButton6000 = new System.Windows.Forms.RadioButton();
            this.radioButton5000 = new System.Windows.Forms.RadioButton();
            this.radioButton4000 = new System.Windows.Forms.RadioButton();
            this.radioButton2000 = new System.Windows.Forms.RadioButton();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.Campo_cuentaRetiro = new System.Windows.Forms.TextBox();
            this.labelCuentaRetiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.Campo_saldo = new System.Windows.Forms.TextBox();
            this.Campo_cuenta_consulta = new System.Windows.Forms.TextBox();
            this.Campo_Cliente = new System.Windows.Forms.TextBox();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRetiro);
            this.groupBox1.Controls.Add(this.radioButtonConsuta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "|3";
            // 
            // radioButtonRetiro
            // 
            this.radioButtonRetiro.AutoSize = true;
            this.radioButtonRetiro.Location = new System.Drawing.Point(180, 19);
            this.radioButtonRetiro.Name = "radioButtonRetiro";
            this.radioButtonRetiro.Size = new System.Drawing.Size(53, 17);
            this.radioButtonRetiro.TabIndex = 1;
            this.radioButtonRetiro.TabStop = true;
            this.radioButtonRetiro.Text = "Retiro";
            this.radioButtonRetiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonConsuta
            // 
            this.radioButtonConsuta.AutoSize = true;
            this.radioButtonConsuta.Location = new System.Drawing.Point(45, 19);
            this.radioButtonConsuta.Name = "radioButtonConsuta";
            this.radioButtonConsuta.Size = new System.Drawing.Size(64, 17);
            this.radioButtonConsuta.TabIndex = 0;
            this.radioButtonConsuta.TabStop = true;
            this.radioButtonConsuta.Text = "Consuta";
            this.radioButtonConsuta.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.campo_Monto);
            this.groupBox3.Controls.Add(this.radioButtonOtro_monto);
            this.groupBox3.Controls.Add(this.radioButton20000);
            this.groupBox3.Controls.Add(this.radioButton10_000);
            this.groupBox3.Controls.Add(this.radioButton8000);
            this.groupBox3.Controls.Add(this.radioButton6000);
            this.groupBox3.Controls.Add(this.radioButton5000);
            this.groupBox3.Controls.Add(this.radioButton4000);
            this.groupBox3.Controls.Add(this.radioButton2000);
            this.groupBox3.Controls.Add(this.buttonRetirar);
            this.groupBox3.Controls.Add(this.Campo_cuentaRetiro);
            this.groupBox3.Controls.Add(this.labelCuentaRetiro);
            this.groupBox3.Location = new System.Drawing.Point(12, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 125);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retiro";
            // 
            // campo_Monto
            // 
            this.campo_Monto.Location = new System.Drawing.Point(251, 105);
            this.campo_Monto.Name = "campo_Monto";
            this.campo_Monto.Size = new System.Drawing.Size(91, 20);
            this.campo_Monto.TabIndex = 11;
            // 
            // radioButtonOtro_monto
            // 
            this.radioButtonOtro_monto.AutoSize = true;
            this.radioButtonOtro_monto.Location = new System.Drawing.Point(251, 82);
            this.radioButtonOtro_monto.Name = "radioButtonOtro_monto";
            this.radioButtonOtro_monto.Size = new System.Drawing.Size(77, 17);
            this.radioButtonOtro_monto.TabIndex = 10;
            this.radioButtonOtro_monto.TabStop = true;
            this.radioButtonOtro_monto.Text = "Otro monto";
            this.radioButtonOtro_monto.UseVisualStyleBackColor = true;
            // 
            // radioButton20000
            // 
            this.radioButton20000.AutoSize = true;
            this.radioButton20000.Location = new System.Drawing.Point(251, 59);
            this.radioButton20000.Name = "radioButton20000";
            this.radioButton20000.Size = new System.Drawing.Size(58, 17);
            this.radioButton20000.TabIndex = 9;
            this.radioButton20000.TabStop = true;
            this.radioButton20000.Text = "20 000";
            this.radioButton20000.UseVisualStyleBackColor = true;
            // 
            // radioButton10_000
            // 
            this.radioButton10_000.AutoSize = true;
            this.radioButton10_000.Location = new System.Drawing.Point(156, 99);
            this.radioButton10_000.Name = "radioButton10_000";
            this.radioButton10_000.Size = new System.Drawing.Size(58, 17);
            this.radioButton10_000.TabIndex = 8;
            this.radioButton10_000.TabStop = true;
            this.radioButton10_000.Text = "10 000";
            this.radioButton10_000.UseVisualStyleBackColor = true;
            // 
            // radioButton8000
            // 
            this.radioButton8000.AutoSize = true;
            this.radioButton8000.Location = new System.Drawing.Point(156, 76);
            this.radioButton8000.Name = "radioButton8000";
            this.radioButton8000.Size = new System.Drawing.Size(49, 17);
            this.radioButton8000.TabIndex = 7;
            this.radioButton8000.TabStop = true;
            this.radioButton8000.Text = "8000";
            this.radioButton8000.UseVisualStyleBackColor = true;
            // 
            // radioButton6000
            // 
            this.radioButton6000.AutoSize = true;
            this.radioButton6000.Location = new System.Drawing.Point(156, 59);
            this.radioButton6000.Name = "radioButton6000";
            this.radioButton6000.Size = new System.Drawing.Size(49, 17);
            this.radioButton6000.TabIndex = 6;
            this.radioButton6000.TabStop = true;
            this.radioButton6000.Text = "6000";
            this.radioButton6000.UseVisualStyleBackColor = true;
            // 
            // radioButton5000
            // 
            this.radioButton5000.AutoSize = true;
            this.radioButton5000.Location = new System.Drawing.Point(45, 99);
            this.radioButton5000.Name = "radioButton5000";
            this.radioButton5000.Size = new System.Drawing.Size(49, 17);
            this.radioButton5000.TabIndex = 5;
            this.radioButton5000.TabStop = true;
            this.radioButton5000.Text = "5000";
            this.radioButton5000.UseVisualStyleBackColor = true;
            // 
            // radioButton4000
            // 
            this.radioButton4000.AutoSize = true;
            this.radioButton4000.Location = new System.Drawing.Point(45, 76);
            this.radioButton4000.Name = "radioButton4000";
            this.radioButton4000.Size = new System.Drawing.Size(49, 17);
            this.radioButton4000.TabIndex = 4;
            this.radioButton4000.TabStop = true;
            this.radioButton4000.Text = "4000";
            this.radioButton4000.UseVisualStyleBackColor = true;
            // 
            // radioButton2000
            // 
            this.radioButton2000.AutoSize = true;
            this.radioButton2000.Location = new System.Drawing.Point(45, 59);
            this.radioButton2000.Name = "radioButton2000";
            this.radioButton2000.Size = new System.Drawing.Size(49, 17);
            this.radioButton2000.TabIndex = 3;
            this.radioButton2000.TabStop = true;
            this.radioButton2000.Text = "2000";
            this.radioButton2000.UseVisualStyleBackColor = true;
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(337, 23);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(75, 23);
            this.buttonRetirar.TabIndex = 2;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // Campo_cuentaRetiro
            // 
            this.Campo_cuentaRetiro.Location = new System.Drawing.Point(118, 26);
            this.Campo_cuentaRetiro.Name = "Campo_cuentaRetiro";
            this.Campo_cuentaRetiro.Size = new System.Drawing.Size(191, 20);
            this.Campo_cuentaRetiro.TabIndex = 1;
            // 
            // labelCuentaRetiro
            // 
            this.labelCuentaRetiro.AutoSize = true;
            this.labelCuentaRetiro.Location = new System.Drawing.Point(42, 33);
            this.labelCuentaRetiro.Name = "labelCuentaRetiro";
            this.labelCuentaRetiro.Size = new System.Drawing.Size(41, 13);
            this.labelCuentaRetiro.TabIndex = 0;
            this.labelCuentaRetiro.Text = "Cuenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSaldo);
            this.groupBox2.Controls.Add(this.Campo_saldo);
            this.groupBox2.Controls.Add(this.Campo_cuenta_consulta);
            this.groupBox2.Controls.Add(this.Campo_Cliente);
            this.groupBox2.Controls.Add(this.labelCuenta);
            this.groupBox2.Controls.Add(this.labelCliente);
            this.groupBox2.Controls.Add(this.buttonConsultar);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 101);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(248, 71);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(34, 13);
            this.labelSaldo.TabIndex = 11;
            this.labelSaldo.Text = "Saldo";
            // 
            // Campo_saldo
            // 
            this.Campo_saldo.Location = new System.Drawing.Point(288, 64);
            this.Campo_saldo.Name = "Campo_saldo";
            this.Campo_saldo.Size = new System.Drawing.Size(124, 20);
            this.Campo_saldo.TabIndex = 10;
            // 
            // Campo_cuenta_consulta
            // 
            this.Campo_cuenta_consulta.Location = new System.Drawing.Point(81, 64);
            this.Campo_cuenta_consulta.Name = "Campo_cuenta_consulta";
            this.Campo_cuenta_consulta.Size = new System.Drawing.Size(152, 20);
            this.Campo_cuenta_consulta.TabIndex = 9;
            // 
            // Campo_Cliente
            // 
            this.Campo_Cliente.Location = new System.Drawing.Point(81, 13);
            this.Campo_Cliente.Name = "Campo_Cliente";
            this.Campo_Cliente.Size = new System.Drawing.Size(367, 20);
            this.Campo_Cliente.TabIndex = 8;
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Location = new System.Drawing.Point(19, 67);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(41, 13);
            this.labelCuenta.TabIndex = 7;
            this.labelCuenta.Text = "Cuenta";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(19, 16);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 6;
            this.labelCliente.Text = "Cliente";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(447, 61);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Location = new System.Drawing.Point(12, 325);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 168);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " uu";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(503, 140);
            this.textBox6.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cajero";
            this.Text = "Cajero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRetiro;
        private System.Windows.Forms.RadioButton radioButtonConsuta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox Campo_Cliente;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox campo_Monto;
        private System.Windows.Forms.RadioButton radioButtonOtro_monto;
        private System.Windows.Forms.RadioButton radioButton20000;
        private System.Windows.Forms.RadioButton radioButton10_000;
        private System.Windows.Forms.RadioButton radioButton8000;
        private System.Windows.Forms.RadioButton radioButton6000;
        private System.Windows.Forms.RadioButton radioButton5000;
        private System.Windows.Forms.RadioButton radioButton4000;
        private System.Windows.Forms.RadioButton radioButton2000;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.TextBox Campo_cuentaRetiro;
        private System.Windows.Forms.Label labelCuentaRetiro;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.TextBox Campo_saldo;
        private System.Windows.Forms.TextBox Campo_cuenta_consulta;
        private System.Windows.Forms.TextBox textBox6;
    }
}