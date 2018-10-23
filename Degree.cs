using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UProgram
{
    class Degree
    {
        public string Title { get; set; }

        public Degree(string title)
        {
            this.Title = title;
        }

        public Course Course { get; set; }

        public void addCourse(Course course)
        {
            this.Course = course;
        }
    }
}
