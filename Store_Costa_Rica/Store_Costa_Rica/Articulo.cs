using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Costa_Rica
{
    public class Articulo
    {
        public int Codigo;
        public string Producto;
        public string Descripcion;
        public int Cantidad;
        public float Precio;
        public float SubTotal;
        public double Interes_Efectivo;
        public double Interes_Tarj_Credito;
        public double Total1;
        public double Total2;


        public Articulo() 
        {
            Codigo = 0;
            Producto = "";
            Descripcion = "";
            Cantidad = 0;
            Precio = 0;
            SubTotal = 0;
            Interes_Efectivo = 0;
            Interes_Tarj_Credito = 0;
            Total1 =0 ;
            Total2= 0;
        }

        public Articulo(int Cod, string Prod, string Desc, int Cant, float Prec, float SubT, double IntEfec, double IntT_C, double Tot1, double Tot2) 
        {
            Codigo = Cod;
            Producto = Prod;
            Descripcion = Desc;
            Cantidad = Cant;
            Precio = Prec;
            SubTotal = SubT;
            Interes_Efectivo = IntEfec;
            Interes_Tarj_Credito = IntT_C;
            Total1 = Tot1;
            Total2 = Tot2;
            
        }//Fin del constructor


     //******Metodos Get-Set********

        public void establecerCodigo(int Cod) 
        {
            Codigo = Cod;
        }

        public int obtenerCodigo() 
        {
            return Codigo;
        }
    //------------------------------------------------------

        public void establecerProducto(string Prod) 
        {
            Producto = Prod;
        }

        public string obtenerProducto() 
        {
            return Producto;
        }
    //--------------------------------------------------------

        public void establecerDescripcion(string Desc) 
        {
            Descripcion = Desc;
        }

        public string obtenerDescripcion() 
        {
            return Descripcion;
        }
    //----------------------------------------------------------

        public void establecerCantidad(int Cant) 
        {
            Cantidad = Cant;
        }

        public int obtenerCantidad() 
        {
            return Cantidad;
        }
    //-----------------------------------------------------------

        public void establecerPrecio(float Prec) 
        {
            Precio = Prec;
        }

        public float obtenerPrecio() 
        {
            return Precio;
        }

    //------------------------------------------------------------

        public void establecerSubTotal(float SubT) 
        {
            SubTotal = Precio*Cantidad;
        }

        public float obtenerSubTotal() 
        {
            return SubTotal;
        }
    //---------------------------------------------------------------

        public void establecerInteres_Efectivo(double IntEfec) 
        {
            Interes_Efectivo = 0.13;
        }

        public double obtenerInteres_Efectivo() 
        {
            return Interes_Efectivo;
        }
    //------------------------------------------------------------------

        public void establecerInteres_Tarj_Credito(double IntT_C) 
        {
            Interes_Tarj_Credito = 0.20;
        }

        public double obtenerInteres_Tarj_Credito() 
        {
            return Interes_Tarj_Credito;
        }
    //-------------------------------------------------------------------

        public void establecerTotal1(double Tot1) 
        {
            Total1 = SubTotal * Interes_Efectivo;
        }

        public double obtenerTotal1() 
        {
            return Total1;
        }
    //------------------------------------------------------------------

        public void establecerTotal2(double Tot2) 
        {
            Total2 = SubTotal * Interes_Tarj_Credito;
        }

        public double obtenerTotal2() 
        {
            return Total2;
        }

    }//Fin de la clase Articulo
}//Fin del namespace
