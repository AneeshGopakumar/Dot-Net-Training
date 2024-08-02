using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Employee
    {
        public int EmpId { get; set; }
        public double EmpSalary { get; set; }
        public string Name { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter Employee Id");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter Employee Salary");
            EmpSalary = Convert.ToDouble(Console.ReadLine());
        }
    }
    internal class GenericCOllections
    {
        public static void Main()
        {
            /*****************************Lists************************************/
            //List<int> myList=new List<int>();
            //for (int i = 0; i < 10; i++) {
            //    myList.Add(i);  
            //}

            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            /*List<Employee> emplist = new List<Employee>();
            for (int i = 0; i < 2; i++)
            {
                Employee obj = new Employee();
                obj.GetData();
                emplist.Add(obj);
            }
            foreach (var item in emplist)
            {
                Console.WriteLine("Employee ID: " + item.EmpId);
                Console.WriteLine("Employee Name: " + item.Name);
                Console.WriteLine("Employee Salary: " + item.EmpSalary);
            }*/


            /*****************************Dictionary************************************/
            Console.WriteLine("Dictionary");
            Dictionary<int,string> D1 = new Dictionary<int,string>();
            for (int i = 0; i < 2; i++) { 
                D1.Add(i,Convert.ToString(i));
            }
            foreach(var item in D1)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            /*****************************HashSet************************************/
            Console.WriteLine("HashSet");
            HashSet<string> H1 = new HashSet<string>();
            for (int i = 0; i < 2; i++)
            {
                H1.Add(Convert.ToString(i));
            }
            foreach (var item in H1)
            {
                Console.WriteLine(item);
            }

            /*****************************Queue************************************/
            Console.WriteLine("Queue");
            Queue<string> Q1 = new Queue<string>();
            for (int i = 0; i < 2; i++)
            {
                Q1.Enqueue(Convert.ToString(i));
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Q1.Dequeue());
            }

            /*****************************Stack************************************/
            Console.WriteLine("Stack");
            Stack<string> S1 = new Stack<string>();
            for (int i = 0; i < 2; i++)
            {
                S1.Push(Convert.ToString(i));
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(S1.Pop());
            }
        }
    }
}
