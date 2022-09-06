using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_LAboratorio1
{
    public class Avestruz : IPajaroSimple, ICorredor 
    {

        public string Correr()
        {
            return "Puedo Correr";
        }

        public string SoyunPajaro()
        {
            return "Soy un Avestruz";
        }
    }
}
