using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAProyectoChiyiStore.Clases
{
    public class Cliente
    {

        public String Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
	    public String Direccion { get; set; }
        public String Email { get; set; }

        public Cliente() {}

        public Cliente(String pCedula, String pNombre, String pApellido, String pTelefono, String pDireccion, String pEmail)
        {

            this.Cedula = pCedula;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.Email = pEmail;
 
        }


    }
}
