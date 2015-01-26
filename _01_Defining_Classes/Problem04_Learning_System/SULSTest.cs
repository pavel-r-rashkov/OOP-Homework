using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_Learning_System.Person;
using Problem04_Learning_System.Person.Trainer;
using Problem04_Learning_System.Person.Student;
using Problem04_Learning_System.Person.Student.CurrentStudent;


namespace Problem04_Learning_System
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            List<Person.Person> persons = new List<Person.Person> {
                new JuniorTrainer("Gosho", "Goshev", 18),
                new SeniorTrainer("Ivan", "Ivanov", 28),
                new GraduateStudent("Tosho", "Toshev", 22, 121212, 78.4),
                new OnlineStudent("Pesho", "Peshev", 26, 232323, 89.3),
                new OnsiteStudent("Sasho", "Sashev", 26, 565656, 98.3, 12),
                new DropoutStudent("Petur", "Petrov", 24, 787878, 67.5, "Too smart"),
                new OnsiteStudent("Georgi", "Georgiev", 24, 909090, 102.3, 10)
            };

            var currentStudents = persons.Where(x => x is CurrentStudent).OrderByDescending(x => (x as CurrentStudent).AverageScore);

            foreach(var student in currentStudents) 
            {
                Console.WriteLine(student);
            }
      
        }
    }
}
