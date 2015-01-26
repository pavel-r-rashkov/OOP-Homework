using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Learning_System.Person.Student.CurrentStudent
{
    abstract class CurrentStudent : Student
    {
        protected CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageScore)
            :base(firstName, lastName, age, studentNumber, averageScore)
        {
        }
    }
}
