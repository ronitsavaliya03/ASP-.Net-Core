using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Bank_Account
    {
        int Account_No;
        string Email, User_Name, Account_Type;
        double Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter the Account No:");
            Account_No = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the Email:");
            Email = Console.ReadLine()!;

            Console.WriteLine("Enter the User_Name:");
            User_Name = Console.ReadLine()!;

            Console.WriteLine("Enter the Account_Type:");
            Account_Type = Console.ReadLine()!;

            Console.WriteLine("Enter the Account_Balance:");
            Account_Balance = double.Parse(Console.ReadLine()!);
        }
        
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account_No: " + Account_No);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("User_Name: " + User_Name);
            Console.WriteLine("Account_Type: " + Account_Type);
            Console.WriteLine("Account_Balance: " + Account_Balance);
        }
    }
}
