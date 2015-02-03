using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    class Discipline : IDetail
    {
        private string name;
        private int numberOfLectures;
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
                    throw new ArgumentException("Discipline name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be 0 or negative");
                }
                this.numberOfLectures = value;
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
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Details cannot be null or empty");
                }
                this.details = value;
            }
        }

        public HashSet<Student> Students { get; private set; }

        public Discipline(string name, int numberOfLectures)
        {
            this.Name = name;
            this.numberOfLectures = numberOfLectures;
            this.Students = new HashSet<Student>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }
    }
}
