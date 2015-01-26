using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Invalid age");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email");
                }
                else
                {
                    this.email = value;
                }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email)
            :this(name, age)
        {
            this.Email = email;
        }

        public override string ToString()
        {
            string result = String.Format("{0}, {1}", Name, Age);
            if (!String.IsNullOrEmpty(this.email))
            {
                result += ", " + email;
            }
            return result;
        }
    }
}
