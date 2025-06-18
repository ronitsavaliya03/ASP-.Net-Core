using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class NotEvenNumberException : Exception
    {
        public NotEvenNumberException(string message) : base(message)
        {
        }
    }
    internal class EvenNumberCheck
    {
        public void EvenCheck(int number)
        {
            try
            {
                if (number % 2 != 0)
                    throw new NotEvenNumberException("The number is not even.");

                Console.WriteLine("The number is even.");
            }
            catch (NotEvenNumberException ex)
            {
                Console.WriteLine($"Custom Exception: {ex.Message}");
            }
        }
    }
}
