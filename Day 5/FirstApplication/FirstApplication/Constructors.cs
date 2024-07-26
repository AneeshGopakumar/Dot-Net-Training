using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{

    class Employee
    {
        public int Id;
        public string EmployeeName;
        
        public Employee()
        {
            Id = 1;
            EmployeeName = "DefaultName";
        }
        public Employee(int id, string Name)
        {
            Id = id;
            EmployeeName = Name;
        }
        public void PrintEmployeeData()
        {
            Console.WriteLine(EmployeeName);
            Console.WriteLine(Id);
        }
    }
    internal class Program
    {
        static void Main2(string[] args)
        {
            Employee student = new Employee(2, "ABC");
            student.PrintEmployeeData();
            Employee student2 = new Employee();
            student2.PrintEmployeeData();
        }
    }
}

