using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Square square = new Square(6);

            CalculationService calculationService = new CalculationService();
            calculationService.sumAreas(circle, square);
            Console.ReadKey();
        }
    }
}
