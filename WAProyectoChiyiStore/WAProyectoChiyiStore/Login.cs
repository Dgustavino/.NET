using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAProyectoChiyiStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //programar botón de ingreso
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario conn = new ValidarUsuario("Data Source=CUIS-PC;Initial Catalog= Chiyi;Integrated Security = True");

            string[] Usuario = new string[4];
            Usuario = conn.m_ValidarIngreso(txbUsuario.Text, txbClave.Text);

            string varRolUsuario = "";
            string varNombreUsuario = "";

            if (Usuario.Contains(null))
            {
                MessageBox.Show("Datos Incorrectos");
            }
            else
            {
                varRolUsuario = Usuario[0].ToString();
                varNombreUsuario = Usuario[3].ToString();

                MenuPrincipal menu = new MenuPrincipal(varRolUsuario, varNombreUsuario);
                menu.Show();
                this.Visible = false;
            }
            
  
        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Acerca acercade = new Acerca();
            acercade.Show();
        }
    }
}
