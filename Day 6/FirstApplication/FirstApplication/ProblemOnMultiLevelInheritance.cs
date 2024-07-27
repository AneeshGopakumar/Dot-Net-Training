using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Person_
    {
        protected int age;
        public void Greet() 
        {
            Console.WriteLine("Hello!");
        }
        public int SetAge(int age)
        {
            this.age = age;
            return this.age;
        }
    }
    class Teacher : Person_
    {
        public void Explain() {
            Console.WriteLine("I'm explaining.");
        }
    }
    class Student : Person_
    {
        public void Study()
        {
            Console.WriteLine("I'm studying.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age + " years old.");
        }
    }
    internal class StudentProfessorTest
    {
        public static void Main2()
        {
            Console.WriteLine("From person - ");
            Person_ P1 = new Person_();            
            P1.Greet();
            Console.WriteLine("From student - ");
            Student Student = new Student();
            Student.SetAge(12);
            Student.Greet();
            Student.ShowAge();
            Console.WriteLine("From teacher - ");
            Teacher Teacher = new Teacher();
            Teacher.SetAge(42);
            Teacher.Greet();
            Teacher.Explain();
        }
    }
}
