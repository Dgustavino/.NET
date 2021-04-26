using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_ATH.Clases
{
    public class Cliente
    {
        string Nombre;
        string Cuenta;
        int Pin;
        double Saldo;

        public Cliente()
        {
            Nombre = "";
            Cuenta = "";
            Pin = 0;
            Saldo = 0;
        }//Fin del constructor inicializador

        public Cliente(string nom, string cuent, int pin, double sal)
        {
            Nombre = nom;
            Cuenta = cuent;
            Pin = pin;
            Saldo = sal;
        }//Fin del constructor sobrecargado

        //Metodos Get - Set

        public void establecerNombre(string nom)
        {
            Nombre = nom;
        }

        public string obtenerNombre()
        {
            return Nombre;
        }

        public void establecerCuenta(string cuent)
        {
            Cuenta = cuent;
        }

        public string obtenerCuenta()
        {
            return Cuenta;
        }

        public void establecerPin(int pin)
        {
            Pin = pin;
        }

        public int obtenerPin()
        {
            return Pin;
        }

        public void establecerSaldo(double sal)
        {
            Saldo = sal;
        }

        public double obtenerSaldo()
        {
            return Saldo;
        }
        //Fin de Metodos Get-Set

        public bool disminuirSaldo(double monto)
        {
            if (Saldo >= monto)
            {
                Saldo = Saldo - monto;

                return true;
            }
            else
            {
                return false;
            }
        }//Fin del metodo booleano

    }//Fin de la clase cliente

}//Fin de la clase principal
