using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV_Ave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Golondrina golondrina = new Golondrina();
            
            Console.WriteLine(golondrina.Volar()+", "+golondrina.EmitirSonido()+", "+golondrina.EmitirSonido());

            Pinguino pinguino = new Pinguino();
            Console.WriteLine(pinguino.Comer() + ", " +pinguino.EmitirSonido());


            Console.ReadKey();
        }
    }
}
