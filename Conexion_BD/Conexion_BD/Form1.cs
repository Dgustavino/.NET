using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Conexion_BD
{
    public partial class Form1 : Form
 {
     ConexionBD conn = new ConexionBD("data source =DIEGO\\SQLEXPRESS; initial catalog = Ejemplo2; integrated security = true");

        public Form1()
        {
            InitializeComponent();
        }

        private void txbNombre_Click(object sender, EventArgs e)
        {

        }

        private void txbDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //Tiene que ejecutarse un metodo x vez, no a la vez ambos
          /* conn.ingresar_cliente(int.Parse(txbCedula.Text), txbNombre.Text, txbApellidos.Text, txbDireccion.Text, txbTelefono.Text, txbCorreo.Text);
           MessageBox.Show("se guarda con exito ");

           conn.Actualizar_Cliente(int.Parse(txbCedula.Text), txbNombre.Text, txbApellidos.Text, txbDireccion.Text, txbTelefono.Text, txbCorreo.Text);
           MessageBox.Show("Se actualizo con exito ");*/

           conn.Borrar_Cliente(int.Parse(txbCedula.Text));
           MessageBox.Show("Se Borro Cliente con exito ");

 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            conn.Insertar_Producto(int.Parse(txbcodigo.Text),txbprecio.Text,txbdescripcion.Text);
            MessageBox.Show("se guarda con exito ");
        }*/
    }//Fin de la clase Form1
}
