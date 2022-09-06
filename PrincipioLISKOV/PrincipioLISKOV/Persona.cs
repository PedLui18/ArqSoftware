using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLISKOV
{
    public class Persona
    {
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public virtual string Pagar()
        {
            return "ha pagado";
        }
    }
}
