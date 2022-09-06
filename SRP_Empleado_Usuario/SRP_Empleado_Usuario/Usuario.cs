using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Empleado_Usuario
{
    internal class Usuario
    {
        string nombre;
        string idUsuario;

        public Usuario(string nombre, string idUsuario)
        {
            this.nombre = nombre;
            this.idUsuario = idUsuario;
        }

        public string iniciarSesion()
        {
            return "Se inicio Sesion"; 
        }

    }
}
