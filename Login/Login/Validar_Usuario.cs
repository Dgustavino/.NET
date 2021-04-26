using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Login
{
    class Validar_Usuario
    {

        public string conection = "";

        public Validar_Usuario(string conn)//Para pedir el string de conexion
        {
            this.conection = conn;
        }

        public string[] validarIngreso(string usuario, string contraseña)
        {
            string[] Usuario = new string[3];

            try
            {
                SqlConnection Conection = new SqlConnection(this.conection);
                SqlCommand Comando = new SqlCommand("select * from Usuarios where usuario = '"+ usuario +"' and contraseña = '"+ contraseña +"'", Conection);
                
                Conection.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    Usuario[0] = reader["usuario"].ToString();//ToString sirve para convertirlo en texto
                    Usuario[1] = reader["contraseña"].ToString();
                    Usuario[2] = reader["rol"].ToString();
                }

                Conection.Close();

            }//Fin del try
            catch (SqlException ex)
            {
                throw ex;
            }//Fin del catch

            return Usuario;

        }//Fin del metodo





    }//Fin de la clase
}
