using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class FindArea
    {
        public void area(double side)
        {
            Console.WriteLine("Area Of Squre: "+ side*side);
        }

        public void area(double height, double width) 
        { 
            Console.WriteLine("Area Of Rectangle: "+ height*width);
        }

        public void area(float radius)
        {
            Console.WriteLine("Area Of Circle: "+ Math.PI*radius*radius);
        }
    }
}
