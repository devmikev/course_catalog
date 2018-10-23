using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UProgram
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age  { get; set; }
        public bool InState { get; set; }


        public Student(string firstName, string lastName, int age, bool inState)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.InState = inState;
        }
    }
}
