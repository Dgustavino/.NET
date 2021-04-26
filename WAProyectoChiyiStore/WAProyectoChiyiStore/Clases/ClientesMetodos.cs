using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WAProyectoChiyiStore
{
    public class ClientesMetodos
    {
         public string connecion = ""; //esto es un constructor
         public ClientesMetodos(string conn) //esto es un constructor
        {
            this.connecion = conn;
        }

         public static int m_AgregarCliente(Clases.Cliente pCliente)
         {
             try
             {
                 int Retorno = 0;
                 using (SqlConnection conn = Clases.ConexionBD.ObtenerConexion())
                 {
                     SqlCommand Comando = new SqlCommand();

                     SqlParameter cedula = new SqlParameter("@Cedula", SqlDbType.NVarChar);
                     cedula.Value = pCliente.Cedula;

                     SqlParameter nombre = new SqlParameter("@Nombre", SqlDbType.NVarChar);
                     nombre.Value = pCliente.Nombre;

                     SqlParameter apellido = new SqlParameter("@Apellido", SqlDbType.NVarChar);
                     apellido.Value = pCliente.Apellido;

                     SqlParameter telefono = new SqlParameter("@Telefono", SqlDbType.Int);
                     telefono.Value = pCliente.Telefono;

                     SqlParameter direccion = new SqlParameter("@Direccion", SqlDbType.NVarChar);
                     direccion.Value = pCliente.Direccion;

                     SqlParameter email = new SqlParameter("@Email", SqlDbType.NVarChar);
                     email.Value = pCliente.Email;

                     Comando.Parameters.Add(cedula);
                     Comando.Parameters.Add(nombre);
                     Comando.Parameters.Add(apellido);
                     Comando.Parameters.Add(telefono);
                     Comando.Parameters.Add(direccion);
                     Comando.Parameters.Add(email);

                     Comando.CommandType = CommandType.StoredProcedure;
                     Comando.CommandText = "spIngresarCliente";
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

         }// fin de agregar cliente


        public static int m_ModificarCliente(Clases.Cliente pCliente)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
                {   conexion.Open(); 
                    SqlCommand comando = new SqlCommand(string.Format("update Clientes set Nombre = '{0}',Apellido = '{1}', Telefono = '{2}', Direccion = '{3}', Email = '{4}' where cedula = '{5}'",
                    pCliente.Nombre, pCliente.Apellido, pCliente.Telefono, pCliente.Direccion, pCliente.Email, pCliente.Cedula), conexion);
                    retorno = comando.ExecuteNonQuery();
                    conexion.Close(); 
                }
            } // fin de try
            catch (SqlException e)
            {
                throw e; //va a mostrar el aviso en el throw
            }
            return retorno;
        } // fin de m_IngresarCliente


        //Método Buscar Cliente
        public static List<Clases.Cliente> m_BuscarCliente(String pCliente)
        {
            List<Clases.Cliente> Lista = new List<Clases.Cliente>();
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand Comando = new SqlCommand(string.Format(
                    "Select Cedula, Nombre, Apellido, cast(Telefono as varchar) as Telefono, Direccion, Email from Clientes where Cedula like '%{0}%' or nombre like '%{0}%' or apellido like '%{0}%' or direccion like '%{0}%' or telefono like '%{0}%' or Email like '%{0}%' ", pCliente), conexion);
                SqlDataReader reader = Comando.ExecuteReader();

                while (reader.Read())
                {
                    Clases.Cliente ListaCliente = new Clases.Cliente();
                    ListaCliente.Cedula = reader.GetString(0);
                    ListaCliente.Nombre = reader.GetString(1);
                    ListaCliente.Apellido = reader.GetString(2);
                    ListaCliente.Telefono = reader.GetString(3);
                    ListaCliente.Direccion = reader.GetString(4);
                    ListaCliente.Email = reader.GetString(5);
                    Lista.Add(ListaCliente);
                }
                conexion.Close();
                return Lista;
            }
        }


        public static Clases.Cliente ObtenerCliente(String pCedula)
        {
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                Clases.Cliente pCliente = new Clases.Cliente();
                SqlCommand Comando = new SqlCommand(string.Format(
                    "Select Cedula, Nombre, Apellido, cast(Telefono as varchar) as Telefono, Direccion, Email from Clientes where Cedula = '{0}' ", pCedula), conexion);
                conexion.Open();
                SqlDataReader reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    pCliente.Cedula = reader.GetString(0);
                    pCliente.Nombre = reader.GetString(1);
                    pCliente.Apellido = reader.GetString(2);
                    pCliente.Telefono = reader.GetString(3);
                    pCliente.Direccion = reader.GetString(4);
                    pCliente.Email = reader.GetString(5);
                }
                conexion.Close();
                return pCliente;
            }
        }

        public static int EliminarCliente(string pCedula)
        {
            int retorno = 0;
            using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(string.Format("Delete from Clientes where cedula = '{0}'", pCedula), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }



    }
}
