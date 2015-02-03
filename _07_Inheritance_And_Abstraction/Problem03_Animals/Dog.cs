using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, Gender gender)
            :base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string className = this.GetType().Name.ToLower();
            return "Woof... I'm a " + className; 
        }
    }
}
