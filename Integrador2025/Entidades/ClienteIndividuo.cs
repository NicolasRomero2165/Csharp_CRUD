using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Entidades
{
    public class ClienteIndividuo : Cliente
    {
        public ClienteIndividuo(string apellido, string nombre, string cUIT, string email, string telefono, string direccion)
            : base(apellido, nombre, cUIT, email, telefono, direccion)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.CUIT = cUIT;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }
    }
}
