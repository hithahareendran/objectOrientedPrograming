using System;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("Gunnar", "Meat");
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
            Console.ReadLine();
        }
    }
    public class Animal
    {
        public string Name { get; protected set; }
        public string FavouiteFood { get; protected set; }
        protected Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouiteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouiteFood}";
        }
    }
    public class Cat : Animal
    {
        public Cat(string name,string favouriteFood): base(name,favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "Meow";
        }
       

    }
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "Voof";
        }


    }

}
