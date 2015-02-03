using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.Manager
{
    class Manager : Employee, IManager
    {
        private HashSet<RegularEmployee.RegularEmployee> subjects;

        public HashSet<RegularEmployee.RegularEmployee> Subjects
        {
            get
            {
                return this.subjects;
            }
            set
            {
                this.subjects = value;
            }
        }

        public Manager(int id, string fname, string lname, decimal salary, Department department,
            HashSet<RegularEmployee.RegularEmployee> people)
            :base(id, fname, lname, salary, department)
        {
            this.Subjects = people;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            foreach(var subject in this.Subjects)
            {
                result.Append("\n" + subject.ToString());
            }

            return result.ToString();
        }
    }
}
