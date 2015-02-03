using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    class Class : IDetail
    {
        private int lastStudentId;
        private string details;
        private string identifier;

        public string Identifier 
        { 
            get
            {
                return this.identifier;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Class identifier cannot be null or empty");
                }
                this.identifier = value;
            }
        }

        public HashSet<Teacher> Teachers { get; private set; }
        
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
        
        public Class(string identifier)
        {
            this.Teachers = new HashSet<Teacher>();
            this.Identifier = identifier;
            this.lastStudentId = 0;
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void AddStudent(Teacher teacher, Discipline discipline, Student student)
        {
            if(!this.Teachers.Contains(teacher))
            {
                throw new ArgumentException("This teacher is not from this class");
            }
            else if(!this.Teachers.First(t => t == teacher).Disciplines.Contains(discipline))
            {
                throw new ArgumentException("This discipline is not teached by this teacher");
            }
            else
            {
                Discipline dis = this.Teachers.First(t => t == teacher).Disciplines.First(d => d == discipline);
                student.Id = this.GenerateStudentId();
                dis.AddStudent(student);   
            }
        }

        private int GenerateStudentId()
        {
            return ++this.lastStudentId;
        }
    }
}
