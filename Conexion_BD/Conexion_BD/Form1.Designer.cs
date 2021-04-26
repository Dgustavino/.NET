namespace Conexion_BD
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
            this.L_Cedula = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_Apellidos = new System.Windows.Forms.Label();
            this.L_Direccion = new System.Windows.Forms.Label();
            this.L_Telefono = new System.Windows.Forms.Label();
            this.L_Correo = new System.Windows.Forms.Label();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Cedula
            // 
            this.L_Cedula.AutoSize = true;
            this.L_Cedula.Location = new System.Drawing.Point(38, 35);
            this.L_Cedula.Name = "L_Cedula";
            this.L_Cedula.Size = new System.Drawing.Size(40, 13);
            this.L_Cedula.TabIndex = 0;
            this.L_Cedula.Text = "Cedula";
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Location = new System.Drawing.Point(35, 81);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(44, 13);
            this.L_Nombre.TabIndex = 1;
            this.L_Nombre.Text = "Nombre";
            this.L_Nombre.Click += new System.EventHandler(this.txbNombre_Click);
            // 
            // L_Apellidos
            // 
            this.L_Apellidos.AutoSize = true;
            this.L_Apellidos.Location = new System.Drawing.Point(35, 140);
            this.L_Apellidos.Name = "L_Apellidos";
            this.L_Apellidos.Size = new System.Drawing.Size(49, 13);
            this.L_Apellidos.TabIndex = 2;
            this.L_Apellidos.Text = "Apellidos";
            // 
            // L_Direccion
            // 
            this.L_Direccion.AutoSize = true;
            this.L_Direccion.Location = new System.Drawing.Point(32, 188);
            this.L_Direccion.Name = "L_Direccion";
            this.L_Direccion.Size = new System.Drawing.Size(52, 13);
            this.L_Direccion.TabIndex = 3;
            this.L_Direccion.Text = "Direccion";
            // 
            // L_Telefono
            // 
            this.L_Telefono.AutoSize = true;
            this.L_Telefono.Location = new System.Drawing.Point(32, 231);
            this.L_Telefono.Name = "L_Telefono";
            this.L_Telefono.Size = new System.Drawing.Size(49, 13);
            this.L_Telefono.TabIndex = 4;
            this.L_Telefono.Text = "Telefono";
            // 
            // L_Correo
            // 
            this.L_Correo.AutoSize = true;
            this.L_Correo.Location = new System.Drawing.Point(38, 273);
            this.L_Correo.Name = "L_Correo";
            this.L_Correo.Size = new System.Drawing.Size(38, 13);
            this.L_Correo.TabIndex = 5;
            this.L_Correo.Text = "Correo";
            // 
            // txbCedula
            // 
            this.txbCedula.Location = new System.Drawing.Point(84, 32);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(100, 20);
            this.txbCedula.TabIndex = 6;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(84, 81);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(84, 140);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(100, 20);
            this.txbApellidos.TabIndex = 8;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(84, 185);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(100, 20);
            this.txbDireccion.TabIndex = 9;
            this.txbDireccion.TextChanged += new System.EventHandler(this.txbDireccion_TextChanged);
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(84, 231);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(100, 20);
            this.txbTelefono.TabIndex = 10;
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(84, 273);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(100, 20);
            this.txbCorreo.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(84, 335);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 390);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbCorreo);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCedula);
            this.Controls.Add(this.L_Correo);
            this.Controls.Add(this.L_Telefono);
            this.Controls.Add(this.L_Direccion);
            this.Controls.Add(this.L_Apellidos);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.L_Cedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Cedula;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_Apellidos;
        private System.Windows.Forms.Label L_Direccion;
        private System.Windows.Forms.Label L_Telefono;
        private System.Windows.Forms.Label L_Correo;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Button btnAceptar;
    }
}

