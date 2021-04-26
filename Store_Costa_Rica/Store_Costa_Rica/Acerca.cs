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
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal("", "");
            menu.Show();
            this.Hide();
        }
    }
}
