using System;
using System.Collections.Generic;
using System.Linq;

namespace Encap1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split(" ");
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            // persons.ForEach(p => Console.WriteLine(p.ToString()));

            persons.OrderBy(p => p.FirstName)
              .ThenBy(p => p.Age)
               .ToList()
                 .ForEach(p => Console.WriteLine(p.ToString()));

            Console.ReadLine();


        }
    }
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string FirstName
        {
            get { return this.firstName; }
        }
        public int Age
        {
            get { return this.age; }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} {this.age} years old.";
        }

    }
    
}
