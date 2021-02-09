using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        public string firstName;
        public string lastName;
        public string address;
        public string birthDay;
        public string city;
        public string tName;
        public string course;
        public void GetStudentInformation()
        {
            Console.WriteLine("Enter the Student's First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the Student's Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the Student's Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter the Student's Birthday Date: ");
            birthDay = Console.ReadLine();
            Console.WriteLine("Enter the Student's city: ");
            city = Console.ReadLine();
        }

        public void GetTeacherInformation()
        {
            Console.WriteLine("Enter the Teacher's Name: ");
            tName = Console.ReadLine();
            Console.WriteLine("Enter the Course: ");
            course = Console.ReadLine();
            Console.WriteLine("Enter the Course: ");
            course = Console.ReadLine();
        }
        static void Main(string[] args)
        {
       
        }
    }
}
