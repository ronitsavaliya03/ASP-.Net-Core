// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello World!");

using Lab_3;
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== Exception Handling Programs =====");
            Console.WriteLine("1. Divide By Zero Exception");
            Console.WriteLine("2. Index Out Of Range Exception");
            Console.WriteLine("3. Abstract Class Sum");
            Console.WriteLine("4. Interface Calculate");
            Console.WriteLine("5. String Methods");
            Console.WriteLine("6. Change Case");
            Console.WriteLine("7. Area Of Shapes");
            Console.WriteLine("8. Custom Exception for Non-Even Number");
            Console.WriteLine("9. Find the Longest Word");
            Console.WriteLine("10. Change the Case of Entered Character");
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
                    DivideByZeroExample();
                    break;
                case 2:
                    IndexOutOfRangeExample();
                    break;
                case 3:
                    Calculate calc = new Calculate();
                    calc.SumOfTwo(5, 6);
                    calc.SumOfThree(5, 5, 5);
                    break;
                case 4:
                    Result result = new Result();
                    result.Addition(5, 6);
                    result.Subtraction(9, 6);
                    break;
                case 5:
                    StringFunc func = new StringFunc();
                    func.StrFunction("ronit savaliya");
                    break;
                case 6:
                    StringFunc func2 = new StringFunc();
                    func2.CaseChanger("RoNiT SaVaLiYa");
                    break;
                case 7:
                    AreaCalculator calculator = new AreaCalculator();
                    calculator.Circle(8.6);
                    calculator.Triangle(6, 9);
                    calculator.Square(5);
                    break;
                case 8:
                    EvenNumberCheck obj = new EvenNumberCheck();
                    obj.EvenCheck(22);
                    obj.EvenCheck(21);
                    break;
                case 9:
                    LongestWordFinder obj2 = new LongestWordFinder();
                    obj2.LongestWord("Find the Longest Word");
                    break;
                case 10:
                    StringFunc func3 = new StringFunc();
                    func3.CharCaseChanger('d');
                    func3.CharCaseChanger('R');
                    func3.CharCaseChanger('9');
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

    static void DivideByZeroExample()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / denominator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter valid numbers only.");
        }
    }

    static void IndexOutOfRangeExample()
    {
        try
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i <= 5; i++) 
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: You tried to access an index that doesn't exist in the array.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter only integer values.");
        }
    }
}
