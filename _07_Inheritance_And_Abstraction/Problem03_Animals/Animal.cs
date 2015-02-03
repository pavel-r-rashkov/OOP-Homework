using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    abstract class Animal : ISound
    {
        public enum Gender
        {
            test, Male, Female
        }

        protected string name;
        protected int age;

        public Gender AnimalGender { get; private set; }
        
        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("animal's name can't be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("age can't be less than 1");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.AnimalGender = gender;
        }

        public abstract string ProduceSound();
    }
}
