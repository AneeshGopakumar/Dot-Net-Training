using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Test
    {
        private string MyField;
        public Test()
        {
            MyField = "Default my field value";
        }
        public string MyProperty { get { return MyField; } set { if (value == "Test property") { MyField = value; } else { throw new System.Exception("Invlid value"); } } }
    }
    internal class Properties
    {
        public static void Main2()
        {
            Test Obj = new Test();
            Obj.MyProperty = "Test property";
            Console.WriteLine(Obj.MyProperty);
            //Obj.MyField = "Test field";
            //Console.WriteLine(Obj.MyField);
        }
        
    }
}
