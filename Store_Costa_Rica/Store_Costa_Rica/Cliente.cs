using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Costa_Rica
{
    public class Cliente
    {
        int Cedula;
        string Nombre;
        string Apellido;
        int Telefono;
        string Direccion;
        string Correo;

        public Cliente() 
        {
            Cedula = 0;
            Nombre = "";
            Apellido = "";
            Telefono = 0;
            Direccion = "";
            Correo = "";
        }

        public Cliente(int ced, string nom, string apell, int telf, string direc, string email) 
        {
            Cedula = ced;
            Nombre = nom;
            Apellido = apell;
            Telefono = telf;
            Direccion = direc;
            Correo = email;
        }//Fin del constructor

    //*****Metodos Get-Set*****

        public void establecerCedula(int ced) 
        {
            Cedula = ced;
        }

        public int obtenerCedula() 
        {
            return Cedula;
        }
    //-----------------------------------------
       
        public void establecerNombre(string nom) 
        {
            Nombre = nom;
        }

        public string obtenerNombre() 
        {
            return Nombre;
        }
    //------------------------------------------

        public void establecerApellido(string apell) 
        {
            Apellido = apell;
        }

        public string obtenerApellido() 
        {
            return Apellido;
        }
    //--------------------------------------------------

        public void establecerTelefono(int telf) 
        {
            Telefono = telf;
        }

        public int obtenerTelefono() 
        {
            return Telefono;
        }
    //----------------------------------------------------

        public void establecerDireccion(string direc) 
        {
            Direccion = direc;
        }

        public string obtenerDireccion() 
        {
            return Direccion;
        }
    //-----------------------------------------------------

        public void establecerCorreo(string email) 
        {
            Correo = email;
        }

        public string obtenerCorreo() 
        {
            return Correo;
        }
    //---------------------------------------------------





    }//Fin de la clase Cliente
}//Fin del namespace
