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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string RolUsuario, string NombreUsuario)
        {
            InitializeComponent();

            lblbienvenida.Text = "Bienvenido " + NombreUsuario;
            if (RolUsuario == "Administrador")
            {
                this.mantenimientosToolStripMenuItem.Enabled = true;
                this.toolStripMenuItem1.Enabled = true;
            }
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos Prod = new Productos();
            Prod.Show();
        }

        private void acercaDeChiyiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca acercade = new Acerca();
            acercade.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login Log = new Login();
            Log.Show();
        }


        private class MyRenderer : ToolStripProfessionalRenderer
{
    public MyRenderer() : base(new MyColors()) { }
}

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.Teal; }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.CadetBlue; }
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            menuStrip1.Renderer = new MyRenderer();
            

        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturación Fact = new Facturación();
            Fact.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes Reports = new Reportes();
            Reports.Show();
        }


      
    }
}
