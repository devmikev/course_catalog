using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UProgram
{
    class Course
    {
        public string Title { get; set; }

        public Course(string title)
        {
            this.Title = title;
        }

        List<Student> students = new List<Student>();

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public int getStudentCount()
        {
            return students.Count;
        }

        public Teacher Teacher { get; set; }

        public void addInstructor(Teacher teacher)
        {
            this.Teacher = teacher;
        }

        
    }
}
