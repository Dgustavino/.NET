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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        string varCedula;
        bool varDatos = false;
        bool varMsg = false;
        string varBusqueda = "";
        bool varContinuar = false;
        public Clases.Cliente ClienteSeleccionado { get; set; }
        public Clases.Cliente ClienteActual { get; set; }

        public void Busqueda()
        {
            if (this.txbCedulaExt.MaskCompleted == true && this.txbCedula.MaskCompleted == false)
            {
                varBusqueda = this.txbCedulaExt.Text;
            }
            else if (this.txbCedula.MaskCompleted == true && this.txbCedulaExt.MaskCompleted == false)
            {
                varBusqueda = this.txbCedula.Text;
            }
            else if (this.txbNombre.Text != "")
            {
                varBusqueda = this.txbNombre.Text;
            }
            else if (this.txbApellido.Text != "")
            {
                varBusqueda = this.txbApellido.Text;
            }
            else if (this.txbTelefono.Text != "")
            {
                varBusqueda = this.txbTelefono.Text;
            }
            else if (this.txbDireccion.Text != "")
            {
                varBusqueda = this.txbDireccion.Text;
            }
            else if (this.txbEmail.Text != "")
            {
                varBusqueda = this.txbEmail.Text;
            }
        }//fin de busqueda

        public void Borrar()
        {
            this.txbCedula.Text = "";
            this.txbCedulaExt.Text = "";
            this.txbNombre.Text = "";
            this.txbApellido.Text = "";
            this.txbTelefono.Text = "";
            this.txbDireccion.Text = "";
            this.txbEmail.Text = "";
        }

        public void ValidarCedula()
        {
            if (this.txbCedula.MaskCompleted == false && this.txbCedulaExt.MaskCompleted == false)
            {
                MessageBox.Show("Cédula no cumple con formato.", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                varMsg = true;
            }
            else if (this.txbCedulaExt.MaskCompleted == true && this.txbCedula.MaskCompleted == false)
            {
                varCedula = this.txbCedulaExt.Text;
                varContinuar = true;
            }
            else if (this.txbCedula.MaskCompleted == true && this.txbCedulaExt.MaskCompleted == false)
            {
                varCedula = this.txbCedula.Text;
                varContinuar = true;
            }
        }

        public void ValidarResto()
        {
            if (varContinuar == true)
            {
                if (txbNombre.Text != "") //validar Nombre
                {
                    if (txbApellido.Text != "") //validar Apellido
                    {
                        if (txbApellido.Text != "") //validar Apellido
                        {
                            if (this.txbTelefono.Text.Any(x => char.IsNumber(x))) //valida telefono
                            {
                                if (txbEmail.Text != "") //validar Apellido
                                {
                                    if (txbDireccion.Text != "") //validar Apellido
                                    {
                                        varDatos = true; 
                                    }
                                }
                            }
                        }
                    }
                }
            }
           
        } // fin de validar

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ValidarCedula();
            ValidarResto();
            if (varDatos == true)
            {
                Clases.Cliente Cliente = new Clases.Cliente();
                Cliente.Cedula = varCedula;
                Cliente.Nombre = txbNombre.Text;
                Cliente.Apellido = txbApellido.Text;
                Cliente.Telefono = txbTelefono.Text;
                Cliente.Direccion = txbDireccion.Text;
                Cliente.Email = txbEmail.Text;

                int resultado = ClientesMetodos.m_AgregarCliente(Cliente);
                if (resultado > 0)
                {
                    MessageBox.Show("Datos guardados correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borrar();
                }
                else
                {
                    MessageBox.Show("Datos no se guardaron", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            } //Fin de Validar los datos
            else
            if (varMsg == false)
            {
                MessageBox.Show("Validando", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //Fin del Click insertar

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Clases.Cliente pCliente = new Clases.Cliente();
            
            pCliente.Nombre = txbNombre.Text;
            pCliente.Apellido = txbApellido.Text;
            pCliente.Telefono = txbTelefono.Text; 
            pCliente.Direccion = txbDireccion.Text;
            pCliente.Email = txbEmail.Text;

            ValidarCedula();
            pCliente.Cedula = varCedula;

            int resultado = ClientesMetodos.m_ModificarCliente(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente modificado con éxito", "Cambiar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Borrar();
            }
            else
            {
                MessageBox.Show("No se modificó cliente", "Error al cambiar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvBusqueda.Refresh();

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txbCedula.Visible = true;
            txbCedulaExt.Visible = false;
            txbNombre.Enabled = true;
            txbApellido.Enabled = true;
            txbTelefono.Enabled = true;
            txbEmail.Enabled = true;
            txbDireccion.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txbCedulaExt.Visible = true;
            txbCedula.Visible = false;
            txbNombre.Enabled = true;
            txbApellido.Enabled = true;
            txbTelefono.Enabled = true;
            txbEmail.Enabled = true;
            txbDireccion.Enabled = true;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void imgBuscar_Click(object sender, EventArgs e)
        {
            Busqueda();
            dgvBusqueda.DataSource = ClientesMetodos.m_BuscarCliente(varBusqueda);
            Borrar();
        }

        private void imgEliminar_Click(object sender, EventArgs e)
        {
            if (this.txbCedula.MaskCompleted == true || this.txbCedulaExt.MaskCompleted == true)
            {
                if (MessageBox.Show("Está seguro de eliminar el Cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = ClientesMetodos.EliminarCliente(ClienteActual.Cedula);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente eliminado con éxito", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó cliente", "Error al eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Se canceló la eliminación", "Cancelado");
                }
            }
        }


        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBusqueda.SelectedRows.Count == 1)
            {
                string Cedula = Convert.ToString(dgvBusqueda.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClientesMetodos.ObtenerCliente(Cedula);

                if (ClienteSeleccionado != null)
                {
                    ClienteActual = ClienteSeleccionado;
                    txbNombre.Text = ClienteSeleccionado.Nombre;
                    txbApellido.Text = ClienteSeleccionado.Apellido;
                    txbTelefono.Text = ClienteSeleccionado.Telefono;
                    txbDireccion.Text = ClienteSeleccionado.Direccion;
                    txbEmail.Text = ClienteSeleccionado.Email;

                    if (ClienteSeleccionado.Cedula.Length > 11)
                    {
                        radioButton2.Checked = true;
                        txbCedulaExt.Text = ClienteSeleccionado.Cedula;
                    }
                    else
                    {
                        radioButton1.Checked = true;
                        txbCedula.Text = ClienteSeleccionado.Cedula;
                    }
                    
                    dgvBusqueda.Refresh();
                }

            }

        }

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }// fin de dgvBusqueda_CellClick

       
    }
}
