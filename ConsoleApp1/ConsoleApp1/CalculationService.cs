using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CalculationService
    {
        public void sumAreas(Polygon poligon1, Polygon poligon2)
        {
            Console.WriteLine(poligon1.getArea() + poligon2.getArea());
        }

        public void diffAreas(Polygon poligon1, Polygon poligon2)
        {
            Console.WriteLine(poligon1.getArea() - poligon2.getArea());
        }
    }
}
