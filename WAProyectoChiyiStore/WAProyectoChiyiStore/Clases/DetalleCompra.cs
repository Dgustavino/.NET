using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAProyectoChiyiStore.Clases
{
    public class DetalleCompra
    {
          public String Producto { get; set; }
        public String Descripcion { get; set; }
        public String Precio { get; set; }
        public String Cantidad { get; set; }
        public String Total{ get; set; }

        public DetalleCompra() {}

        public DetalleCompra(String pProducto, String pDescripcion, String pPrecio, String pCantidad, String pTotal)
        {

            this.Producto = pProducto;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;
            this.Cantidad = pCantidad;
            this.Total = pTotal;
 
        }

    }
}
