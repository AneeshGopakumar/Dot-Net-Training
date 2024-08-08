using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day_11
{
    internal class Regexp
    {
        public static void Main2()
        {
            bool exit=false;
            string pattern1 = "^[0-9]{4}$";
            string pattern = "^[0-9]+( run){1}s*$";
            Regex NumPattern = new Regex(pattern);
            while (!exit) {
                Console.WriteLine("\nPattern: " + pattern);
                Console.WriteLine("Enter val to match: ");
                string val = Console.ReadLine();
                if (NumPattern.IsMatch(val))
                    Console.WriteLine("Match");
                else
                    Console.WriteLine("Not a match");
                Console.WriteLine("Press 1 to exit");
                exit = Console.ReadLine() == "1" ? true:false;
            }
            
        }
    }
}
