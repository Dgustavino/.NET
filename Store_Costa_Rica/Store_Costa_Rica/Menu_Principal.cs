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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal(string user, string rol)
        {
            InitializeComponent();

            L_Rol.Text = rol;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facturacion fact = new Facturacion();
            fact.Show();
            this.Hide();
        }
        //--------------------------------------------------------------------------

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acerca acerca = new Acerca();
            acerca.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
        }
        //-----------------------------------------------------------------------

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Acceso acceso = new Acceso();
            acceso.Show();
            this.Hide();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToLongTimeString();
            this.labelFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            art.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
            this.Hide();
        }

    }//Fin del Form Menu_Principal

}//Fin del namespace
