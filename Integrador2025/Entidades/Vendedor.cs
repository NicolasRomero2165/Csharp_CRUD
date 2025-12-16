using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Entidades
{
    public class Vendedor
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string CUIT { get; set; }

        public Vendedor(string apellido, string nombre, string dNI, string cUIT)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.DNI = dNI;
            this.CUIT = cUIT;
        }
    }
}
