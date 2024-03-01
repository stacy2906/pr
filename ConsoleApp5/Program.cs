using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            people.Add(new Applicant("John", "Doe", new DateTime(2000, 7, 15), "Engineering"));
            people.Add(new Student("Alice", "Smith", new DateTime(1998, 3, 20), "Physics", 3));
            people.Add(new Teacher("Bob", "Johnson", new DateTime(1985, 9, 10), "Mathematics", "Professor", 10));

            foreach (Person person in people)
            {
                person.Info();
            }

            int minAge = 20;
            int maxAge = 30;

            Console.WriteLine($"\nPeople aged between {minAge} and {maxAge} years:");
            foreach (Person person in people)
            {
                if (person.Age() >= minAge && person.Age() <= maxAge)
                {
                    person.Info();
                }
            }

            Console.ReadKey();
        }
    }
}