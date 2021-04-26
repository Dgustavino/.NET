using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAProyectoChiyiStore.Clases
{
    class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection Conn = new SqlConnection("Data source=CUIS-PC; Initial Catalog=CHIYI; User Id= AdminMascota; Password= abc123 ");
                return Conn;
            }
            catch (SqlException e)
            {
                throw e; //va a mostrar el aviso en el throw
            }
        }
    }
}
