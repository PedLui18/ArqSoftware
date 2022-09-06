using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoFM1
{
    public class ConcreteCreatorB : Creator
    {
        //Cuando la clase sea abstracta es necesario que se utilice "override" en el metodo que se utiliza
        public override IProduct createProduct()
        {
            return new ConcreteProductB();
        }
    }
}
