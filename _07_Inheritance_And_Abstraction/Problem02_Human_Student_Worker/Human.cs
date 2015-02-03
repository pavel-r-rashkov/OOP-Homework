using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Human_Student_Worker
{
    abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("first name can't be null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("last name can't be null or empty");
                }
                this.lastName = value;
            }
        }

        protected Human(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
    }
}
