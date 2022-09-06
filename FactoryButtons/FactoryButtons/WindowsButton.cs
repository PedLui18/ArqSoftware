using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryButtons
{
    public class WindowsButton : IButton
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
