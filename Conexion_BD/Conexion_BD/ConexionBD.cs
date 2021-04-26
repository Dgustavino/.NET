using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias para String de conexion
using System.Data;//Para uso de la BD
using System.Data.SqlClient;//Para Usar sentencias de BD


namespace Conexion_BD
{
   public class ConexionBD
    {
       public string connecion = ""; //Constructor 
       public ConexionBD(string conn)
       {
           this.connecion = conn;
       }

        public void ingresar_cliente(int Numero_Cedula, string Nombre, string Apellidos, string Direccion, string Telefono, string Correo)//Se pusieron string para poderlos jalar del TexBox; Si se pusieran int tendrian que parsearse(Convertir).
        {
            try
            {
                SqlConnection Coneccion = new SqlConnection(this.connecion);//SqlConnection sale de la libreria .Data
                SqlCommand Comando = new SqlCommand();//Para usar comandos de sql

                SqlParameter numero_cedula = new SqlParameter("@numero_cedula", SqlDbType.Int);//Parametros; con el SqlDbTye lo convierte al dato que quiero.
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

                Comando.CommandType = CommandType.StoredProcedure;//Para llamar al proceso almacenado
                Comando.CommandText = "ingresar_cliente";
                Coneccion.Open();//Abre la conexion
                Comando.Connection = Coneccion;//Hace el puente para llegar a la BD
                Comando.ExecuteNonQuery();//Se ejecuta el procedimiento almacenado
                Coneccion.Close();//Cierra la conexion

            }//Fin del Try
            catch (SqlException e)
            {
                throw e;//Este throw e se usa por parte del desarollador para evitar el mensaje de error cuando esta probando la aplicacion en busca de errores.
                        //Cuando la aplicacion sea para el usuario si tiene que mostrar mensaje en el momento de la ejecucion
            }//Fin del catch
        }

         public void Insertar_Producto(int Codigo_Producto, string Costo, string Descripcion)
         {
            try
            {
                SqlConnection Connecion = new SqlConnection(this.connecion);
                SqlCommand Comando = new SqlCommand();

                SqlParameter codigo_producto = new SqlParameter("@codigo_producto",SqlDbType.Int);
                codigo_producto.Value = Codigo_Producto;
                SqlParameter costo = new SqlParameter("@money", SqlDbType.Money);
                costo.Value = Costo;
                SqlParameter descripcion = new SqlParameter("@descripcion", SqlDbType.Int);
                descripcion.Value = Descripcion;


                Comando.Parameters.Add(codigo_producto);
                Comando.Parameters.Add(costo);
                Comando.Parameters.Add(descripcion);

                Comando.CommandType = CommandType.StoredProcedure;//Para llamar al proceso almacenado
                Comando.CommandText = "Insertar_Producto";
                Connecion.Open();//Abre la conexion
                Comando.Connection = Connecion;//Hace el puente para llegar a la BD
                Comando.ExecuteNonQuery();//Se ejecuta el procedimiento almacenado
                Connecion.Close();//Cierra la conexion

            }
            catch (SqlException e )
            {

                throw e;
            }
        }//Fin del metodo Ingresar_Producto


         public void Actualizar_Cliente(int Numero_Cedula, string Nombre, string Apellidos, string Direccion, string Telefono, string Correo)
         {

             try
             {
                 SqlConnection Coneccion = new SqlConnection(this.connecion);//SqlConnection sale de la libreria .Data
                 SqlCommand Comando = new SqlCommand();//Para usar comandos de sql

                 SqlParameter numero_cedula = new SqlParameter("@numero_cedula", SqlDbType.Int);//Parametros; con el SqlDbTye lo convierte al dato que quiero.
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

                 Comando.CommandType = CommandType.StoredProcedure;//Para llamar al proceso almacenado
                 Comando.CommandText = "actualizar_cliente";
                 Coneccion.Open();//Abre la conexion
                 Comando.Connection = Coneccion;//Hace el puente para llegar a la BD
                 Comando.ExecuteNonQuery();//Se ejecuta el procedimiento almacenado
                 Coneccion.Close();//Cierra la conexion

             }
             catch (SqlException e)
             {

                 throw e;
             }

         }//Fin del metodo Actualizar

         public void Borrar_Cliente(int Numero_Cedula) 
         {
             try
             {
                 SqlConnection Coneccion = new SqlConnection(this.connecion);//SqlConnection sale de la libreria .Data
                 SqlCommand Comando = new SqlCommand();//Para usar comandos de sql

                 SqlParameter numero_cedula = new SqlParameter("@numero_cedula", SqlDbType.Int);//Parametros; con el SqlDbTye lo convierte al dato que quiero.
                 numero_cedula.Value = Numero_Cedula;

                 Comando.Parameters.Add(numero_cedula);

                 Comando.CommandType = CommandType.StoredProcedure;//Para llamar al proceso almacenado
                 Comando.CommandText = "borrar_cliente";
                 Coneccion.Open();//Abre la conexion
                 Comando.Connection = Coneccion;//Hace el puente para llegar a la BD
                 Comando.ExecuteNonQuery();//Se ejecuta el procedimiento almacenado
                 Coneccion.Close();//Cierra la conexion
             }
             catch (SqlException e)
             {
                 
                 throw e;
             }
         }//Fin de la clase Borrar

       }//Fin de la clase conexionBD

    }//Fin del namespace

