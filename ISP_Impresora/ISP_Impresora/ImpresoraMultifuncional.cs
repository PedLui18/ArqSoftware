using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Impresora
{
    abstract class ImpresoraMultifuncional : IImprimir, IFotocopiar, IEscanear, IFax
    {
        public void EnviarFax()
        {

        }
        public void RecibirFax()
        {

        }
    }
}
