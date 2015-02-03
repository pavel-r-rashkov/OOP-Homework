using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem02_Human_Student_Worker
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if(Regex.Match(value, "[^\\da-zA-Z]").Length > 0 || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("invalid number");
                }
                else
                {
                    this.facultyNumber = value;
                }
            }
        }

        public Student(string fname, string lname, string number)
            :base(fname, lname)
        {
            this.FacultyNumber = number;
        }
    }
}
