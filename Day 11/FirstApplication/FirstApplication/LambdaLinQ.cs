using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_11
{
    internal class LambdaLinQ
    {
        static void Main2()
        {
            bool exit = false;
            string[] languages = {"c","C++","C#","Java"};
            string val;
            System.Collections.Generic.IEnumerable<string> result;
            while (!exit)
            {
                Console.WriteLine("Enter val to check in array: ");
                val = Console.ReadLine();
                result = from lang in languages where lang.Contains(val, StringComparison.InvariantCultureIgnoreCase) select lang;
                foreach (string res in result)
                {
                    Console.WriteLine(res);
                }
                Console.WriteLine("Press 1 to exit");
                exit = Console.ReadLine() == "1" ? true : false;
            }
        }
    }
}
