using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cajero_ATH.Clases;

namespace Cajero_ATH
{
    public partial class Cajero : Form

    {
        Cliente[] clientes = new Cliente[2];

        public Cajero()
        {
            InitializeComponent();
            clientes[0] = new Cliente("Diego Venegas g", "1111-1111-1111-1111", 1111, 150000);
            clientes[1] = new Cliente("Maria", "2222-2222-2222-2222", 2222, 50000);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {//Recorrer Arreglo con Foreach

            foreach (Cliente cli in clientes)
            {
                if (maskedTextBoxTarjeta.Text.Equals(cli.obtenerCuenta()) && maskedTextBoxPin.Text.Equals(cli.obtenerPin().ToString()))
                {
                    Cajero_ATH caj = new Cajero_ATH(cli);
                    caj.show();
                    this.Hide();
                }
            }
        }
    }
}
