using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student:Person
    {
        public int course;

        public Student(string name, string lastname, DateTime birth, string faculty, int course):base(name, lastname, birth,faculty)
        {
            this.course = course;
        }

        public override void Info()
        {
            Console.WriteLine($"Student: {name}, {lastname}, Age: {Age()}, Faculty:{faculty}, Course: {course}");
        }
    }
}
