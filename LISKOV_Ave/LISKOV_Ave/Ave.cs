﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_Ave
{
    public class Ave
    {
        public string Comer()
        {
            return "Puedo comer jeje";
        }
        public string EmitirSonido()
        {
            return "Puedo hacer sonidos jeje";
        }
        public virtual string Volar()
        {
            return "Puedo volar jeje";
        }
    }
}
