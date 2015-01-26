using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Learning_System.Person.Student
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim())) 
                {
                    throw new ArgumentException("Dropout reason cannot be null or empty");
                }
                this.dropoutReason = value;
            }
        }

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber,
            double averageScore, string dropoutReason)
            :base(firstName, lastName, age, studentNumber, averageScore)
        {
            this.DropoutReason = dropoutReason;
        }

        public void ReApply()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nDropout reason: {0}", this.DropoutReason);
        }
    }
}
