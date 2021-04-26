namespace Login
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
            this.L_Usuario = new System.Windows.Forms.Label();
            this.L_Pass = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Usuario
            // 
            this.L_Usuario.AutoSize = true;
            this.L_Usuario.Location = new System.Drawing.Point(79, 72);
            this.L_Usuario.Name = "L_Usuario";
            this.L_Usuario.Size = new System.Drawing.Size(43, 13);
            this.L_Usuario.TabIndex = 0;
            this.L_Usuario.Text = "Usuario";
            // 
            // L_Pass
            // 
            this.L_Pass.AutoSize = true;
            this.L_Pass.Location = new System.Drawing.Point(82, 139);
            this.L_Pass.Name = "L_Pass";
            this.L_Pass.Size = new System.Drawing.Size(61, 13);
            this.L_Pass.TabIndex = 1;
            this.L_Pass.Text = "Contraseña";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(143, 72);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(162, 139);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(162, 241);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 356);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.L_Pass);
            this.Controls.Add(this.L_Usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Usuario;
        private System.Windows.Forms.Label L_Pass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button BtnIngresar;
    }
}

