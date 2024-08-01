using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public abstract class Animal
    {
        public abstract string Sound { get; }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving in base class");
        }
    }

    public class Cat : Animal
    {
        public override string Sound => "Meow";
        public override void Move()
        {
            Console.WriteLine("Cat is moving in derived class");

        }
    }
    public class Dog : Animal
    {
        public override string Sound => "Bark";
        public override void Move()
        {
            Console.WriteLine("Dog is moving in derived class");

        }
    }
    public class Lion : Animal
    {
        public override string Sound => "Roar";
        
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Animal[] animals = new Animal[] { new Cat(), new Dog(), new Lion() };

            foreach (var anim in animals)
            {
                Console.WriteLine($"The {anim.GetType().Name} goes {anim.Sound}");
                anim.Move();
            }
        }
    }
}

