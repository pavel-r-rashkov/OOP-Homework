using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem15_LINQ_To_Excel
{
    class LINQtoExcel
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 1001;

            List<Student> students = new List<Student>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ASUS\Desktop\Students-data.txt");

            int length = lines.Length;
            for (int i = 1; i < length; i++)
            {
                string[] tokens = Regex.Split(lines[i], "[\\s]+");

                students.Add(new Student(int.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], (Student.Gender)Enum.Parse(typeof(Student.Gender), tokens[4]),
                    (Student.StudentType)Enum.Parse(typeof(Student.StudentType), tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8]),
                    double.Parse(tokens[9], CultureInfo.InvariantCulture), int.Parse(tokens[10]), double.Parse(tokens[11], CultureInfo.InvariantCulture)));
            }

            var onlineStudents =
                from student in students
                where student.Type == Student.StudentType.Online
                orderby student.Result descending
                select student;

            foreach(var student in onlineStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
}
