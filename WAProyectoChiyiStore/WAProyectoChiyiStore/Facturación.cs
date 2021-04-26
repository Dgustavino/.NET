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

namespace WAProyectoChiyiStore
{
    public partial class Facturación : Form
    {

        SqlConnection conexion = new SqlConnection("Data Source=CUIS-PC;Initial Catalog= Chiyi;Integrated Security = True");
        double varSubTotal = 0;
        double varImpuesto13 = 0;
        double varImpuesto7 = 0;
        double varTotal = 0;
        int varNuevaFactura = 1;
        string varTipoPago = "";
        int varIdCompra = 0;

        public Facturación()
        {
            InitializeComponent();
            
         //Cargar número de factura
            string[] Facturar = new string[100];

            string query = "SELECT cast(max(IdFactura)+1 as varchar) as IdFactura FROM dbo.Factura ";
            SqlCommand cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                Facturar[0] = leer["IdFactura"].ToString();
            }
            conexion.Close();
            lblNumFactura.Text = Facturar[0];

         //Cargar lista de clientes
            DataTable dt = new DataTable();
            query = "SELECT Nombre+' '+Apellido as Nombre FROM dbo.Clientes Order by Nombre";
            cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            cbxCliente.DisplayMember = "Nombre";
            cbxCliente.ValueMember = "id";
            cbxCliente.DataSource = dt;
            conexion.Close();
 
        //Cargar lista de productos
            DataTable dtprod = new DataTable();
            query = "SELECT Producto FROM dbo.Productos Order by Producto";
            cmd = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataAdapter readerProductos = new SqlDataAdapter(cmd);
            readerProductos.Fill(dtprod);

            cbxProductos.DisplayMember = "Producto";
            cbxProductos.ValueMember = "id";
            cbxProductos.DataSource = dtprod;
            conexion.Close();



        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //cambios en el Combo de Nombre
        private void cbxCliente_SelectedValueChanged(object sender, EventArgs e )  
        {
            string query = "SELECT Cedula FROM dbo.Clientes Where Nombre+' '+Apellido ='"+cbxCliente.Text+"' ";
            SqlCommand cmd = new SqlCommand(query, conexion);
            if (conexion != null && conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            SqlDataReader leer = cmd.ExecuteReader();
            
            if (leer.Read()){
                txbCedula.Text = leer["Cedula"].ToString();
            }
            conexion.Close();

            if (cbxCliente.Text != " ")
            {
                gbxProductos.Enabled = true;
                gbxTotales.Enabled = true;
                gbxtipocompra.Enabled = true;
                rbtEfectivo.Checked = true;
                btnImprimir.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            else
            {
                gbxProductos.Enabled = false;
                gbxTotales.Enabled = false;
                gbxtipocompra.Enabled = false;
                rbtEfectivo.Checked = false;
                btnImprimir.Enabled = false;
                btnLimpiar.Enabled = false;
            }
            
        }

        //botón de agregar productos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            //verificar que exista un producto
            if (cbxProductos.Text != "" && cbxCantidad.Text != "")
            {
                //tipo de pago
                if (rbtEfectivo.Checked == true)
                {
                    varTipoPago = "Efectivo";
                    gbxtipocompra.Enabled = false;
                }
                else 
                {
                    varTipoPago = "Tarjeta";
                    gbxtipocompra.Enabled = false;
                }
                
                //deshabilitar controles
                gbxtipocompra.Enabled = false;
                cbxCliente.Enabled = false;
                
                //verificar si se trata de una factura nueva o la misma
                if (varNuevaFactura == 1)
                {
                    IngresarNuevaFatura();
                }

                //Acciones principales
                IngresarCompra();
                TraerDetalleCompra();
                ConsultarSubTotal();

                //habilitar controles
                btnComprar.Enabled = true;

                //calcular totales
                varImpuesto13 = varSubTotal * 0.13;
                varImpuesto7 = varSubTotal * 0.07;
                if (rbtTarjeta.Checked == true)
                {
                    varTotal = varSubTotal + varImpuesto13 + varImpuesto7;
                    txbImpuesto7.Enabled = true;
                }
                else
                {
                    varTotal = varSubTotal + varImpuesto13;
                    txbImpuesto7.Enabled = false;
                }

                txbSubTotal.Text = Convert.ToString(varSubTotal);
                txbImpuesto13.Text = Convert.ToString(varImpuesto13);
                txbImpuesto7.Text = Convert.ToString(varImpuesto7);
                txbTotal.Text = Convert.ToString(varTotal);
      
                //actualizar el salod de la factura
                ActualizarSaldoFactura();


            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra Exitosa", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }


        //Ingresar Factura nueva
        public void IngresarNuevaFatura()
        {
            Clases.Factura NuevaFactura = new Clases.Factura();
                    NuevaFactura.IdFactura = lblNumFactura.Text;
                    NuevaFactura.FechaFactura = Convert.ToDateTime(dtpFecha.Text);
                    NuevaFactura.Cedula = txbCedula.Text;
                    NuevaFactura.Saldo = txbTotal.Text;
                    NuevaFactura.TipoPago = varTipoPago;

                    int resultado = Clases.Facturacion.m_AgregarFactura(NuevaFactura);
                    if (resultado > 0)
                    {
                        varNuevaFactura = varNuevaFactura + 1;
                    }
                    else
                    {
                        MessageBox.Show("No se puede facturar", "Error al facturar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        //Ingresar Compra
        public void IngresarCompra()
        {
            Clases.Compra NuevaCompra = new Clases.Compra();
            NuevaCompra.IdFactura = lblNumFactura.Text;
            NuevaCompra.IdProducto = cbxProductos.Text;
            NuevaCompra.Cantidad = cbxCantidad.Text;
            NuevaCompra.Precio = "";

            int resultado = Clases.CompraMetodos.m_AgregarCompra(NuevaCompra);
            if (resultado > 0)
            {
                varIdCompra = varIdCompra + 1;
                cbxProductos.Text = "";
                cbxCantidad.Text = "";

            }
            else
            {
                MessageBox.Show("No se puede comprar", "Error al comprar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //traernos el detalle de compra

        public void TraerDetalleCompra()
        {
            dgvProductos.DataSource = Clases.CompraMetodos.m_BuscarCompras(lblNumFactura.Text);
        }

        public void ConsultarSubTotal()
        {
            string query = "SELECT cast(sum(total) as int) as SubTotal FROM dbo.v_Compra Where IdFactura ='" + lblNumFactura.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, conexion);
            if (conexion != null && conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            SqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                varSubTotal = Convert.ToDouble( leer["SubTotal"]);
            }
            conexion.Close();

        }

        public void ActualizarSaldoFactura()
        {
            Clases.ActSaldo pSaldoFactura = new Clases.ActSaldo();

            pSaldoFactura.Saldo = txbTotal.Text;
            pSaldoFactura.IdFactura = lblNumFactura.Text;
            int resultado = Clases.Facturacion.m_ModificarSaldo(pSaldoFactura);

        }



    }
}
