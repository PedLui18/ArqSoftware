using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square
    {
        int side;

        public Square(int side)
        {
            this.side = side;
        }
        public int getSide()
        {
            return this.side;
        }

        public void setSide(int side) { 
            this.side = side;
        }

        public double getArea()
        {
            return Math.Pow(side, 2);
        }
    }
}
