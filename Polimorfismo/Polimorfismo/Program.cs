using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        // Polimorfismo por herencia
        static void Main(string[] args)
        {
            Bulldog bTobby = new Bulldog();
            Bulldog bBrucce = new Bulldog();
            SanBernardo sbCentavito = new SanBernardo();
            SanBernardo sbKayser = new SanBernardo();
            SanBernardo sbCapitan = new SanBernardo();

            //Polimorfismo por herencia y abstraccion

            Perro[] Perrera = { bTobby, bBrucce, sbCentavito, sbKayser, sbCapitan };
            foreach (var perrito in Perrera)
            {
                Console.WriteLine(perrito.Ladrar());
                Console.WriteLine(perrito.Dormir());
            }

            // Polimorfismo por interface

            //IPerro[] Perrera = { bTobby, bBrucce, sbCentavito, sbKayser, sbCapitan };
            //foreach (IPerro perrito in Perrera)
            //{
            //    Console.WriteLine(perrito.Ladrar());
            //    Console.WriteLine(perrito.Dormir());
            //}

            Console.ReadKey();
        }
    }
}
