using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;
using System.Reflection;

namespace Problem11_Weak_Students
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = SampleStudents.GetSampleStudents();
            students.GetWeak();
        }
    }
}
