using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Swapping
    {
        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public static void DiffOut(int a, int b, out int result)
        {
            int c = a;
            a = b;
            b = c;
            result = a - b;
        }

        public static int DiffRef(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
            return(a - b);
        }
        static void Main2(string[] args)
        {
            int result = 10;
            Console.WriteLine("Enter 2 nos: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Before swap => a: " + Convert.ToString(a) + "; b: " + Convert.ToString(b));
            //Swap(ref a, ref b);
            //Console.WriteLine("After swap => a: " + Convert.ToString(a) + "; b: " + Convert.ToString(b));
            Console.WriteLine("result- " + result);
            DiffOut(a, b, out result);
            Console.WriteLine("DiffOut: a - " + Convert.ToString(a) + " ;b - " + Convert.ToString(b) + " ;Result - " + result);
            int result2 = DiffRef(ref a, ref b);
            Console.WriteLine("DiffRef:  a - " + Convert.ToString(a) + " ;b - " + Convert.ToString(b) + " ;Result - " + result2);
        }
    }
}
