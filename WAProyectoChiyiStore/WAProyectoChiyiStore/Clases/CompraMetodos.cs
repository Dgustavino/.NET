using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAProyectoChiyiStore.Clases
{
    public class CompraMetodos
    {
        public string connecion = ""; //esto es un constructor
        public CompraMetodos(string conn) //esto es un constructor
        {
            this.connecion = conn;
        }

        public static int m_AgregarCompra(Clases.Compra pCompra)
        {
            try
            {
                int Retorno = 0;
                using (SqlConnection conn = Clases.ConexionBD.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand();

                    SqlParameter idfactura = new SqlParameter("@IdFactura", SqlDbType.NVarChar);
                    idfactura.Value = pCompra.IdFactura;

                    SqlParameter idproducto = new SqlParameter("@IdProducto", SqlDbType.NVarChar);
                    idproducto.Value = pCompra.IdProducto;

                    SqlParameter cantidad = new SqlParameter("@Cantidad", SqlDbType.Int);
                    cantidad.Value = pCompra.Cantidad;

                    SqlParameter precio = new SqlParameter("@Precio", SqlDbType.NVarChar);
                    precio.Value = pCompra.Precio;

                    Comando.Parameters.Add(idfactura);
                    Comando.Parameters.Add(idproducto);
                    Comando.Parameters.Add(cantidad);
                    Comando.Parameters.Add(precio);

                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.CommandText = "spIngresarCompra";
                    conn.Open();
                    Comando.Connection = conn;
                    Retorno = Comando.ExecuteNonQuery();
                    conn.Close();
                }
                return Retorno;
            }
            catch (SqlException e)
            {
                throw e; //va a mostrar el aviso en el throw
            }

        }// fin de agregar compra

        //Método Buscar Cliente
        public static List<Clases.DetalleCompra> m_BuscarCompras(String pCompra)
        {
            List<Clases.DetalleCompra> Lista = new List<Clases.DetalleCompra>();
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand Comando = new SqlCommand(string.Format(
                    "Select Producto, Descripcion, cast(Precio as varchar) as Precio, Cast(Cantidad as varchar) as Cantidad, Cast(Total as varchar) as Total from v_Compra where IdFactura = '{0}' ", pCompra), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Clases.DetalleCompra ListaCompras = new Clases.DetalleCompra();
                    ListaCompras.Producto = reader.GetString(0);
                    ListaCompras.Descripcion = reader.GetString(1);
                    ListaCompras.Precio = reader.GetString(2);
                    ListaCompras.Cantidad = reader.GetString(3);
                    ListaCompras.Total = reader.GetString(4);
                    Lista.Add(ListaCompras);
                }
                conexion.Close();
                return Lista;
            }
        }



    }
}
