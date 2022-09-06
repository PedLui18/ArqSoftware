using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_LAboratorio1
{
    public class Pinguino : IPajaroSimple, INadador
    {
        
        public string Nadar()
        {
            return "Puedo Correr";
        }

        public string SoyunPajaro()
        {
            return "Soy un Pinguino";
        }
    }
}
