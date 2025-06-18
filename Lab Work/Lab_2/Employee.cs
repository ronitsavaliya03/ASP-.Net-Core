using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface Gross
    {
        void Gross_sal();
    }

    internal class Employee
    {
        protected string Name;
        protected double Basic;

        public void basic_sal()
        {
            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine()!;

            Console.Write("Enter Basic Salary: ");
            Basic = Convert.ToDouble(Console.ReadLine());
        }
    }

    class Salary2 : Employee, Gross
    {
        private double HRA;
        private double TA;
        private double DA;
        private double GrossSalary;

        public void Gross_sal()
        {
            HRA = 0.10 * Basic;
            TA = 0.05 * Basic;
            DA = 0.08 * Basic;

            GrossSalary = Basic + HRA + TA + DA;
        }

        public void Disp_sal()
        {
            Console.WriteLine("\n--- Salary Slip ---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Basic Salary: ₹" + Basic);
            Console.WriteLine("HRA (10%): ₹" + HRA);
            Console.WriteLine("TA (5%): ₹" + TA);
            Console.WriteLine("DA (8%): ₹" + DA);
            Console.WriteLine("Gross Salary: ₹" + GrossSalary);
        }
    }
}
