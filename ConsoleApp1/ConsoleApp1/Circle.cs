using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int getRadius()
        {
            return this.radius;
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
