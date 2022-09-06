using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    // Polimorfismo por herencia y abstraccion

    public class SanBernardo : Perro
    {
        public override string Ladrar()
        {
            return "San Bernardo Ladrando";
        }

        public override string Dormir()
        {
            return "San Bernardo Dormido";
        }
    }


    //public class SanBernardo : IPerro
    //{
    //    public string Ladrar()
    //    {
    //        return "San Bernardo Ladrando";
    //    }

    //    public string Dormir()
    //    {
    //        return "San Bernardo Dormido";
    //    }
    //}
}
