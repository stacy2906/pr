using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Teacher:Person
    {
        public string position;
        public int experience;

        public Teacher(string name, string lastname, DateTime birth, string faculty, string position, int experience) : base(name, lastname, birth, faculty)
        {
            this.position = position;
            this.experience = experience;
        }

        public override void Info()
        {
            Console.WriteLine($"Teacher: {name}, {lastname}, Age: {Age()}, Faculty:{faculty}, Position: {position}, Experience: {experience}");
        }
    }
}
