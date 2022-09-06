using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoFM1
{
    public abstract class Creator 
    {
        //Cuando tenemos un abstract en el metodo es necesario que la clase principal sea abstract
        public abstract IProduct createProduct();
        public string operation()
        {
            IProduct p = createProduct();
            p.operation();
            return p.operation();
        }


    }
}
