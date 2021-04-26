using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //sirve para utilizar recursos de bases de datos
using System.Data.SqlClient; // se especifica que va a utilizar SQL 

namespace WAProyectoChiyiStore
{
    public class ProductosMetodos
    {
        public string connecion = "Data Source=CUIS-PC;Initial Catalog= Chiyi;Integrated Security = True"; //esto es un constructor
        public ProductosMetodos(string conn) //esto es un constructor
        {
            this.connecion = conn;
        }

        public void m_IngresarProducto(string Producto, string Descripcion, string Categoria, string Precio)
        {

            try
            {

                SqlConnection Connecion = new SqlConnection(this.connecion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter producto = new SqlParameter("@Producto", SqlDbType.NVarChar);
                producto.Value = Producto;

                SqlParameter descripcion = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
                descripcion.Value = Descripcion;

                SqlParameter categoria = new SqlParameter("@Categoria", SqlDbType.NVarChar);
                categoria.Value = Categoria;

                SqlParameter precio = new SqlParameter("@Precio", SqlDbType.Int);
                precio.Value = Precio;

                Comando.Parameters.Add(producto);
                Comando.Parameters.Add(descripcion);
                Comando.Parameters.Add(categoria);
                Comando.Parameters.Add(precio);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "spIngresarProductos";
                Connecion.Open();
                Comando.Connection = Connecion;
                Comando.ExecuteNonQuery();
                Connecion.Close();

            } // fin de try

            catch (SqlException e)
            {
                throw e; //va a mostrar el aviso en el throw
            }

        } // fin de m_IngresarProducto


        public void m_ModificarProducto(string Producto, string Descripcion, string Categoria, string Precio)
        {

            try
            {

                SqlConnection Connecion = new SqlConnection(this.connecion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter producto = new SqlParameter("@Producto", SqlDbType.NVarChar);
                producto.Value = Producto;

                SqlParameter descripcion = new SqlParameter("@Descripcion", SqlDbType.NVarChar);
                descripcion.Value = Descripcion;

                SqlParameter categoria = new SqlParameter("@Categoria", SqlDbType.NVarChar);
                categoria.Value = Categoria;

                SqlParameter precio = new SqlParameter("@Precio", SqlDbType.Int);
                precio.Value = Precio;

                Comando.Parameters.Add(producto);
                Comando.Parameters.Add(descripcion);
                Comando.Parameters.Add(categoria);
                Comando.Parameters.Add(precio);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandText = "spModificarProductos";
                Connecion.Open();
                Comando.Connection = Connecion;
                Comando.ExecuteNonQuery();
                Connecion.Close();

            } // fin de try

            catch (SqlException e)
            {
                throw e; //va a mostrar el aviso en el throw
            }

        } // fin de m_ModificarProducto

        public static List<Clases.Producto> m_BuscarProducto(String pProducto)
        {
            List<Clases.Producto> Lista = new List<Clases.Producto>();
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand Comando = new SqlCommand(string.Format(
                    "Select Producto, Descripcion, b.Categoria, cast(Precio as varchar) as Precio from Productos as a left join CategoriasProductos as b on a.IdCategoria = b.IdCategoria where Producto like '%{0}%' or Descripcion like '%{0}%' or b.Categoria like '%{0}%' or Precio like '%{0}%' ", pProducto), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Clases.Producto ListaProducto = new Clases.Producto();
                    ListaProducto.Product = reader.GetString(0);
                    ListaProducto.Descripcion = reader.GetString(1);
                    ListaProducto.Categoria = reader.GetString(2);
                    ListaProducto.Precio = reader.GetString(3);
                    Lista.Add(ListaProducto);
                }
                conexion.Close();
                return Lista;
            }
        }

        public static Clases.Producto ObtenerProducto(String pProducto)
        {
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                Clases.Producto pProduct = new Clases.Producto();
                SqlCommand Comando = new SqlCommand(string.Format(
                    "Select Producto, Descripcion, b.Categoria, cast(Precio as varchar) as Precio from Productos as a left join CategoriasProductos as b on a.idCategoria = b.idCategoria where Producto = '{0}' ", pProducto), conexion);
                conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    pProduct.Product = reader.GetString(0);
                    pProduct.Descripcion = reader.GetString(1);
                    pProduct.Categoria = reader.GetString(2);
                    pProduct.Precio = reader.GetString(3);

                }
                conexion.Close();
                return pProduct;
            }
        }


        public static int EliminarProducto(string pProducto)
        {
            int retorno = 0;
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format("Delete from Productos where Producto = '{0}'", pProducto), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

    } //fin de clase ProductosMetodos
}
