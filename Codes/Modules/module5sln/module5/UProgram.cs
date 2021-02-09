using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module5
{
    class UProgram
    {
        private string programName;
        private string departmentHead;
        private Degree degree;

        public UProgram(string pName, string departmentH, Degree degree)
        {
            this.programName = pName;
            this.departmentHead = departmentH;
            this.degree = degree;
        }

        public string ProgramName
        {
            get { return this.programName; }
            set { if (value != null) { this.programName = value; } }
        }
        public string DepartmentHead
        {
            get { return this.departmentHead; }
            set { if (value != null) { this.departmentHead = value; } }
        }
        public Degree Degree
        {
            get { return this.degree; }
            set { if (value != null) { this.degree = value; } }
        }
    }
}
