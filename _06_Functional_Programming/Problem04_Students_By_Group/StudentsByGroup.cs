using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem04_Students_By_Group
{
    class StudentsByGroup
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studetnsGroup2 =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName ascending
                select student;

            foreach (var student in studetnsGroup2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
