using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var uProgram = new UniversityProgram("Computer Science");
            var s1 = new Student("Mike", "Voloshin", 29, true);
            var s2 = new Student("Arnold", "Schwarzenegger", 28, false);
            var s3 = new Student("Jimmy", "Johns", 30, true);
            var course1 = new Course("COP1000");

            course1.addStudent(s1);
            course1.addStudent(s2);
            course1.addStudent(s3);

            var t1 = new Teacher("David", "Malan");

            course1.addInstructor(t1);

            var degree = new Degree("Bachelors");

            degree.addCourse(course1);

            uProgram.addDegree(degree);

            Console.WriteLine($"{uProgram.Degree.Title} of {uProgram.Title}");
            Console.WriteLine($"{uProgram.Degree.Course.Title}");
            Console.WriteLine($"There are {uProgram.Degree.Course.getStudentCount()} students enrolled");
        }
    }
}
