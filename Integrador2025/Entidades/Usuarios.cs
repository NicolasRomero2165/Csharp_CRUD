using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Entidades
{
    public class Usuarios
    {
        public string Login { get; set; }
        public string Passw { get; set; }

        public Usuarios(string login, string passw)
        {
            this.Login = login;
            this.Passw = passw;
        }
    }
}
