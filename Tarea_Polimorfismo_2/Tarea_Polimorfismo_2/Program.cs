using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Polimorfismo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deportista deportista1 = new Deportista();
            Deportista deportista2 = new Deportista();
            Deportista deportista3 = new Deportista();
            Informatico informatico1 = new Informatico();
            Informatico informatico2 = new Informatico();

            //Persona[] personas = { deportista1, deportista2, deportista3, informatico1, informatico2 };

            //foreach (Persona persona in personas)
            //{
            //    Console.WriteLine(persona.correr());

            //}

            IPersona[] personas = { deportista1, deportista2, deportista3, informatico1, informatico2 };

            foreach (IPersona persona in personas)
            {
                Console.WriteLine(persona.correr());

            }

            Console.ReadKey();
        }
    }
}
