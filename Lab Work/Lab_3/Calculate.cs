using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface Calculate1
    {
        public void Addition(double x, double y);
        public void Subtraction(double x, double y);
    }

    public class Result : Calculate1
    {
        public void Addition(double x, double y)
        {
            Console.WriteLine($"Addition of {x} and {y} is {x+y}");
        }

        public void Subtraction(double x, double y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
        }
    }
}
