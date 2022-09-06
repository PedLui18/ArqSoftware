using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class DT
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DT(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        
    }
}
