using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cajero_Automatico.Clases
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
        }

        public Cliente(string nom, string cuent, int pin, double sal)
        {

            Nombre = nom;
            Cuenta = cuent;
            Pin = pin;
            Saldo = sal;
        }
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

        public int  obtenerPin()
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

        public bool disminuirSaldo(double monto) {

            if (Saldo >= monto)
            {
                Saldo = Saldo - monto;

                return true;
            }
            else

                return false;
        
        }





    }
}
