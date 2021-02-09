using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string birthDate;
            string addressLink1;
            string addressLink2;
            string city;
            string state;
            int zip;
            string country;
            string programName;
            string degreeName;
            int creditsRequired;
            string courseName;
            int credits;
            int durationWeeks;
            string teacher;

            Console.WriteLine("Student Information Input:");
            Console.WriteLine();
            Console.Write("First Name: ");
            firstName =  Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Birth Date: ");
            birthDate = Console.ReadLine();
            Console.Write("Address Link 1: ");
            addressLink1 = Console.ReadLine();
            Console.Write("Address Link 2: ");
            addressLink2 = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip: ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Country: ");
            country = Console.ReadLine();
            Console.Write("Programe Name: ");
            programName = Console.ReadLine();
            Console.Write("Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Credit Required: ");
            creditsRequired = Convert.ToInt32(Console.ReadLine());
            Console.Write("Course Name: ");
            courseName = Console.ReadLine();
            Console.Write("Credits: ");
            credits = Convert.ToInt32(Console.ReadLine());
            Console.Write("Duration in Weeks: ");
            durationWeeks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Teacher: ");
            teacher = Console.ReadLine();

            Console.WriteLine("\nStudent Information Output: ");
            Console.WriteLine();
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Date of Birth: " + birthDate);
            Console.WriteLine("Address Link 1: " + addressLink1);
            Console.WriteLine("Address Link 2: " + addressLink2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip: " + zip);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Programme Name: " + programName);
            Console.WriteLine("Degree Name: " + degreeName);
            Console.WriteLine("Credit Required: " + creditsRequired);
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Credits: " + credits);
            Console.WriteLine("Duration In Weeks: " + durationWeeks);
            Console.WriteLine("Teacher: " + teacher);
        }
    }
}
