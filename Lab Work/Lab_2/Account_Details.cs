using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    using System;

    class Account_Details
    {
        public string accountHolder;
        public int accountNumber;
        public double principal;
        public double rate;
        public int time;

        public void GetDetails()
        {
            Console.Write("Enter Account Holder Name: ");
            accountHolder = Console.ReadLine()!;

            Console.Write("Enter Account Number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Principal Amount: ");
            principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Interest Rate (%): ");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            time = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Interest : Account_Details
    {
        double totalInterest;

        public void CalculateInterest()
        {
            totalInterest = (principal * rate * time) / 100;
        }

        public void Display()
        {
            Console.WriteLine("\n--- Account Summary ---");
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Principal Amount: " + principal);
            Console.WriteLine("Interest Rate: " + rate + "%");
            Console.WriteLine("Time (Years): " + time);
            Console.WriteLine("Total Interest: " + totalInterest);
        }
    }

}