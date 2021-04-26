using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAProyectoChiyiStore.Clases
{
    public class Producto
    {
        public String Product { get; set; }
        public String Descripcion { get; set; }
        public String Categoria { get; set; }
        public String Precio { get; set; }

        public Producto() {}

        public Producto(String pProducto, String pDescripcion, String pCategoria, String pPrecio)
        {

            this.Product = pProducto;
            this.Descripcion = pDescripcion;
            this.Categoria = pCategoria;
            this.Precio = pPrecio;

         }

    }
}
