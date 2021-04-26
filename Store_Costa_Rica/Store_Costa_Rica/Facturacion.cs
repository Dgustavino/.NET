using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store_Costa_Rica
{
    public partial class Facturacion : Form
    {
        Articulo articulo = new Articulo();

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlConnection conn = new SqlConnection("server= DIEGO\\SQLEXPRESS;database=Proyecto_1;Integrated Security=True");

        public Facturacion()
        {
            InitializeComponent();

            string query = "select * from cliente";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            comboBoxCedula.DisplayMember = "numero_cedula";
            comboBoxCedula.ValueMember = "id";
            comboBoxCedula.DataSource = dt;
        //------------------------------------------------------------------------

            string query2 = "select * from articulos";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            comboBoxCod.DisplayMember = "codigo";
            comboBoxCod.ValueMember = "id";
            comboBoxCod.DataSource = dt2;

            comboBoxCant.DisplayMember = "cantidad";
            comboBoxCant.ValueMember = "id";
            comboBoxCant.DataSource = dt2;
        }//Fin del InitializeComponent();

        public void Jalar_Cliente()
        {
            string query = "select *from cliente where numero_cedula=' " + comboBoxCedula.Text + "' ";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                textBoxNombre.Text = leer["nombre"].ToString();
                textBoxApell.Text = leer["apellidos"].ToString();
                textBoxTelef.Text = leer["telefono"].ToString();
                textBoxDirec.Text = leer["direccion"].ToString();
                textBoxCorreo.Text = leer["correo"].ToString();
            }
            conn.Close();
        }//Fin del metodo JalarArticulos


        public void Jalar_Articulos()
        {
            string query2 = "select * from articulos where codigo=' " + comboBoxCod.Text + "' ";
            
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            conn.Open();

            SqlDataReader leer2 = cmd2.ExecuteReader();
            if (leer2.Read() == true)
            {
                textBoxProducto.Text = leer2["producto"].ToString();
                textBoxDescp.Text = leer2["descripcion"].ToString();
                textBoxPrecio.Text = leer2["precio"].ToString();
                textBoxSubTotal.Text = leer2["subtotal"].ToString();
                
            }
            conn.Close();
        }//Fin del metodo JalarArticulos

        public void Jalar_Subtotal()
        {
            string query3 = "select cantidad * precio as subtotal from articulos where codigo=' " + comboBoxCod.Text + "' ";

            SqlCommand cmd3 = new SqlCommand(query3, conn);
            conn.Open();

            SqlDataReader leer3 = cmd3.ExecuteReader();
            if (leer3.Read() == true)
            {
                textBoxSubTotal.Text = leer3["subtotal"].ToString();
                textBoxSubT.Text = leer3["subtotal"].ToString();

            }
            conn.Close();
        }//Fin del metodo JalarArticulos

        public void Impuestos() 
        {
            int cantidad;
            float precio;
            double ImpuestoEfectivo = 0.13;
            double ImpuestoTarjeta = 0.20;
            double subTotal, Total;

            cantidad =int.Parse(comboBoxCant.Text);
            precio = float.Parse(textBoxPrecio.Text);

            subTotal = cantidad * precio;

            if (radioButtonEfectivo.Checked == true)
            {
                ImpuestoEfectivo = subTotal * 0.13;
                Total = subTotal + ImpuestoEfectivo;

                this.textBoxSubT.Text = subTotal.ToString();
                this.textBoxImpuestos.Text = ImpuestoEfectivo.ToString();
                this.textBoxTotal.Text = Total.ToString();
            }

            else if (radioButtonTarjeta.Checked == true) 
            {
                ImpuestoTarjeta = subTotal * 0.20;
                Total = subTotal + ImpuestoTarjeta;

                this.textBoxSubT.Text = subTotal.ToString();
                this.textBoxImpuestos.Text = ImpuestoTarjeta.ToString();
                this.textBoxTotal.Text = Total.ToString();
            }
        }//Fin del metodo Impuestos


        public void LimpiarArticulos()
        {
            this.comboBoxCod.Text = "";
            this.comboBoxCant.Text = "";
            this.textBoxProducto.Text = "";
            this.textBoxPrecio.Text = "";
            this.textBoxDescp.Text = "";
            this.textBoxSubTotal.Text = "";
            this.textBoxSubT.Text = "";
        }//Fin del metodo limpiarArticulos

        public void LimpiarCliente() 
        {
            this.comboBoxCedula.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxApell.Text = "";
            this.textBoxDirec.Text = "";
            this.textBoxTelef.Text = "";
            this.textBoxCorreo.Text = "";
        }//Fin del metodo LimpiarCliente

        public void LimpiarPago() 
        {
            this.textBoxImpuestos.Text = "";
            this.textBoxTotal.Text = "";
            
        }//Fin del metodo LimpiarPago


        //-------------------------------------------------------------------------------
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        //Metodo pago Efectivo
        {
            Impuestos();
            MessageBox.Show("***** GRACIAS POR SU COMPRA *****");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------------------------------

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal("","");
            menu.Show();
            this.Hide();
        }//Fin del boton Atras

        private void panelCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Jalar_Cliente();
            MessageBox.Show("!!!!! CLIENTE FACTURADO !!!!!");
        }

        private void L_Total_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarArt_Click(object sender, EventArgs e)
        {
            Jalar_Articulos();
            Jalar_Subtotal();
            MessageBox.Show("+++++ ARTICULO FACTURADO +++++");
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
            MessageBox.Show("!!!!! CLIENTE BORRADO !!!!!");
        }

        private void btnLimpiarA_Click(object sender, EventArgs e)
        {
            LimpiarArticulos();
            MessageBox.Show("!!!!! ARTICULO BORRADO !!!!!");
        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButtonTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            Impuestos();
            MessageBox.Show("***** GRACIAS POR SU COMPRA *****");
        }

        private void btnLimpiarPago_Click(object sender, EventArgs e)
        {
            LimpiarPago();
        }

    }//Fin del Form Facturacion

}//Fin delnamespace
