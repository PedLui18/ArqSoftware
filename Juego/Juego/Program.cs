using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DT dT = new DT("Juan", "Campos");
            Arbitro arbitro = new Arbitro("Alejandro", "Perez");    
            Equipo eq1 = new Equipo("Bolivar");
            Equipo eq2 = new Equipo("Tigre");

            Partido p = new Partido(dT,arbitro,eq1);
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}
