using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Course
    {
        private static int maxArraySize = 3;

        private string courseName;
        private int courseCredits;
        private Student[] students;
        private int studentsNumber;
        private Teacher[] teachers;
        private int teachersNumber;

        public Course(string cName, int credits)
        {
            this.courseName = cName;
            this.courseCredits = credits;
            this.students = new Student[maxArraySize];
            this.studentsNumber = 0;
            this.teachers = new Teacher[maxArraySize];
            this.teachersNumber = 0;
        }

        public string CourseName
        {
            get { return this.courseName; }
            set { if (value != null) { this.courseName = value; } }
        }
        public int CourseCredits
        {
            get { return this.courseCredits; }
            set { if (value != null) { this.courseCredits = value; } }
        }
        public int StudentsNumber
        {
            get { return this.studentsNumber; }
        }
        public int TeachersNumber
        {
            get { return this.teachersNumber; }
        }

        public void addStudent(Student student)
        {
            int n = this.StudentsNumber;
            if (n < maxArraySize)
            {
                this.students[n] = student;
                this.studentsNumber++;
            }
            else
            {
                Console.WriteLine("Array of students is full.");
            }
        }
        public void addTeacher(Teacher teacher)
        {
            int n = this.TeachersNumber;
            if (n < maxArraySize)
            {
                this.teachers[n] = teacher;
                this.teachersNumber++;
            }
            else
            {
                Console.WriteLine("Array of teachers is full.");
            }
        }
    }
}
