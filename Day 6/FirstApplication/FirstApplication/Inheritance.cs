using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class class1
    {
        public class1()
        {
            Console.WriteLine("Class1");
        }
    }
    class class2:class1
    {
        public class2()
        {
            Console.WriteLine("Class2");
        }
    }
    class class3:class2
    {
        public class3()
        {
            Console.WriteLine("Class3");
        }
    }

    internal class Inheritance
    {
        static void Main2(string[] args)
        {
            class3 cl3 = new class3();
            //class2 cl2 = new class2();
        }
    }
}
