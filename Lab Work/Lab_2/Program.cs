// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//1.Write a program to create a class named Candidate with ID, Name, Age,
//Weight and Height as data members & also create a member functions like
//GetCandidateDetails() and DisplayCandidateDetails().

using Lab_2;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Security.Claims;
using System.Security.Principal;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

Candidate candidate1 = new Candidate();
candidate1.GetCandidateDetails();
candidate1.DisplayCandidateDetails();

//2.Write a program to create a class Staff having data members as Name,
//Department, Designation, Experience & Salary. Accept this data for 5
//different staffs and display only names & salary of those staff who are
//HOD.

Staff[] staff1 = new Staff[5];

for (int i = 0; i < staff1.Length; i++)
{
    staff1[i] = new Staff();
    staff1[i].GetStaffDetails();
    if (staff1[i].Designation.ToLower() != "hod")
    {
        staff1[i].DisplayStaffDetails();
    }
}

//3.Write a pogram to Create a class Bank_Account with Account_No, Email,
//User_Name, Account_Type and Account_Balance as data members. Also
//create a Member function GetAccountDetails() & DisplayAccountDetails().

Bank_Account bank1 = new Bank_Account();
bank1.GetAccountDetails();
bank1.DisplayAccountDetails();

//4.Write a program with following specifications:
//Class Name: Student
//Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
//Get Students Details using constructor and DisplayStudentDetails() using
//member function.

Student student1 = new Student(23010101247, "Ronit", 5, 7.5, 6.11);
student1.DisplayStudentDetails();

//5.Write a program to calculate area of a Rectangle using constructor.

Rectangle rectangle1 = new Rectangle(10, 20);
rectangle1.DisplayArea();

//6.Write a program for implementing single inheritance which creates one
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//from account details.

Interest obj = new Interest();
obj.GetDetails();
obj.CalculateInterest();
obj.Display();

//7. Write a program to Define a class Salary which will contain member
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee.

Console.Write("Enter Basic Salary: ");
double basic = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter TA (Travel Allowance): ");
double ta = Convert.ToDouble(Console.ReadLine());

Salary emp = new Salary(basic, ta);

emp.CalculateSalary();

//8.Write a program to Define a class Distance have data members dist1, dist2,
//dist3. Initialize the two data members using constructor and store their
//addition in third data member using function and display addition.

Console.Write("Enter Distance 1: ");
double d1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Distance 2: ");
double d2 = Convert.ToDouble(Console.ReadLine());

Distance location = new Distance(d1, d2);

location.AddDistances();
location.Display();

//9.Create a class Furniture with material, price as data members. Create
//another class Table with Height, surface_area as data members. Write a
//program to implement single inheritance.

Table table1 = new Table();

table1.GetFurnitureDetails();
table1.GetTableDetails();

table1.DisplayTable();

//Program to implement the following multiple inheritance using interface
//Interface : Gross
//Method- Gross_sal()

//Class : Salary
//Data Members - HRA, TA, DA
//Methods - Disp_sal()

//Class : Employee
//Data Members - Name
//Methods - basic_sal()

Salary2 emp1 = new Salary2();

emp1.basic_sal();     
emp1.Gross_sal();     
emp1.Disp_sal();