using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Person {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
        ~Person()
        {
            Name = String.Empty;
        }
        //Run time polymorphism using override
        public override string ToString()
        {
            return ("Hello! My name is " + Name);
        }
        //Data hiding using new
        //new public string ToString()
        //{
        //return ("Hello! My name is " + Name);
        //}
    }
    internal class PersonNames
    {
        static void Main2(string[] args)
        {
            Person[] ArrPersons = new Person[3];
            string PersonName;
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("\nEnter Name of Person " + (i+1) + ": ");
                PersonName = Console.ReadLine();
                ArrPersons[i] = new Person(PersonName);                
            }
            for (int i = 0; i < ArrPersons.Length; i++)
            {
                Console.WriteLine(ArrPersons[i].ToString());
            }

        }
    }
}
