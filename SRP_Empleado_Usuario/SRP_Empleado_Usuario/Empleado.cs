using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Empleado_Usuario
{
    internal class Empleado
    {
        public string nombre { get; set; }
        public string idEmpleado { get; set; }
        public Empleado(string nombre, string idEmpleado)
        {
            this.nombre = nombre;
            this.idEmpleado = idEmpleado;
        }
        public string cobrarClientes()
        {
            return "Se ha cobrado a los clientes";
        }
        
    }
}
