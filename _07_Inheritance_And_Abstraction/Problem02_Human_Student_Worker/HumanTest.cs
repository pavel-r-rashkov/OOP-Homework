using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Human_Student_Worker
{
    class HumanTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", "abcd12"),
                new Student("Petur", "Ivanov", "ooji43"),
                new Student("Sashko", "Ivanov", "poipo21"),
                new Student("Goshko", "Ivanov", "cvbcg9809"),
                new Student("Ivan1", "awad", "980980"),
                new Student("Ivan2", "qweqwe", "73834"),
                new Student("Ivan3", "vbbvvb", "343452"),
                new Student("Ivan4", "kiiki", "djewi23"),
                new Student("Ivan5", "koko1212", "eir2342"),
                new Student("Ivan6", "oiui3443", "koji09")
            };

            IEnumerable<Student> orderedStudents = students.OrderBy(student => student.FacultyNumber);

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Ivan6", "oiui3443", 400, 8),
                new Worker("Ivan3", "vbbvvb", 600, 7),
                new Worker("Ivan4", "kiiki", 350, 6),
                new Worker("Ivan5", "koko1212", 420, 7),
                new Worker("Goshko", "Ivanov", 450.5M, 7),
                new Worker("Petur", "Ivanov", 500, 8),
                new Worker("Ivan1", "awad", 200, 4),
                new Worker("Ivan2", "qweqwe", 230, 5),
                new Worker("Sashko", "Ivanov", 300, 6),
                new Worker("Ivan", "Ivanov", 345.5M, 6)
            };

            IEnumerable<Worker> orderedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

            var merged = from student in students
                         join worker in workers on student.FirstName + student.LastName equals worker.FirstName + worker.LastName
                         orderby student.FirstName + student.LastName
                         select new {FirstName = student.FirstName, Number = student.FacultyNumber, Payment = worker.MoneyPerHour()};

            foreach(var human in merged)
            {
                Console.WriteLine("{0} {1} {2}", human.FirstName, human.Number, human.Payment);
            }
        }
    }
}
