using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender)
            :base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            string className = this.GetType().Name.ToLower();
            return "Meow... I'm a " + className;
        }
    }
}
