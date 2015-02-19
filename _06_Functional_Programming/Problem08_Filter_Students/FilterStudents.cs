using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem08_Filter_Students
{
    class FilterStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studetnsGroup =
                from student in students
                where student.Email.EndsWith("@abv.bg")
                select student;

            foreach (var student in studetnsGroup)
            {
                Console.WriteLine(student);
            }
        }
    }
}
