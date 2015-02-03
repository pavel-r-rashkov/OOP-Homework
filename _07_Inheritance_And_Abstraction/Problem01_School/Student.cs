using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    class Student : Person
    {
        private int id;

        public int Id 
        { 
            get
            {
                return this.id;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Stundent id cannot be negative or 0");
                }
                this.id = value;
            }
        }

        public Student(string name)
            :base(name)
        {
        }
    }
}
