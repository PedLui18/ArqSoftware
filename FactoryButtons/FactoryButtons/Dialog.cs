using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryButtons
{
    public abstract class Dialog
    {
        public string render() {
            return "";
        }
        public abstract IButton createButton();

        public string onCLick()
        {
            IButton button = createButton();
            button.onClick();
            return button.onClick();
        }

    }
}
