// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab_4;
using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Exception Handling Programs =====");
            Console.WriteLine("1. Addition - Overloading");
            Console.WriteLine("2. Find Area");
            Console.WriteLine("3. Bank Interest");
            Console.WriteLine("4. Hospital Details");
            Console.WriteLine("5. Area of Shapes");
            Console.WriteLine("6. Bank Account");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            bool validInput = int.TryParse(Console.ReadLine(), out choice);

            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Addition addition = new Addition();
                    addition.AdditionOfTwo(5, 6);
                    addition.AdditionOfTwo(5.0f, 6.0f);
                    break;
                case 2:
                    FindArea findArea = new FindArea();
                    findArea.area(5);
                    findArea.area(6, 5);
                    break;
                case 3:
                    RBI bank = new RBI();
                    bank.calculateInterest();

                    HDFC bank2 = new HDFC();
                    bank2.calculateInterest();

                    ICICI bank3 = new ICICI();
                    bank3.calculateInterest();
                    break;
                case 4:
                    Hospital hospital = new Hospital();
                    hospital.HospitalDetails();

                    Apollo apollo = new Apollo();
                    apollo.HospitalDetails();

                    Wockhardt wockhardt = new Wockhardt();
                    wockhardt.HospitalDetails();

                    Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();
                    gokul_Superspeciality.HospitalDetails();
                    break;
                case 5:
                    FindArea findArea1 = new FindArea();
                    findArea1.area(5);
                    findArea1.area(6, 5);
                    findArea1.area(6.0f);
                    break;
                case 6:
                    BankAccount account = new BankAccount("Mr. Patel", 10000);

                    account.ShowDetails();

                    account.Deposit(2000);
                    account.Deposit("CHQ101", 3000);

                    account.Withdraw(2500);
                    account.Withdraw("CHQ202", 5000);

                    account.ShowDetails();
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 0);
    }
}
