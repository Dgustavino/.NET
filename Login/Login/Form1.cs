using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Validar_Usuario conn = new Validar_Usuario("server = CT-LB3-16\\SQL2016;database=Login;Integrated Security=True");

            string[] Usuario = new string[3];
            Usuario = conn.validarIngreso(textBoxUser.Text, textBoxPass.Text);

            string usu = "";//Para que validen y dejen pasar al otro formulario
            string tipo = "";//Rol

            if (Usuario.Contains(null))
            {
                MessageBox.Show("Datos incorrectos");
            }
            else
            {
                usu = Usuario[0].ToString();
                tipo = Usuario[2].ToString();

                Menu menu = new Menu(usu, tipo);
                menu.Show();//Muestreme el form Menu
                this.Hide();//Y escondame este form

            }//Fin del if


        }//Fin del boton
    }
}
