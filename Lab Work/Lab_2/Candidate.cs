using System;

public class Candidate
{ 
	int id, age;
	string name;
	double height, weight;

	public void GetCandidateDetails()
	{
		Console.WriteLine("Enter the ID:");
		id = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the Name:");
        name = Console.ReadLine()!;

        Console.WriteLine("Enter the Age:");
        age = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the Weight:");
        weight = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the Weight:");
        height = double.Parse(Console.ReadLine()!);
    }

	public void DisplayCandidateDetails()
	{
		Console.WriteLine("Id: " + id);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Weight: " + weight);
    }
}
