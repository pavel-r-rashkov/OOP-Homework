using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem03_Student;

namespace Problem14_Students_Specialties
{
    class StudentsSpecialtiesTest
    {
        static void Main(string[] args)
        {
            List<StudentsSpecialties> specialties = new List<StudentsSpecialties>{
                new StudentsSpecialties("Web Developer", 123123),
                new StudentsSpecialties("Web Developer", 123114),
                new StudentsSpecialties("PHP Developer", 131214),
                new StudentsSpecialties("QA Developer", 123125),
                new StudentsSpecialties("PHP Developer", 123134)
            };

            List<Student> students = SampleStudents.GetSampleStudents();
            var studentsGroup =
                from specialty in specialties
                join student in students
                    on specialty.FacNum equals student.FacultyNumber
                select new { Name = student.FirstName + " " + student.LastName, FacNum = specialty.FacNum, Specialty = specialty.SpecialtyName};

            foreach (var student in studentsGroup)
            {
                Console.WriteLine("name: {0}, f num: {1}, specialty: {2}", student.Name, student.FacNum, student.Specialty);
            }
        }
    }
}
