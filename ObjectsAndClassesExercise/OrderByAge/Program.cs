using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            List<Person> people = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] elements = command.Split();
                Person person = new Person(elements[0], elements[1], int.Parse(elements[2]));
                people.Add(person);
            }

            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}
