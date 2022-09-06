using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP
{
    internal class Paciente
    {
        private string nombre { get; set; }
        private string apellido{ get; set; }
        private string correo { get; set; }

        public Paciente(string nombre, string apellido, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }
    }
}
