using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class OOPs
    {
        public class Employee {
            int employeeSal;
            string employeeId, gender, name;
            public void getData()
            {
                Console.Write("Enter employeeId - ");
                employeeId = Console.ReadLine();
                Console.Write("Enter employeeSal - ");
                employeeSal = int.Parse(Console.ReadLine());
                Console.Write("Enter gender - ");
                gender = Console.ReadLine();
                Console.Write("Enter name - "); 
                name = Console.ReadLine();
            }
            public void printData() {
                Console.WriteLine();
                Console.WriteLine("EmpID: " + employeeId); 
                Console.WriteLine("EmpSal: " + employeeSal);
                Console.WriteLine("Gender: " + gender);
                Console.WriteLine("Name: " + name);
            }
           

        }
        static void Main(string[] args)
        { 
            Employee employee1 = new Employee();
            employee1.getData();
            employee1.printData();
        }
    }
}
