using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class StringvsStringBuilder
    {
        static void Main2(string[] args)
        {
            string s = string.Empty;
            s = "Hello";
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            Console.WriteLine(sb.ToString());
            sb = new StringBuilder("World!");
            sb.Append(s);
            Console.WriteLine(sb.ToString());

        }
    }
}
