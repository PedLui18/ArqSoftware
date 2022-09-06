using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLISKOV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adulto adulto1 = new Adulto("123asd", "Juan", "Campos");
            Adulto adulto1 = new Adulto();
            adulto1.Nombre = "Hernan";
            adulto1.Apellidos = "Mendez";
            //Niño n = new Niño(31312,"Juanito", "Campos");
            Niño n = new Niño();
            n.Rude = 31312;
            n.Tutor = adulto1;            

            Console.WriteLine(n.Tutor.PagarMatricula());

            Console.ReadKey();
        }
    }
}
