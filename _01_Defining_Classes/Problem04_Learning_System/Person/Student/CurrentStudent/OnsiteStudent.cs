using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Learning_System.Person.Student.CurrentStudent
{
    class OnsiteStudent : CurrentStudent
    {
        private int numberVisits;

        public int NumberVisits
        {
            get
            {
                return this.numberVisits;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of visits cannot ne negative");
                }
                this.numberVisits = value;
            }
        }

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageScore, int visits)
            :base(firstName, lastName, age, studentNumber, averageScore)
        {
            this.NumberVisits = visits;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", Visits: {0}", this.NumberVisits);
        }
    }
}
