using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem12_Students_Enrolled_2014
{
    class StudentsEnrolled2014
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studentsGroup =
                from student in students
                where student.FacultyNumber.ToString().EndsWith("14")
                select new { Marks = student.Marks };

            foreach (var student in studentsGroup)
            {
                foreach (var mark in student.Marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
