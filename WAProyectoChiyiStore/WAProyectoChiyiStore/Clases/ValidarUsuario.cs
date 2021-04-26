using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAProyectoChiyiStore
{
    public class ValidarUsuario
    {

        public string conection = "";

        //constructor de la Clase
        public ValidarUsuario(string conn)
        {
            this.conection = conn;
        }

        public string[] m_ValidarIngreso(string usuario, string clave){
            string[] Usuario = new string[4];
            try{
            SqlConnection Conection = new SqlConnection(this.conection);
                SqlCommand Comando = new SqlCommand("select Usuario, Clave, Rol, Nombre from Usuarios where Usuario = '"+ usuario +"' and Clave = '" + clave + "'",Conection );

            Conection.Open();
            SqlDataReader reader = Comando.ExecuteReader();

            if (reader.Read()){
                Usuario[0] = reader["Usuario"].ToString();
                Usuario[1] = reader["Clave"].ToString();
                Usuario[2] = reader["Rol"].ToString();
                Usuario[3] = reader["Nombre"].ToString();
            }

                Conection.Close();
            }
            catch(SqlException ex){
                throw ex;
            }
            return Usuario;


        }//fin de m_ValidarIngreso

    } // fin de clase
}
