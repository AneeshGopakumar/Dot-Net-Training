using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Employee
    {
        public string EmpId;
        public string EmpName;
        public Employee(string id, string Name)
        {
            EmpId = id;
            EmpName = Name;
        }
    }
    internal class MenuOptions
    {
        static void Main(string[] args)
        {
            int OptionSelected=0;
            List <Employee> EmpList = new List<Employee>();
            while (OptionSelected!=5){
                Console.WriteLine("\n--Menu--\n1.Add Employee\n2.Update Employee\n3.Delete Employee\n4.List Employee\n5.Exit");
                OptionSelected = int.Parse(Console.ReadLine());
                switch (OptionSelected)
                {
                    case 1: 
                        Console.WriteLine("\nEnter EmpId: ");
                        string EmpID = Console.ReadLine();
                        Console.WriteLine("\nEnter EmpName: ");
                        string EmpName = Console.ReadLine();
                        Employee EmpAdd = new Employee(EmpID, EmpName);
                        EmpList.Add(EmpAdd);
                        break;
                    case 2:
                        Console.WriteLine("\nEnter EmpId of employee to be updated: ");
                        string EmpIDUpt = Console.ReadLine();
                        Console.WriteLine("\nEnter New EmpName: ");
                        string EmpNameNew = Console.ReadLine();
                        foreach (Employee Emp in EmpList)
                        {
                            if (Emp.EmpId == EmpIDUpt) {
                                Emp.EmpName = EmpNameNew;
                                Console.WriteLine("Update completed");
                            }                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter EmpId of employee to be deleted: ");
                        string EmpIDDel = Console.ReadLine();
                        List<Employee> TempEmpList = new List<Employee>();
                        TempEmpList.AddRange(EmpList);
                        foreach (Employee Emp in EmpList)
                        {
                            if (Emp.EmpId == EmpIDDel)
                            {
                                TempEmpList.Remove(Emp);
                                Console.WriteLine("Delete completed");
                            }
                        }
                        EmpList = TempEmpList;
                        break;
                    case 4:
                        foreach (Employee Emp in EmpList) {
                            Console.WriteLine("EmpID: " + Emp.EmpId + "; EmpName: " + Emp.EmpName);
                        }                        
                        break;
                    case 5:break;
                }
            }            
        }
    }
}
