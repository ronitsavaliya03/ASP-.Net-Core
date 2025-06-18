using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Furniture
    {
        protected string material;
        protected double price;

        public void GetFurnitureDetails()
        {
            Console.Write("Enter Material: ");
            material = Console.ReadLine()!;

            Console.Write("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayFurniture()
        {
            Console.WriteLine("Material: " + material);
            Console.WriteLine("Price: ₹" + price);
        }
    }

    class Table : Furniture
    {
        private double height;
        private double surface_area;

        public void GetTableDetails()
        {
            Console.Write("Enter Height (in cm): ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Surface Area (in sq.cm): ");
            surface_area = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayTable()
        {
            Console.WriteLine("\n--- Table Details ---");
            DisplayFurniture(); 
            Console.WriteLine("Height: " + height + " cm");
            Console.WriteLine("Surface Area: " + surface_area + " sq.cm");
        }
    }

}
