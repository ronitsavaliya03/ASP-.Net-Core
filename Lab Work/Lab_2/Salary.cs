using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary(double basic, double ta, double da = 1000.0, double hra = 1500.0)
        {
            Basic = basic;
            TA = ta;
            DA = da;
            HRA = hra;
        }

        public void CalculateSalary()
        {
            double total = Basic + TA + DA + HRA;
            Console.WriteLine("\n--- Salary Details ---");
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("TA: " + TA);
            Console.WriteLine("DA (Default): " + DA);
            Console.WriteLine("HRA (Default): " + HRA);
            Console.WriteLine("Total Salary: " + total);
        }
    }
}
