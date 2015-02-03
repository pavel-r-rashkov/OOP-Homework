using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    class School
    {
        private string name;

        public HashSet<Class> Classes { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("School name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public School(string name)
        {
            this.Name = name;
            this.Classes = new HashSet<Class>();
        }

        public void AddClass(Class classObj)
        {
            if(this.Classes.Any(c => c.Identifier == classObj.Identifier))
            {
                throw new ArgumentException("This school already have class with this identifier");
            }
            this.Classes.Add(classObj);
        }
    }
}
