using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Student
{
    public static class SampleStudents
    {
        public static List<Student> GetSampleStudents()
        {
            return new List<Student>() { 
                new Student("Ivan", "Ivanov", 14, 123123, "+3592 22 22 22", "aa@abv.bg", 1, "group1", 2, 2, 6),
                new Student("Petur", "Ivanov", 23, 131214, "+23592 22 22 22", "aa@abv.bg", 4, "group4", 3, 4, 6),
                new Student("Ivan", "Petrov", 23, 123114, "+359 2 23 22 22", "aa@abv.bg", 2, "group2", 3, 5, 6),
                new Student("AIvan", "BIvanov", 26, 123125, "02 22 22 22", "aa@gmail.com", 2, "group2", 3, 4),
                new Student("AIvan", "CIvanov", 23, 123134, "+43592 22 22 22", "aa@abv.bg", 4, "group4", 3, 4, 6),
            };
        }
    }
}
