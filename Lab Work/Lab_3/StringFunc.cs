using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class StringFunc
    {
        public void StrFunction(string s) { 
            Console.WriteLine("ToLower(): "+s.ToLower());
            Console.WriteLine("ToUpper(): " + s.ToUpper());
            Console.WriteLine("IndexOf(): " + s.IndexOf("a"));
            Console.WriteLine("StartsWith(): "+ s.StartsWith("r"));
            Console.WriteLine("EndsWith(): " + s.EndsWith("a"));
            Console.WriteLine("Remove(): " + s.Remove(5, 7));
            Console.WriteLine("Insert(): " + s.Insert(6, "ashok "));
            Console.WriteLine("Replace(): " + s.Replace("savaliya", "patel"));
        }

        public void CaseChanger(string s) { 
            char[] characters= s.ToCharArray();
            string str = "";
            foreach(char c in characters)
            {
                if (char.IsLower(c))
                {
                    str+=char.ToUpper(c);
                }
                else
                {
                    str+=char.ToLower(c);
                }
            }
            
            
            Console.WriteLine(str);
        }

        public void CharCaseChanger(char ch)
        {
            if (char.IsLower(ch))
                Console.WriteLine($"Uppercase: {char.ToUpper(ch)}");
            else if (char.IsUpper(ch))
                Console.WriteLine($"Lowercase: {char.ToLower(ch)}");
            else
                Console.WriteLine("Not an alphabetic character.");
        }
    }
}
