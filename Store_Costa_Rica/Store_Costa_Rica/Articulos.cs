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
    public partial class Articulos : Form
    {

        DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection("server= DIEGO\\SQLEXPRESS;database=Proyecto_1;Integrated Security=True");

        public Articulos()
        {
            InitializeComponent();

            string query = "select * from articulos";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            comboBoxCod.DisplayMember = "codigo";
            comboBoxCod.ValueMember = "id";
            comboBoxCod.DataSource = dt;

            comboBoxCant.DisplayMember = "cantidad";
            comboBoxCant.ValueMember = "id";
            comboBoxCant.DataSource = dt;
        }//Fin del InitializeComponent();

        public void Jalar_Articulos()
        {
            string query = "select *from articulos where codigo=' " + comboBoxCod.Text + "' ";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                textBoxProd.Text = leer["producto"].ToString();
                textBoxDes.Text = leer["descripcion"].ToString();
                textBoxPrec.Text = leer["precio"].ToString();
            }
            conn.Close();
        }//Fin del metodo JalarArticulos


        public string connecion = ""; //Constructor 
        public Articulos(string conn)
        {
            this.connecion = conn;
        }

        public void Insertar_Articulo(int Codigo, string Producto, string Descripcion, int Precio, int Cantidad)
        {
            try
            {
                SqlConnection Connecion = new SqlConnection("server= DIEGO\\SQLEXPRESS;database=Proyecto_1;Integrated Security=True");
                SqlCommand Comando = new SqlCommand();

                SqlParameter codigo = new SqlParameter("@codigo", SqlDbType.Int);
                codigo.Value = Codigo;
                SqlParameter producto = new SqlParameter("@producto", SqlDbType.VarChar);
                producto.Value = Producto;
                SqlParameter descripcion = new SqlParameter("@descripcion", SqlDbType.VarChar);
                descripcion.Value = Descripcion;
                SqlParameter precio = new SqlParameter("@precio", SqlDbType.Money);
                precio.Value = Precio;
                SqlParameter cantidad = new SqlParameter("@cantidad", SqlDbType.Int);
                cantidad.Value = Cantidad;


                Comando.Parameters.Add(codigo);
                Comando.Parameters.Add(producto);
                Comando.Parameters.Add(descripcion);
                Comando.Parameters.Add(precio);
                Comando.Parameters.Add(cantidad);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "ingresar_articulos";
                Connecion.Open();
                Comando.Connection = Connecion;
                Comando.ExecuteNonQuery();
                Connecion.Close();

            }
            catch (SqlException e)
            {

                throw e;
            }
        }//Fin del metodo Ingresar_Articulo


        public DataTable cargar_articulos()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter consulta = new SqlDataAdapter("select *from articulos where codigo=' " + comboBoxCod.Text + "' ", conn);

                consulta.Fill(dt);

                dataGridArticulos.DataSource = dt;

                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dt;
        }//Fin del metodo cargar_articulos


        public DataTable Insertartabla()
        {
            try
            {
                SqlConnection Coneccion = new SqlConnection(this.connecion);
                SqlCommand Comando = new SqlCommand();
                SqlDataReader leer;
                DataTable tabla = new DataTable();

                Comando.CommandType = CommandType.StoredProcedure;//Para llamar al proceso almacenado
                Comando.CommandText = "Mostrar_Articulos";
                Coneccion.Open();//Abre la conexion
                Comando.Connection = Coneccion;//Hace el puente para llegar a la BD
                leer = Comando.ExecuteReader();
                tabla.Load(leer);
                Coneccion.Close();//Cierra la conexion
                return tabla;

            }
            catch (SqlException e)
            {

                throw e;
            }

        }//Fin del metodo InsertarTabla


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Principal menu = new Menu_Principal("", "");
            menu.Show();
            this.Hide();
        }//Fin del boton volver

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Facturacion fact = new Facturacion();
            fact.Show();
            this.Hide();
        }//Fin del boton facturar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Jalar_Articulos();
            cargar_articulos();
        }//Fin del boton guardar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }//Fin  del boton limpiar

        public void Limpiar()
        {
            this.comboBoxCod.Text = "";
            this.comboBoxCant.Text = "";
            this.textBoxProd.Text = "";
            this.textBoxPrec.Text = "";
            this.textBoxDes.Text = "";
        }//Fin del metodo limpiar

        private void button1_Click(object sender, EventArgs e)//Boton Agregar
        {
            if (textBoxCod.Enabled == true)
            {
                comboBoxCod.Enabled = false;
            }

            if (textBoxCant.Enabled == true)
            {
                comboBoxCant.Enabled = false;
            }

            Insertar_Articulo(int.Parse(textBoxCod.Text), textBoxProd.Text, textBoxDes.Text, int.Parse(textBoxPrec.Text), int.Parse(textBoxCant.Text));
            dataGridArticulos.Rows.Add(int.Parse(textBoxCod.Text), textBoxProd.Text, textBoxDes.Text, int.Parse(textBoxPrec.Text), int.Parse(textBoxCant.Text));
        }//Fin del boton agregar

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter consulta = new SqlDataAdapter("select *from articulos", conn);
                consulta.Fill(dt);
                dataGridArticulos.DataSource = dt;
                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }//Fin del catch

        }//Fin del boton
    }//fin del form Articulos
}//Fin de la solucion
