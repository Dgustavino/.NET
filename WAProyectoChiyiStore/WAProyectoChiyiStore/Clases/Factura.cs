using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAProyectoChiyiStore.Clases
{
    public class Factura
    {
        public String IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public String Cedula { get; set; }
        public String Saldo { get; set; }
        public String TipoPago { get; set; }


        public Factura() {}

        public Factura(String pIdFactura, DateTime pFechaFactura, String pCedula, String pSaldo, String pTipoPago)
        {

            this.IdFactura = pIdFactura;
            this.FechaFactura = pFechaFactura;
            this.Cedula = pCedula;
            this.Saldo = pSaldo;
            this.TipoPago = pTipoPago;
 
        }
    }
}
