using Day_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Day_11
{
    class Employee
    { 
        public string employeeID {  get; set; }
        public string employeeName { get; set; }
        public double employeeSal { get; set; }
        public string deptID { get; set; }
    }

    class Department
    { 
        public string deptID { get; set; }
        public string departmentName { get; set; }
    }
    internal class LinqEmployee
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { employeeID = "Emp1", employeeName = "EmpName1", employeeSal = 15000, deptID = "Dept1" });
            employees.Add(new Employee() { employeeID = "Emp2", employeeName = "EmpName2", employeeSal = 5000, deptID = "Dept1" });
            employees.Add(new Employee() { employeeID = "Emp3", employeeName = "EmpName3", employeeSal = 10001, deptID = "Dept2" });
            List<Department> departments = new List<Department>();
            departments.Add(new Department() { deptID = "Dept1", departmentName = "IT" });
            departments.Add(new Department() { deptID = "Dept2", departmentName = "Sales" });
            var result = (from employee in employees
                         join d in departments 
                         on employee.deptID equals d.deptID 
                         where employee.employeeSal>10000 select new { employee.employeeName, d.departmentName }).ToList();
            foreach(var employeeDetail in result ) 
            {
                Console.WriteLine("Name: " + employeeDetail.employeeName + "; Dept: " + employeeDetail.departmentName);
            }
        }
       
    }
}
