using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = Singleton.Instancia();
            //Singleton s2 = Singleton.Instancia();
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //Reloj con Singleton

            Reloj reloj1 = Reloj.Instancia();
            Reloj reloj2 = Reloj.Instancia();

            Console.WriteLine(reloj1.FechaHora);
            Console.WriteLine(reloj2.FechaHora);
            Console.ReadKey();
        }
    }
}
