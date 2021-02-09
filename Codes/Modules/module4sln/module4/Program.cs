using System;

namespace module4
{
    class TestProgram
    {
        public struct Student
        {
            public string studentFirstName;
            public string studentLastName;
            public DateTime studentBirthDate;
            public string studentAddress;
            public string studentCity;
            public string studentState;
            public string studentZip;
            public string studentCountry;
            public string studentEmail;

            public Student(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zip, string country, string email)
            {
                this.studentFirstName = firstName;
                this.studentLastName = lastName;
                this.studentBirthDate = birthday;
                this.studentAddress = address;
                this.studentCity = city;
                this.studentState = state;
                this.studentZip = zip;
                this.studentCountry = country;
                this.studentEmail = email;
            }
        }

        public struct Teacher
        {
            public string teacherFirstName;
            public string teacherLastName;
            public DateTime teacherBirthDate;
            public string teacherAddress;
            public string teacherCity;
            public string teacherState;
            public string teacherZip;
            public string teacherCountry;
            public string teacherEmail;

            public Teacher(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zip, string country, string email)
            {
                this.teacherFirstName = firstName;
                this.teacherLastName = lastName;
                this.teacherBirthDate = birthday;
                this.teacherAddress = address;
                this.teacherCity = city;
                this.teacherState = state;
                this.teacherZip = zip;
                this.teacherCountry = country;
                this.teacherEmail = email;
            }
        }

        public struct Program
        {

            public string programName;
            public string degreeName;
            public string departmentHead;

            public Program(string program, string degree, string departmentHead)
            {
                this.programName = program;
                this.degreeName = degree;
                this.departmentHead = departmentHead;
            }
        }

        public struct Course
        {
            public string courseName;
            public string programName;
            public int courseCredits;

            public Course(string name, string program, int credits)
            {
                this.courseName = name;
                this.programName = program;
                this.courseCredits = credits;
            }
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            Student student = new Student("Salman", "Prottoy", new DateTime(1998,11,10), "dhaka", "dhaka", "dhaka", "1229", "Bangladesh", "salman.prottoy@gmail.com");
            students[0] = student;

            Console.WriteLine("\nStudent Information: \n");
            Console.WriteLine("FirstName: " + students[0].studentFirstName);
            Console.WriteLine("LastName: " + students[0].studentLastName);
            Console.WriteLine("BirthDate: " + students[0].studentBirthDate);
            Console.WriteLine("Address: " + students[0].studentAddress);
            Console.WriteLine("City: " + students[0].studentCity);
            Console.WriteLine("State: " + students[0].studentState);
            Console.WriteLine("Zip: " + students[0].studentZip);
            Console.WriteLine("Country: " + students[0].studentCountry);
            Console.WriteLine("Email: " + students[0].studentEmail);

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("\nEnter Data for Student {0}: ", (i+1));
                Console.WriteLine("Enter the student's first name: ");
                students[i].studentFirstName = Console.ReadLine();
                Console.WriteLine("Enter the student's last name: ");
                students[i].studentLastName = Console.ReadLine();
                Console.WriteLine("Enter the student's birthday (dd/mm/yyyy): ");
                students[i].studentBirthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student's address: ");
                students[i].studentAddress = Console.ReadLine();
                Console.WriteLine("Enter the student's city: ");
                students[i].studentCity = Console.ReadLine();
                Console.WriteLine("Enter the student's state: ");
                students[i].studentState = Console.ReadLine();
                Console.WriteLine("Enter the student's zip: ");
                students[i].studentZip = Console.ReadLine();
                Console.WriteLine("Enter the student's country: ");
                students[i].studentCountry = Console.ReadLine();
                Console.WriteLine("Enter the student's email: ");
                students[i].studentEmail = Console.ReadLine();
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("\nStudent {0} Information: ", (i+1));
                Console.WriteLine("FirstName: " + students[i].studentFirstName);
                Console.WriteLine("LastName: " + students[i].studentLastName);
                Console.WriteLine("BirthDate: " + students[i].studentBirthDate);
                Console.WriteLine("Address: " + students[i].studentAddress);
                Console.WriteLine("City: " + students[i].studentCity);
                Console.WriteLine("State: " + students[i].studentState);
                Console.WriteLine("Zip: " + students[i].studentZip);
                Console.WriteLine("Country: " + students[i].studentCountry);
                Console.WriteLine("Email: " + students[i].studentEmail);
            }
        }
    }
}
