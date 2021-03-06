using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end")
            {


                string[] elements = input.Split();

                string firstName = elements[0];
                string lastName = elements[1];
                int age = int.Parse(elements[2]);
                string city = elements[3];

                if (AlreadyExist(students, firstName, lastName))
                {
                    GetStudent(students, firstName, lastName, age, city);
                  
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };

                    students.Add(student);

                }

                input = Console.ReadLine();
            }

            string cityFilter = Console.ReadLine();

            List<Student> filteredStudents = students.Where(s => s.City == cityFilter).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

            

        }

        static bool AlreadyExist(List<Student> students, string firstName, string lastName)
        {

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }

            }

            return false;
        }

        static void GetStudent(List<Student> students, string firstName, string lastName, int age, string city)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;

                }

            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }


    }
}
