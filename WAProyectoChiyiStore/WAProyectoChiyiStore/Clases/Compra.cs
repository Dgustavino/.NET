using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAProyectoChiyiStore.Clases
{
    public class Compra
    {
         public String IdFactura { get; set; }
        public String IdProducto { get; set; }
        public String Cantidad { get; set; }
        public String Precio { get; set; }

        public Compra() {}

        public Compra(String pIdFactura, String pIdProducto, String pCantidad, String pPrecio)
        {

            this.IdFactura = pIdFactura;
            this.IdProducto = pIdProducto;
            this.Cantidad = pCantidad;
            this.Precio = pPrecio;
 
        }

    }
}
