using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryButtons
{
    internal class HTMLButton : IButton
    {
        public string onClick()
        {
            return "Se hizo un click";
        }

        public string render()
        {
            return "Se esta renderizando";
        }
    }
}
