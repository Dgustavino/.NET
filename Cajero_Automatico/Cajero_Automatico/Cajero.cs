using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//importar la clase Cliente
using Cajero_Automatico.Clases;

namespace Cajero_Automatico
{
    public partial class Cajero : Form
    {
        int contadormonto = 0;
        int contador2000 = 0;
        int contador4000 = 0;
        int contador5000 = 0;
        int contador6000 = 0;
        int contador8000 = 0;
        int contador10000 = 0;
        int contador20000 = 0;





        //global
        Cliente persona = new Cliente();
        //modificar el constructor para q reciba un 
        //objeto de tipo Cliente
        public Cajero(Cliente cliente)
        {
            InitializeComponent();
            persona = cliente;
            this.Campo_Cliente.Text = persona.obtenerNombre();
            this.Campo_cuenta_consulta.Text = "xxxx-xxxx-xxxx-" +
                persona.obtenerCuenta().Substring(15);
            this.Campo_cuentaRetiro.Text = this.Campo_cuenta_consulta.Text;
        }

     

        private void radioButtonConsulta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConsuta.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
            }
            if (radioButtonRetiro.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
           
            Campo_saldo.Text = persona.obtenerSaldo().ToString();


        }

        private void Cajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRetirar_Click(object sender, EventArgs e)
        {
           
            double monto = 0;

            if (radioButton2000.Checked)
            {
                monto = 2000;
                contador2000++;
               
            }
            else if (radioButton4000.Checked)
            {
                monto = 4000;
                contador4000++;

            }
            else if (radioButton5000.Checked)
            {
                monto = 5000;
                contador5000++;

            }


            else if (radioButton6000.Checked)
            {
                monto = 6000;
                contador6000++;

            }

            else if (radioButton8000.Checked)
            {
                monto = 80000;
                contador8000++;

            }


            else if (radioButton10_000.Checked)
            {
                monto = 10000;
                contador10000++;

            }

            else if (radioButton20000.Checked)
            {
                monto = 20000;
                contador20000++;

            }


            else if (radioButtonOtro_monto.Checked)
            {
                monto = double.Parse(campo_Monto.Text);
            }



            


            if (monto == 0)
            {
                MessageBox.Show("El monto que solicita retirar es cero",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (!persona.disminuirSaldo(monto))
            {
                MessageBox.Show("El saldo disponible es inferior al monto" +
                    " solicitado", "Fondos insufucientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                contadormonto++;


            }
           

            string salida = "\r\nBANCO PROGRAMACION III" +

               "\r" + "\r" + "\r" + "\r\nTransaccion:\r\nFecha: " +
                DateTime.Now.ToString() + "\r\nCuenta: " +
                Campo_cuenta_consulta.Text + "\r\nMonto retirado:" +
                monto + "\r\nsaldo actual: " +
                persona.obtenerSaldo().ToString();

          this.textBox6.Text = salida;

    






        }

        private void campoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

     
    }
}