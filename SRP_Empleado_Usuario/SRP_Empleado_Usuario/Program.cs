using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Empleado_Usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("","");

            empleado.cobrarClientes();

            Usuario usuario = new Usuario("", "");

            usuario.iniciarSesion();

        }
    }
}
