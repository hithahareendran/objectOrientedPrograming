using System;
using System.Collections.Generic;

namespace Encap4
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            Team team = new Team("Lexicon");
            foreach(Person p in persons)
            {
                team.Addplayer(p);
            }
            Console.WriteLine("First team has {0} players", team.FirstTeam.Count);
            Console.WriteLine("Reserve team has {0} players", team.ReserveTeam.Count);
            Console.ReadLine();
 
        }
        
    }
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
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

                if (value.Length < 3)
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
                this.age = value;
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
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
            this.name = name;
        }
        public List<Person>FirstTeam
        {
            get { return this.firstTeam; }
        }
        public List<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }
        public void Addplayer(Person player)
        {
            if(player.Age<40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }

    }

