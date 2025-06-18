using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class LongestWordFinder
    {
        public void LongestWord(string input)
        {
            string[] words = input.Split(' ');
            string longest = "";

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                    longest = word;
            }

            Console.WriteLine($"Longest word: {longest}");
        }
    }
}
