using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAProyectoChiyiStore.Clases
{
    public class ActSaldo
    {
        
        public String Saldo { get; set; }
        public String IdFactura { get; set; }


        public ActSaldo() { }


        public ActSaldo(String pSaldo, String pIdFactura )
        {

            this.Saldo = pSaldo;
            this.IdFactura = pIdFactura;
            
 
        }


    }
}
