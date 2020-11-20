using System;
using System.Collections.Generic;
using System.Linq;

namespace Encap3
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = 5;
            var persons = new List<Person>();
            for (int i = 1; i <=lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split(" ");
                try
                {


                    var person = new Person(cmdArgs[0],cmdArgs[1],int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            Console.ReadLine();
        }
    }
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName,string lastName,int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
             
                if(value.Length<3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 letters");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {

                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 letters");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age= value;
            }
        }
        public decimal Salary
        {
            get { return this.salary; }
            private set
            {

                if (value <= 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollars!");
                }
                this.salary = value;
            }
        }
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName}  {this.age} {this.salary} ";
        }
    }
}
