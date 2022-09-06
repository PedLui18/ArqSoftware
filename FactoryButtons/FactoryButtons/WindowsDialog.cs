﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryButtons
{
    public class WindowsDialog : Dialog
    {
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }
}
