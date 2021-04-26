using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Store_Costa_Rica
{
     class Validar_Usuario
    {
         public string conection = "";

         public Validar_Usuario(string conn) 
         {
             this.conection = conn;
         }//constructor

         public string[] ValidarIngreso(string usuario, string contraseña) 
         {
             string[] Usuario = new string[3];

             try
             {
                 SqlConnection Conection = new SqlConnection(this.conection);
                 SqlCommand Comando = new SqlCommand("select * from Usuarios where usuario ='"+ usuario +"' and contraseña = '"+ contraseña +"'",Conection);

                 Conection.Open();

                 SqlDataReader reader = Comando.ExecuteReader();

                 if (reader.Read())
                 {
                     Usuario[0] = reader["usuario"].ToString();//ToString sirve para convertirlo en texto
                     Usuario[1] = reader["contraseña"].ToString();
                     Usuario[2] = reader["rol"].ToString();
                 }//Fin del If

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
