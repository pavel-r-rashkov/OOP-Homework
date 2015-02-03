using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    class AnimalsTest
    {
        static void Main(string[] args)
        {
            Kitten kitten = new Kitten("Sashka", 8);
            Tomcat tomcat = new Tomcat("Tom", 4);

            Console.WriteLine(kitten.AnimalGender);
            Console.WriteLine(tomcat.AnimalGender);
            Console.WriteLine("================");

            Dog dog = new Dog("Sharo", 5, Animal.Gender.Male);
            Frog frog = new Frog("Kurmit", 12, Animal.Gender.Male);

            List<ISound> list = new List<ISound> { kitten, tomcat, dog, frog };

            foreach(var animal in list)
            {
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
