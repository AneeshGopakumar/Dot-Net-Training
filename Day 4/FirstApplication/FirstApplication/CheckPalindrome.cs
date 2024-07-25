using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class CheckPalindrome
    {
        static void Main2(string[] args)
        {
            Console.Write("Enter string to be checked for palindrome - ");
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length-1; i >= 0; i--) {
                sb.Append(s[i]);
            }
            Console.WriteLine("Reversed string - " + sb.ToString());
            Console.WriteLine("Is Palindrome? " + (s==sb.ToString()?true:false));
        
        }
    }
}
