// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Lab_5;
using System;

class Program
{
    static void Main()
    {
        int choice;
        CollectionClasses collectionClasses = new CollectionClasses();

        do
        {
            Console.WriteLine("\n===== Collection Classes =====");
            Console.WriteLine("1. ArrayList Demo");
            Console.WriteLine("2. List Demo");
            Console.WriteLine("3. Stack Demo");
            Console.WriteLine("4. Queue Demo");
            Console.WriteLine("5. Dictionary Demo");
            Console.WriteLine("6. HashTable Demo");
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
                    collectionClasses.ArrayListDemo();
                    break;
                case 2:
                    collectionClasses.ListDemo();
                    break;
                case 3:
                    collectionClasses.StackDemo();
                    break;
                case 4:
                    collectionClasses.QueueDemo();
                    break;
                case 5:
                    collectionClasses.DictionaryDemo();
                    break;
                case 6:
                    collectionClasses.HashTableDemo();
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


