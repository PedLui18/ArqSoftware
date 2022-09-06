using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_LAboratorio1
{
    public class Loro : IPajaroSimple, IVolador
    {

        public string Volar()
        {
            return "Puedo Volar"; 
        }
        public string SoyunPajaro()
        {
            return "Soy un Loro";
        }
    }
}
