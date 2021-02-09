using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Snow", new DateTime(1990, 10, 22), "john@mail.com");
            Student student2 = new Student("Jaime", "Lanyster", new DateTime(1950, 03, 12), "jaime@mail.com");
            Student student3 = new Student("Walter", "White", new DateTime(1975, 12, 27), "walter@mail.com");

            Course course = new Course("Programming with C#", 15);

            course.addStudent(student1);
            course.addStudent(student2);
            course.addStudent(student3);

            Teacher teacher = new Teacher("Jessie", "Pinkman", new DateTime(1985, 04, 03), "jessie@mail.com");

            course.addTeacher(teacher);

            Degree degree = new Degree("Bachelor of Science", 250, null);

            degree.Course = course;

            UProgram uProgram = new UProgram("Information Technology", "Gustavo Fring", null);

            uProgram.Degree = degree;

            Console.WriteLine("The {0} program contains the {1} degree\n", uProgram.ProgramName, degree.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}\n", degree.DegreeName, course.CourseName);
            Console.WriteLine("The {0} course contains {1} student(s)\n", course.CourseName, course.StudentsNumber);
        }
    }
}
