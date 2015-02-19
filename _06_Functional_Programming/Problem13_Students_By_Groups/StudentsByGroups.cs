using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem13_Students_By_Groups
{
    class StudentsByGroups
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            var studentsGroup =
                from student in students
                group student by student.GroupName into newGroup
                select newGroup;

            foreach (var group in studentsGroup)
            {
                Console.WriteLine("**********************");
                Console.WriteLine(group.Key);
                Console.WriteLine("**********************");
                foreach (var student in group)
                {
                    Console.Write(student + "\n");
                }
            }
        }
    }
}
