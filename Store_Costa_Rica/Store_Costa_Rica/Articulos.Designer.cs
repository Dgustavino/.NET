namespace Store_Costa_Rica
{
    partial class Articulos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCod = new System.Windows.Forms.ComboBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.labelProd = new System.Windows.Forms.Label();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelPrec = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.comboBoxCant = new System.Windows.Forms.ComboBox();
            this.textBoxPrec = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridArticulos = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiarData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Store_Costa_Rica.Properties.Resources.supermarket_cart;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(68, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARTICULOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxCod
            // 
            this.comboBoxCod.FormattingEnabled = true;
            this.comboBoxCod.Location = new System.Drawing.Point(75, 57);
            this.comboBoxCod.Name = "comboBoxCod";
            this.comboBoxCod.Size = new System.Drawing.Size(57, 21);
            this.comboBoxCod.TabIndex = 1;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCod.Location = new System.Drawing.Point(12, 62);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(57, 16);
            this.labelCod.TabIndex = 2;
            this.labelCod.Text = "Codigo:";
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProd.Location = new System.Drawing.Point(12, 122);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(69, 16);
            this.labelProd.TabIndex = 3;
            this.labelProd.Text = "Producto:";
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(87, 122);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(145, 20);
            this.textBoxProd.TabIndex = 4;
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(271, 122);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(86, 16);
            this.labelDes.TabIndex = 5;
            this.labelDes.Text = "Descripcion:";
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(163, 58);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(69, 16);
            this.labelCant.TabIndex = 6;
            this.labelCant.Text = "Cantidad:";
            // 
            // labelPrec
            // 
            this.labelPrec.AutoSize = true;
            this.labelPrec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrec.Location = new System.Drawing.Point(313, 70);
            this.labelPrec.Name = "labelPrec";
            this.labelPrec.Size = new System.Drawing.Size(53, 16);
            this.labelPrec.TabIndex = 7;
            this.labelPrec.Text = "Precio:";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(363, 122);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(145, 20);
            this.textBoxDes.TabIndex = 9;
            // 
            // comboBoxCant
            // 
            this.comboBoxCant.FormattingEnabled = true;
            this.comboBoxCant.Location = new System.Drawing.Point(238, 53);
            this.comboBoxCant.Name = "comboBoxCant";
            this.comboBoxCant.Size = new System.Drawing.Size(51, 21);
            this.comboBoxCant.TabIndex = 10;
            // 
            // textBoxPrec
            // 
            this.textBoxPrec.Location = new System.Drawing.Point(372, 70);
            this.textBoxPrec.Name = "textBoxPrec";
            this.textBoxPrec.Size = new System.Drawing.Size(77, 20);
            this.textBoxPrec.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Location = new System.Drawing.Point(531, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 32);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(604, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 31);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(1, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 5);
            this.panel2.TabIndex = 14;
            // 
            // dataGridArticulos
            // 
            this.dataGridArticulos.AllowUserToOrderColumns = true;
            this.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.prod,
            this.prec,
            this.descp,
            this.cant});
            this.dataGridArticulos.Location = new System.Drawing.Point(8, 261);
            this.dataGridArticulos.Name = "dataGridArticulos";
            this.dataGridArticulos.Size = new System.Drawing.Size(745, 218);
            this.dataGridArticulos.TabIndex = 15;
            // 
            // cod
            // 
            this.cod.HeaderText = "Codigo";
            this.cod.Name = "cod";
            // 
            // prod
            // 
            this.prod.HeaderText = "Producto";
            this.prod.Name = "prod";
            // 
            // prec
            // 
            this.prec.HeaderText = "Precio";
            this.prec.Name = "prec";
            // 
            // descp
            // 
            this.descp.HeaderText = "Descripcion";
            this.descp.Name = "descp";
            // 
            // cant
            // 
            this.cant.HeaderText = "Cantidad";
            this.cant.Name = "cant";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.Red;
            this.btnFacturar.Location = new System.Drawing.Point(57, 498);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(175, 32);
            this.btnFacturar.TabIndex = 18;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(515, 494);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(238, 36);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver al Menu Principal";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiarData
            // 
            this.btnLimpiarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarData.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiarData.Location = new System.Drawing.Point(306, 496);
            this.btnLimpiarData.Name = "btnLimpiarData";
            this.btnLimpiarData.Size = new System.Drawing.Size(120, 36);
            this.btnLimpiarData.TabIndex = 21;
            this.btnLimpiarData.Text = "Limpiar";
            this.btnLimpiarData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lista de Articulos";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox5.Image = global::Store_Costa_Rica.Properties.Resources.volver;
            this.pictureBox5.Location = new System.Drawing.Point(515, 497);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Store_Costa_Rica.Properties.Resources.Facturar;
            this.pictureBox4.Location = new System.Drawing.Point(57, 498);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Store_Costa_Rica.Properties.Resources.Clean;
            this.pictureBox3.Location = new System.Drawing.Point(316, 500);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Store_Costa_Rica.Properties.Resources.Clean;
            this.pictureBox2.Location = new System.Drawing.Point(582, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store_Costa_Rica.Properties.Resources.guardar;
            this.pictureBox1.Location = new System.Drawing.Point(504, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(75, 84);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(57, 20);
            this.textBoxCod.TabIndex = 26;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(238, 81);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(51, 20);
            this.textBoxCant.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAgregar.Location = new System.Drawing.Point(642, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 31);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(238, 203);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(234, 31);
            this.btnConsulta.TabIndex = 29;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 552);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBoxCant);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnLimpiarData);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridArticulos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBoxPrec);
            this.Controls.Add(this.comboBoxCant);
            this.Controls.Add(this.textBoxDes);
            this.Controls.Add(this.labelPrec);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.textBoxProd);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.labelCod);
            this.Controls.Add(this.comboBoxCod);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCod;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.TextBox textBoxProd;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelPrec;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.ComboBox comboBoxCant;
        private System.Windows.Forms.TextBox textBoxPrec;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridArticulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiarData;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn descp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
    }
}