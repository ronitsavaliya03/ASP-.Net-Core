using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Addition
    {
        public void AdditionOfTwo(int a, int b) { 
            Console.WriteLine(a + " + " + b +" = "+(a+b));
        }

        public void AdditionOfTwo(float a, float b) {
            Console.WriteLine(a + " + " + b + " = " + (a + b));
        }
    }
}
