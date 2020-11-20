using System;

namespace Inherilab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dg = new Dog();
            dg.Eat();
            dg.Bark();
            Cat ct = new Cat();
            ct.Eat();
            ct.Meow();
            Console.ReadLine();
            
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking....");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing....");
        }
    }
}
