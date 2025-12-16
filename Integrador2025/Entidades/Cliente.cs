using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Entidades
{
    public abstract class Cliente
    {
        public Cliente(string apellido, string nombre, string cUIT, string email, string telefono, string direccion)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.CUIT = cUIT;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
