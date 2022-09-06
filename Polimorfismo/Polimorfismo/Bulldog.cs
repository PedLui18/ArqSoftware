using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //Polimorfismo por herencia y abstraccion

    public class Bulldog : Perro
    {
        public override string Ladrar()
        {
            return "Bulldog Ladrando";
        }

        public override string Dormir()
        {
            return "Bulldog Dormido";
        }
    }

    // polimorfismo por interface
    //public class Bulldog : IPerro
    //{
    //    public string Ladrar()
    //    {
    //        return "Bulldog Ladrando";
    //    }

    //    public string Dormir()
    //    {
    //        return "Bulldog Dormido";
    //    }
    //}
}
