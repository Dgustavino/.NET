using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WAProyectoChiyiStore.Clases
{
    public class Facturacion
    {
        public string connecion = ""; //esto es un constructor
        public Facturacion(string conn) //esto es un constructor
        {
            this.connecion = conn;
        }

        public static int m_AgregarFactura(Clases.Factura pFactura)
        {
            try
            {
                int Retorno = 0;
                using (SqlConnection conn = Clases.ConexionBD.ObtenerConexion())
                {
                    SqlCommand Comando = new SqlCommand();

                    SqlParameter idfactura = new SqlParameter("@IdFactura", SqlDbType.NVarChar);
                    idfactura.Value = pFactura.IdFactura;

                    SqlParameter fechafactura = new SqlParameter("@FechaFactura", SqlDbType.DateTime);
                    fechafactura.Value = pFactura.FechaFactura;

                    SqlParameter cedula = new SqlParameter("@Cedula", SqlDbType.NVarChar);
                    cedula.Value = pFactura.Cedula;

                    SqlParameter saldo = new SqlParameter("@Saldo", SqlDbType.NVarChar);
                    saldo.Value = pFactura.Saldo;

                    SqlParameter tipopago = new SqlParameter("@TipoPago", SqlDbType.NVarChar);
                    tipopago.Value = pFactura.TipoPago;

                    Comando.Parameters.Add(idfactura);
                    Comando.Parameters.Add(fechafactura);
                    Comando.Parameters.Add(cedula);
                    Comando.Parameters.Add(saldo);
                    Comando.Parameters.Add(tipopago);

                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.CommandText = "spIngresarFactura";
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

        }// fin de agregar factura


        public static int m_ModificarSaldo(Clases.ActSaldo pSaldoFinal)
        {
            int retorno = 0;
            try
            {
                using (SqlConnection conexion = Clases.ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(string.Format("update Factura set Saldo= '{0}' where IdFactura = '{1}'",
                    pSaldoFinal.Saldo, pSaldoFinal.IdFactura), conexion);
                    retorno = comando.ExecuteNonQuery();
                    conexion.Close();
                }
            } // fin de try
            catch (SqlException e)
            {
                throw e; //va a mostrar el aviso en el throw
            }
            return retorno;
        } // fin de m_ModificarSaldo



    }//fin de clase
}
