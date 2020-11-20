using System;

namespace PersonInfo
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name and Age");
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }
    }
    class Citizen :IPerson
    {
        private string name;
         private int age;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value;}
        }
        public Citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
