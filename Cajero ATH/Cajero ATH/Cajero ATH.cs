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
    public partial class Cajero_ATH : Form
    {
        public Cajero_ATH()
        {
            InitializeComponent();
        }

        private void Cajero_ATH_Load(object sender, EventArgs e)
        {


        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double monto = 0;
            if (radioButton2000.Checked) 
            {
                monto = 2000;
            }

            else if (radioButton4000.Checked) 
            {
                monto = 4000;
            }

            else if (radioButton5000.Checked) 
            {
                monto = 5000;
            }

            else if (radioButton6000.Checked) 
            {
                monto = 6000;
            }

            else if (radioButton8000.Checked) 
            {
                monto = 8000;
            }

            else if (radioButton10000.Checked) 
            {
                monto = 10000;
            }

            else if (radioButton20000.Checked) 
            {
                monto = 20000;
            }

            else if (radioButtonOtro.Checked) 
            {
                double.TryParse(textBoxOtroMonto.Text, out monto);
            }

            if (monto == 0) 
            {
                MessageBox.Show("El saldo disponible es inferior al monto" 
                    + "solicitado", "Fondos insuficientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string salida = "Transaccion:\r\nFecha:" +
                DateTime.Now.ToString() + "\r\nCuenta:";

            this.groupBoxPantalla.Text = salida;


        }
    }
}
