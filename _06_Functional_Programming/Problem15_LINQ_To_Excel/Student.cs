using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15_LINQ_To_Excel
{
    class Student
    {
        public enum Gender
        {
            Male, Female
        }

        public enum StudentType
        {
            Onsite, Online
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender StudentGender { get; set; }
        public StudentType Type { get; set; }
        public int ExamScore { get; set; }
        public int HomeworkSent { get; set; }
        public int HomeworkEvaluated { get; set; }
        public double TeamworkScore { get; set; }
        public int Attendances { get; set; }
        public double Bonus { get; set; }
        public double Result { get; private set; }

        public Student(int id, string fname, string lname, string email, Gender gender, StudentType type, int exam,
            int homeworkSent, int homeworkEvaluated, double teamworkScore, int attendances, double bonus)
        {
            this.Id = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.StudentGender = gender;
            this.Type = type;
            this.ExamScore = exam;
            this.HomeworkSent = homeworkSent;
            this.HomeworkEvaluated = homeworkEvaluated;
            this.TeamworkScore = teamworkScore;
            this.Attendances = attendances;
            this.Bonus = bonus;
            this.Result = CalculateResult();
        }

        private double CalculateResult()
        {
            return (this.ExamScore + this.HomeworkSent + this.HomeworkEvaluated + 
                this.TeamworkScore + this.Attendances + this.Bonus) / 5;
        }

        public override string ToString()
        {
            return this.Id.ToString() + " " + this.FirstName + " " + this.Result;
        }
    }
}
