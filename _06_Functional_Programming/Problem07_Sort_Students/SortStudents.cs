using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem07_Sort_Students
{
    class SortStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studetnsGroup =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            /*foreach (var student in studetnsGroup)
            {
                Console.WriteLine(student);
            } */
            
            var ordered = students.OrderByDescending(student => student.FirstName)
            .ThenByDescending(student => student.LastName);

            foreach (var student in ordered)
            {
                Console.WriteLine(student);
            }
        }
    }
}
