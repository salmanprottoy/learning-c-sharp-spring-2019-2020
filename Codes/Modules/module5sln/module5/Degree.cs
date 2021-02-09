using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Degree
    {
        private string degreeName;
        private int totalCredits;
        private Course course;

        public Degree(string dName, int credits, Course course)
        {
            this.degreeName = dName;
            this.totalCredits = credits;
            this.course = course;
        }

        public string DegreeName
        {
            get { return this.degreeName; }
            set { if (value != null) { this.degreeName = value; } }
        }
        public int TotalCredits
        {
            get { return this.totalCredits; }
            set { if (value != null) { this.totalCredits = value; } }
        }
        public Course Course
        {
            get { return this.course; }
            set { if (value != null) { this.course = value; } }
        }

    }
}
