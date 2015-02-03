using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person
{
    abstract class Person : IPerson
    {
        protected int id;
        protected string firstName;
        protected string lastName;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Id can't be negative or 0");
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("first name can't be null or empty");
                }
                else
                {
                    this.firstName = value;
                }
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
                else
                {
                    this.lastName = value;
                }
            }
        }

        protected Person(int id, string fname, string lname)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, First name: {1}, Last name: {2}", 
                this.Id, this.FirstName, this.LastName);
        }
    }
}
