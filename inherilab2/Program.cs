using System;

namespace inherilab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy pup = new Puppy();
            pup.Eat();
            pup.Bark();
            pup.Weep();
            Console.ReadLine();
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping");
        }
    }
}
