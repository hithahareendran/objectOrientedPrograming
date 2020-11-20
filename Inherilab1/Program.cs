using System;

namespace Inherilab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dg = new Dog();
            dg.Eat();
            dg.Bark();
            Console.ReadLine();
        }
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Eating");
            }
        }
       class Dog :Animal
        {
            public void Bark()
            {
                Console.WriteLine("Barking");
            }
        }
    }
}
