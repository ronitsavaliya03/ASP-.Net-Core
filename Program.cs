// 1. Write a program to print your name, address, contact number & city.
// Personal Information
string name = "Mr. Savaliya";
string address = "123, ABC Street, Near XYZ Park";
string contactNumber = "+91-9876543210";
string city = "Surat";

// Output
Console.WriteLine("===== Personal Information =====");
Console.WriteLine("Name          : " + name);
Console.WriteLine("Address       : " + address);
Console.WriteLine("Contact Number: " + contactNumber);
Console.WriteLine("City          : " + city);

// 2. Write a program to get two numbers from user and print those two 
// numbers.

Console.WriteLine("Enter the num1: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the num2: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Sum of a and b: " + (a + b));

// 3. Write program to prompt a user to input his/her name and country name
// and then output will be shown as given: Hello <yourname> from country
// <countryname>

Console.WriteLine("Enter Your Name: ");
string yourname = Console.ReadLine()!;

Console.WriteLine("Enter Your Country Name: ");
string countryname = Console.ReadLine()!;

Console.WriteLine("Hello " + yourname + " from country " + countryname);

// 4. Write a program to calculate the size of the area in square-feet based on
// Specified length and width.

Console.WriteLine("Enter the Length: ");
double length = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Width: ");
double width = double.Parse(Console.ReadLine()!);

Console.WriteLine("The size of the area in square-feet: " + (length * width));

// 5. Write a program to calculate area of Square, Rectangle and Circle.

Console.WriteLine("Enter the Length: ");
double length1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Area of Square: " + (length * length));

Console.WriteLine("Enter the Length: ");
double length2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Width: ");
double width2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Area of Rectangle: " + (length2 * width2));

Console.WriteLine("Enter the Radius: ");
double radius = double.Parse(Console.ReadLine()!);

Console.WriteLine("Area of Circle: " + (3.1415 * radius * radius));

// 6. Write a program to calculate Celsius to Fahrenheit and vice - versa using
// function.

static double CelsiusToFahrenheit(double C)
{
    return (C * 9 / 5) + 32;
}

static double FahreheitToCelsius(double F)
{
    return (F - 32) * 5 / 9;
}

double fahrenheit = CelsiusToFahrenheit(90.0);
Console.WriteLine(fahrenheit);

double celsius = FahreheitToCelsius((double)fahrenheit);
Console.WriteLine(celsius);

//// 7.Write a program to find out Simple Interest using function. (I = PRN / 100)
Console.WriteLine("Enter the Principle: ");
double P = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Rate: ");
double R = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Time: ");
double N = double.Parse(Console.ReadLine()!);


Console.WriteLine("Simple Interest:" + (P * R * N / 100));
Console.WriteLine("Hello");

// 8. Write a program to create a Simple Calculator for two numbers (Addition,
// Multiplication, Subtraction, Division) [Also using if…else & Switch Case]

Console.WriteLine("Enter the Operand1: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter Operator:");
char ch = char.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Operand2: ");
double num2 = double.Parse(Console.ReadLine()!);

switch (ch)
{
    case '+':
        Console.WriteLine(num1 + num2);
        break;

    case '-':
        Console.WriteLine(num1 - num2);
        break;

    case '*':
        Console.WriteLine(num1 * num2);
        break;

    case '/':
        Console.WriteLine(num1 / num2);
        break;
}

// 9. Write a program to Swapping without using third variable.
int n1 = 5;
int n2 = 10;

n1 = n1 ^ n2;
n2 = n1 ^ n2;
n1 = n2 ^ n1;

Console.WriteLine(n1 + " " + n2);

// 10. Write a program to find maximum numbers from given 3 numbers using
// ternary operator.

int a1 = 3;
int b1 = 2;
int c1 = 9;

int largest = a1 > b1 ? (a1 > c1 ? a1 : c1) : (b1 > c1 ? b1 : c1);

Console.WriteLine(largest);
