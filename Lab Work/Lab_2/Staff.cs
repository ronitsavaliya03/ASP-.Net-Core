using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Staff
    {
        public string Name, Department, Designation;
        public double Experience, Salary;

        public Staff() { }

        public void GetStaffDetails()
        {

            Console.WriteLine("Enter the Name:");
            Name = Console.ReadLine()!;

            Console.WriteLine("Enter the Department:");
            Department = Console.ReadLine()!;

            Console.WriteLine("Enter the Designation:");
            Designation = Console.ReadLine()!;

            Console.WriteLine("Enter the Salary:");
            Salary = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Experience:");
            Experience = double.Parse(Console.ReadLine()!);
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Experience: " + Experience);

        }
    }
}
