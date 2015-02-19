using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;


namespace Problem05_Students_By_Name
{
    class StudentsByName
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studetnsGroup =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in studetnsGroup2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
