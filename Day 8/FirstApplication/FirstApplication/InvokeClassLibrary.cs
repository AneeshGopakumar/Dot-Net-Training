using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClassLibrary;

namespace Day_8
{
    internal class InvokeClassLibrary
    {
        public static void Main()
        {
            
            //Invoking class from different namespace
            /*TestClassLibrary.Class1 C1 = new TestClassLibrary.Class1();
            C1.DisplayText();*/
            Class1 C2 = new Class1();
            C2.DisplayText();

            //Invoking class from same namespace but different cs
            Test T1 = new Test();
            Console.WriteLine(T1.MyProperty);            
        }
    }
}
