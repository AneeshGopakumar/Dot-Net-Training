using Day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class FunctionOverloading
    {
        public int Sum(int a, int b) 
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b +c;
        }
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
    }

    public class OperatorOverloading
    {
        public int a;
        public int b;
        public OperatorOverloading(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public static OperatorOverloading operator + (OperatorOverloading O1, OperatorOverloading O2)
        {
            return new OperatorOverloading(O1.a + O2.a, O1.b + O2.b);
        }
        public static OperatorOverloading operator -(OperatorOverloading O1, OperatorOverloading O2)
        {
            return new OperatorOverloading(O1.a - O2.a, O1.b - O2.b);
        }
        public static OperatorOverloading operator *(OperatorOverloading O1, OperatorOverloading O2)
        {
            return new OperatorOverloading(O1.a * O2.a, O1.b * O2.b);
        }
    }
    internal class Polymorphism
    {
        public static void Main()
        {
            FunctionOverloading F1 = new FunctionOverloading();
            Console.WriteLine(F1.Sum(1, 2));
            Console.WriteLine(F1.Sum("10", "20"));
            Console.WriteLine(F1.Sum(1, 2, 3));


            OperatorOverloading O1 = new OperatorOverloading(5,3);
            OperatorOverloading O2 = new OperatorOverloading(2,3);
            Console.WriteLine((O1 + O2).a + "," + (O1 + O2).b);
            Console.WriteLine((O1 - O2).a + "," + (O1 - O2).b);
            Console.WriteLine((O1 * O2).a + "," + (O1 * O2).b);
        }       
    }
}
