using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Person
    {
        protected string name;
        protected string lastname;
        protected DateTime birth;
        protected string faculty;

        public Person(string name, string lastname, DateTime birth, string faculty)
        { 
            this.name = name;
            this.lastname = lastname;
            this.birth = birth;
            this.faculty = faculty;
        }

        public abstract void Info();

        public int Age()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birth.Year;
            if (now < birth.AddYears(age))
                age--;
            return age;
        }

    }
}
