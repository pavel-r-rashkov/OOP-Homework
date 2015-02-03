using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    class SchoolSystemTest
    {
        static void Main(string[] args)
        {
            School school = new School("School Name");
            Class myClass = new Class("First class");

            school.AddClass(myClass);
            
            /*
            This code should throw an Exception because there is a class with this identifier.
            Class mySecondClass = new Class("First class");
            school.AddClass(mySecondClass);
            */

            Teacher teacher = new Teacher("Pesho");
            Discipline discipline = new Discipline("Math", 5);
            teacher.AddDiscipline(discipline);
            myClass.AddTeacher(teacher);

            Student student = new Student("Goshko");
            myClass.AddStudent(teacher, discipline, student);
            Console.WriteLine(student.Id);

            Student student2 = new Student("Sashko");
            myClass.AddStudent(teacher, discipline, student2);
            Console.WriteLine(student2.Id);

            Teacher secondTeacher = new Teacher("Ivan");

            /*
            This code should throw an Exception because secondTeacher is not teaching in this class.
            myClass.AddStudent(secondTeacher, discipline, student);
            */
        }
    }
}
