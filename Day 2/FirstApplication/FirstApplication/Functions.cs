using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Functions
    {
        public static int FindMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a,b),c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 nos: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Max is: " + Convert.ToString(FindMax(num1, num2, num3)));
        }
    }
}
