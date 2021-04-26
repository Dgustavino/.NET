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

namespace Ej_Report_Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Limpiar()            //Otra forma del limpiar los texbox es texbox1.Clear();
        {
            this.textBoxID.Text = "";
            this.label1.Text = "";
        }

        public void InsertarID()
        {
            string stringConnection = "Data source=CT-LB3-16\\SQL2016;Initial Catalog=ID;Integrated Security=True";
            SqlConnection ObjConn = new SqlConnection(stringConnection);
            try
            {
                SqlCommand ObjCom = new SqlCommand();

                SqlParameter Nombre = new SqlParameter("@Nombre", SqlDbType.VarChar);
                Nombre.Value = this.textBoxID.Text;

                ObjCom.Parameters.Add(Nombre);

                ObjCom.CommandType = CommandType.StoredProcedure;
                ObjCom.CommandText = "Insertar_ID";
                ObjConn.Open();
                ObjCom.Connection = ObjConn;
                ObjCom.ExecuteNonQuery();

            }//Fin del try
            catch (SqlException ex)
            {
                throw ex;
            }//Fin del catch
            finally
            {
                if (ObjConn.State == ConnectionState.Open)
                {
                    ObjConn.Close();
                }
            }//Fin del finally
        }//Fin del metodo

        public void numero()//Este metodo se mete en el initialComponent para que genere el consecutivo sin necesidad de accionar un boton
        {
            string stringConnection = "Data source=CT-LB3-16\\SQL2016;Initial Catalog=ID;Integrated Security=True";
            SqlConnection ObjConn = new SqlConnection(stringConnection);
            try
            {
                SqlCommand ObjCom = new SqlCommand();

                ObjCom.CommandType = CommandType.StoredProcedure;
                ObjCom.CommandText = "Numero_ID";
                ObjConn.Open();
                ObjCom.Connection = ObjConn;

                SqlDataReader ObjReader = ObjCom.ExecuteReader();
                if (ObjReader.Read())
                {
                    this.label1.Text = ObjReader["Numero"].ToString();
                }

            }//Fin del try
            catch (SqlException ex)
            {
                MessageBox.Show("No se encuentra el cliente" + ex);
            }//Fin del catch
            finally
            {
                if (ObjConn.State == ConnectionState.Open)
                {
                    ObjConn.Close();
                }
            }//Fin del finally

        }//Fin del metodo   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            InsertarID();
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numero();
        }
    }//Fin del form

}//Fin de la solucion
