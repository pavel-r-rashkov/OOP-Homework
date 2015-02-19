using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem11_Weak_Students
{
    public static class ListExtension
    {
        public static void GetWeak(this List<Student> students)
        {
            var studentsGroup =
                from student in students
                where student.Marks.FindAll(mark => mark == 2).Count == 2
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in studentsGroup)
            {
                Console.Write(student.FullName);

                foreach (int mark in student.Marks)
                {
                    Console.Write(" " + mark);
                }
                Console.WriteLine();
            }
        }
    }
}
