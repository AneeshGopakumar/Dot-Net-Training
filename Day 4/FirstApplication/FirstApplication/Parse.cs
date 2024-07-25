using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Parse
    {
        static void Main2(string[] args)
        {
            Console.Write("Enter content to be parsed: ");
            string a = Console.ReadLine();
            bool parsed = int.TryParse(a, out int parseresult);
            Console.WriteLine(parsed?parseresult:"Cannot parse");
        }
    }
}
