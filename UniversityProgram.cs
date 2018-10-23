using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UProgram
{
    class UniversityProgram
    {
        public string Title { get; set; }

        public UniversityProgram(string title)
        {
            this.Title = title;
        }

        public Degree Degree { get; set; }

        public void addDegree(Degree degree)
        {
            this.Degree = degree;
        }








    }
}
