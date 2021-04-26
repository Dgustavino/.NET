using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cajero_Automatico.Clases;

namespace Cajero_Automatico
{
    public partial class Form1 : Form
    {    //globales
       
        Cliente[] clientes = new Cliente[2];

        public Form1()
        {
            InitializeComponent();
            clientes[0] = new Cliente("Luis Felipe Fernandez", "1111-1111-1111-1111",
                1111, 150000);

            clientes[1] = new Cliente("Maria", "2222-2222-222-2222",
                2222, 50000);

       
        }

        private void button1acceder_Click(object sender, EventArgs e)
        {
            // Recorrer Arreglo con Foreach

            foreach (Cliente cli in clientes) { 
            if(maskedTextBoxTarjeta.Text.Equals(cli.obtenerCuenta())
                && textBoxPin.Text.Equals(cli.obtenerPin().ToString())){

                    Cajero caj = new Cajero(cli);
                    caj.Show();
                    this.Hide();
            
            }
            
            }
        }
    }
}
