using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Student_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pesho", 20);

            student.PropertyChanged += new ProperyChangedEventHandler(Function);

            student.Name = "Gosho";
            student.Age = 22;
        }

        public static void Function(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    args.PropertyName, args.OldValue, args.NewValue);
        }
    }
}
