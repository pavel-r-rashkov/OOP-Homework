using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    abstract class Person : IDetail
    {
        private string name;
        private string details;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Person's name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Details cannot be null or empty");
                }
                this.details = value;
            }
        }

        protected Person(string name)
        {
            this.Name = name;
        }
    }
}
