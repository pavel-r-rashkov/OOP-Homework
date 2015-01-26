using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Learning_System.Person.Student
{
    abstract class Student : Person
    {
        private int studentNumber;
        private double averageScore;

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if(value <= 0) 
                {
                    throw new ArgumentOutOfRangeException("Student number cannot be negative or 0");
                }
                this.studentNumber = value;
            }
        }

        public double AverageScore
        {
            get
            {
                return this.averageScore;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Score cannot be negative");
                }
                this.averageScore = value;
            }
        }

        protected Student(string firstName, string lastName, int age, int studentNumber, double averageScore)
            :base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageScore = averageScore;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Student ID: {0}, Score: {1}", this.StudentNumber, this.AverageScore);
        }
 
    }
}
