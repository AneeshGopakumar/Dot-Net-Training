using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Vehicle {
        public string model;
        static string vehicletype;
        //default consturctor
        public Vehicle()
        {
            this.model = "Tata " + vehicletype;
        }
        //parameterized constructor
        public Vehicle(string model) { 
            this.model = model + " " + vehicletype;
        }
        //Copy constructor
        public Vehicle(Vehicle vehicle)
        {
            this.model = vehicle.model + " " + vehicletype;
        }
        static Vehicle()
        {
            vehicletype = "Car";
        }
    }
    internal class ConstructorTypes
    {
        static void Main2(string[] args)
        {
            Vehicle v1 = new Vehicle();
            Console.WriteLine(v1.model);
            Vehicle v2 = new Vehicle("Honda");
            Console.WriteLine(v2.model);
            Vehicle v3 = new Vehicle(v1);
            Console.WriteLine(v3.model);
        }
    }
}
