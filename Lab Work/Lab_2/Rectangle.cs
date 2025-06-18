using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rectangle
    {
        public int x;
        public int y;

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateArea()
        {
            return x * y;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area Of Rectangle:", CalculateArea());
        }
    }
}
