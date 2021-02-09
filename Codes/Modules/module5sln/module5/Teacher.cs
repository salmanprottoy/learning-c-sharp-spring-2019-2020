using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class Teacher
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string email;

        public Teacher(string fName, string lName, DateTime birthDate, string email)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthDate = birthDate;
            this.email = email;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { if (value != null) { this.firstName = value; } }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { if (value != null) { this.lastName = value; } }
        }
        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { if (value != null) { this.birthDate = value; } }
        }
        public string Email
        {
            get { return this.email; }
            set { if (value != null) { this.email = value; } }
        }
    }
}
