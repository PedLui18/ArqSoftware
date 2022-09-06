using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryButtons
{
    public interface IButton
    {
        string render();
        string onClick();
    }
}
