using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Jugador : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        List<string> jugador = new List<string>();

        public string Jugar() 
        {
            return "";
        }
    }
}
