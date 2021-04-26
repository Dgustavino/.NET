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
    public partial class Clientes : Form
    {

        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection("server= DIEGO\\SQLEXPRESS;database=Proyecto_1;Integrated Security=True");

        public Clientes()
        {
            InitializeComponent();

        }//Fin del  InitializeComponent();

        public string connecion = ""; //Constructor 
        public Clientes(string conn)
        {
           this.connecion = conn;
        }

        public void ingresar_cliente(int Numero_Cedula, string Nombre, string Apellidos, string Direccion, string Telefono, string Correo)
        {
            try
            {
                SqlConnection Coneccion = new SqlConnection("server= DIEGO\\SQLEXPRESS;database=Proyecto_1;Integrated Security=True");
                SqlCommand Comando = new SqlCommand();

                SqlParameter numero_cedula = new SqlParameter("@numero_cedula", SqlDbType.Int);
                numero_cedula.Value = Numero_Cedula;

                SqlParameter nombre = new SqlParameter("@nombre", SqlDbType.NVarChar);
                nombre.Value = Nombre;

                SqlParameter apellidos = new SqlParameter("@apellidos", SqlDbType.NVarChar);
                apellidos.Value = Apellidos;

                SqlParameter direccion = new SqlParameter("@direccion", SqlDbType.NVarChar);
                direccion.Value = Direccion;

                SqlParameter telefono = new SqlParameter("@telefono", SqlDbType.Int);
                telefono.Value = Telefono;

                SqlParameter correo = new SqlParameter("@correo", SqlDbType.NVarChar);
                correo.Value = Correo;

                Comando.Parameters.Add(numero_cedula);
                Comando.Parameters.Add(nombre);
                Comando.Parameters.Add(apellidos);
                Comando.Parameters.Add(direccion);
                Comando.Parameters.Add(telefono);
                Comando.Parameters.Add(correo);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ingresar_cliente";
                Coneccion.Open();
                Comando.Connection = Coneccion;
                Comando.ExecuteNonQuery();
                Coneccion.Close();

            }//Fin del Try
            catch (SqlException e)
            {
                throw e;
            }//Fin del catch
        }//Fin del metodo

        public DataTable consulta_clientes()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter consulta = new SqlDataAdapter("select *from cliente ", conn);

                consulta.Fill(dt);

                dataGridClientes.DataSource = dt;

                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }//Fin del metodo cargarClientes

        public void limpiar() 
        {
            this.textBoxNac.Text= "";
            this.textBoxExt.Text = "";
            this.textBoxNombre.Text = "";
            this.textBoxApell.Text = "";
            this.textBoxDirecc.Text = "";
            this.textBoxTelf.Text = "";
            this.textBoxCorreo.Text = "";
        }//Fin del metodo Limpiar

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal("", "");
            menu.Show();
            this.Hide();
        }//Fin del boton Volver

        private void Clientes_Load(object sender, EventArgs e)
        {

        }


        private void radioButtonNac_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNac.Checked == true) 
            {
                radioButtonExt.Enabled = false;
            }
        }//Fin del RadioButon

        private void radioButtonExt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExt.Checked == true) 
            {
                radioButtonNac.Enabled = false;
            }
        }//Fin del RadioButton

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ingresar_cliente(int.Parse(textBoxNac.Text),textBoxNombre.Text,textBoxApell.Text,textBoxDirecc.Text,textBoxTelf.Text,textBoxCorreo.Text);
            dataGridClientes.Rows.Add(int.Parse(textBoxNac.Text), textBoxNombre.Text, textBoxApell.Text, textBoxDirecc.Text, textBoxTelf.Text, textBoxCorreo.Text);

        }//Fin del boton Guardar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consulta_clientes();
        }//Fin del boton limpiar






    }//Fin del formClientes
}//Fin de la solucion
