using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem09_Filter_Students_By_Phone
{
    class FilterStudentsByPhone
    {
        static void Main(string[] args)
        {
            string[] phoneFilter = new string[] { "02", "+3592", "+359 2"};
            List<Student> students = SampleStudents.GetSampleStudents();
            var studetnsGroup =
                from student in students
                where phoneFilter.Any(filter => student.Phone.StartsWith(filter))
                select student;

            foreach (var student in studetnsGroup)
            {
                Console.WriteLine(student);
            }
        }
    }
}
