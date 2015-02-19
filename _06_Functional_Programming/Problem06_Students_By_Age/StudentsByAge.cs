using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem06_Students_By_Age
{
    class StudentsByAge
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studetnsGroup =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };

            foreach (var student in studetnsGroup)
            {
                Console.WriteLine("first name: {0}\nlast name: {1}\nage: {2}\n===========\n", 
                    student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
