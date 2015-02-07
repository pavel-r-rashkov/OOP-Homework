using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Student_Class
{
    public delegate void ProperyChangedEventHandler(object source, PropertyChangedEventArgs e);

    class Student
    {
        private string name;
        private int age;
        public event ProperyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be null or empty");
                }
                else
                {
                    OnPropertyChanged(new PropertyChangedEventArgs("Name", this.name, value));
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age can't be 0 or negative");
                }
                else
                {
                    OnPropertyChanged(new PropertyChangedEventArgs("Age", this.age.ToString(), value.ToString()));
                    this.age = value;
                }
            }
        }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
     
        protected void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }
    }
}
