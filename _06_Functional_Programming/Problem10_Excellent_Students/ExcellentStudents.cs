using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem10_Excellent_Students
{
    class ExcellentStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studentsGroup =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
  
            foreach (var student in studentsGroup)
            {
                Console.Write(student.FullName);
                foreach(var mark in student.Marks)
                {
                    Console.Write(" " + mark);
                }
                Console.WriteLine();
            }
        }
    }
}
