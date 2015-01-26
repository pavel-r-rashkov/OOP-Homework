using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Learning_System.Person
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim())) {
                    throw new ArgumentException("First name cannot be null or empty");
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
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Last name cannot be null or empty");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value <= 0) 
                {
                    throw new ArgumentOutOfRangeException("Age cannot be 0 or negative");
                }
                this.age = value;
            }
        }

        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("First name: {0}, Last name: {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
