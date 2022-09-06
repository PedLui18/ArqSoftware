using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_LAboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loro loro = new Loro();  
            
            Console.WriteLine(loro.SoyunPajaro() + " y " + loro.Volar());

            Pinguino pinguino = new Pinguino();
            Console.WriteLine(pinguino.SoyunPajaro() + " y " + pinguino.Nadar());

            Avestruz avestruz = new Avestruz();
            Console.WriteLine(avestruz.SoyunPajaro() + " y " + avestruz.Correr());

            Console.ReadKey();
        }
    }
}
