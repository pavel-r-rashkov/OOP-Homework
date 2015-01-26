using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Learning_System.Person.Trainer
{
    abstract class Trainer : Person
    {
        protected Trainer(string firstName, string lastName, int age)
            :base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course created!", courseName);
        }
    }
}
