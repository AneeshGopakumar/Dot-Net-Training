using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    interface IVehicle
    {
        protected void Drive() { }
        protected bool Refuel(int gasolineRefuel) { return true;}
    }
    class Car : IVehicle
    {
        protected int currentGasolineLevel;
        public Car(int currentGasolineLevel)
        {
            this.currentGasolineLevel = currentGasolineLevel;
        }
        public void Drive() {
            Console.WriteLine("Current gasoline level: " + currentGasolineLevel);
            if (currentGasolineLevel == 0)
            {
                Console.WriteLine("Enter refuel amount: ");
                int gasolineRefuel = int.Parse(Console.ReadLine());
                Refuel(gasolineRefuel);
            }
            Console.WriteLine("Car is driving");
        }
        bool Refuel(int gasolineRefuel)
        {
            currentGasolineLevel = currentGasolineLevel + gasolineRefuel;
            Console.WriteLine("Refuel completed. New gasoline level: " + currentGasolineLevel);
            return true;
        }
    }
    internal class ProblemInterfaces
    {
        public static void Main() 
        {
            Car C1 = new Car(0);
            C1.Drive();
        }
    }
}
