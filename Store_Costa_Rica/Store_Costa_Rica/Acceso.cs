using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Costa_Rica
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void L_User_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------------

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }//Fin del boton Cerrar

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Validar_Usuario conn = new Validar_Usuario("server = DIEGO\\SQLEXPRESS;Database=Proyecto_1;Integrated Security=True");

            string[] Usuario = new string[3];
            Usuario = conn.ValidarIngreso(TextBoxUser.Text, TexBoxPass.Text);

            string user = "";
            string rol = "";

            if (Usuario.Contains(null))
            {
                MessageBox.Show("Datos Incorrectos");
            }
            else 
            {
                user = Usuario[0].ToString();
                rol = Usuario[2].ToString();

                Menu_Principal menu = new Menu_Principal(user, rol);
                menu.Show();
                this.Hide();

            }//Fin del if-else

        }//Fin del Boton ingresar

    }//Fin del formAcceso

}//Fin del namespace
