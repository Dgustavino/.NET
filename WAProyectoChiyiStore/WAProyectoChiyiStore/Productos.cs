using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WAProyectoChiyiStore
{
    public partial class Productos : Form
    {

        ProductosMetodos conn = new ProductosMetodos("Data Source=CUIS-PC;Initial Catalog= Chiyi;Integrated Security = True");
        public Clases.Producto ProductoSeleccionado { get; set; }
        public Clases.Producto ProductoActual { get; set; }

        string varBusqueda = "";
        
        public Productos()
        {
            InitializeComponent();
            SqlConnection conMenu = new SqlConnection("Data Source=CUIS-PC;Initial Catalog= Chiyi;Integrated Security = True");

            DataTable dt = new DataTable();
            string query = "SELECT Categoria FROM dbo.CategoriasProductos order by categoria";
            SqlCommand cmd = new SqlCommand(query, conMenu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cbxCategoria.DisplayMember = "Categoria";
            cbxCategoria.ValueMember = "id";
            cbxCategoria.DataSource = dt;    
        }

        public void Busqueda()
        {
            if (this.txbProducto.Text != "")
            {
                varBusqueda = this.txbProducto.Text;
            }
            else if (this.txbDescripcion.Text != "")
            {
                varBusqueda = this.txbDescripcion.Text;
            }
            else if (this.txbPrecio.Text != "")
            {
                varBusqueda = this.txbPrecio.Text;
            }
            else if (this.cbxCategoria.Text != "")
            {
                varBusqueda = this.cbxCategoria.Text;
            }
            
        }//fin de busqueda

        private void imgBuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
            dgvProductos.DataSource = ProductosMetodos.m_BuscarProducto(varBusqueda);
            Borrar();
        }
        

        public void Borrar()
        {
            this.txbProducto.Text = "";
            this.cbxCategoria.Text = "";
            this.txbPrecio.Text = "";
            this.txbDescripcion.Text = "";
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.m_IngresarProducto(txbProducto.Text, txbDescripcion.Text, cbxCategoria.Text, txbPrecio.Text);
                MessageBox.Show("Producto agregado.", "Nuevo Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Borrar();
            }
            catch
            {
                MessageBox.Show("No se agregó Producto", "Error al agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.m_ModificarProducto(txbProducto.Text, txbDescripcion.Text, cbxCategoria.Text, txbPrecio.Text);
                MessageBox.Show("Producto modificado con éxito", "Cambiar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Borrar();
            }
            catch
            {
                MessageBox.Show("No se modificó Producto", "Error al cambiar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 1)
            {
                string miProducto = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = ProductosMetodos.ObtenerProducto(miProducto);

                if (ProductoSeleccionado != null)
                {
                    ProductoActual = ProductoSeleccionado;
                    txbProducto.Text = ProductoSeleccionado.Product;
                    txbDescripcion.Text = ProductoSeleccionado.Descripcion;
                    txbPrecio.Text= ProductoSeleccionado.Precio;
                    //txbPrecio.Text = txbPrecio2.Text.Substring(1 , (txbPrecio2.Text.Length)-2);
                    cbxCategoria.Text = ProductoSeleccionado.Categoria;

                    dgvProductos.Refresh();
                }


            }

        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            if (this.txbProducto.Text != "")
            {
                if (MessageBox.Show("Está seguro de eliminar este Producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = ProductosMetodos.EliminarProducto(ProductoActual.Product);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto eliminado con éxito", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó Producto", "Error al eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Se canceló la eliminación", "Cancelado");
                }
            }
        }// fin de dgvBusqueda_CellClick

        

        
      
    }
}
