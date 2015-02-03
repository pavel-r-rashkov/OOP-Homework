using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.Developer
{
    class Developer : RegularEmployee, IDeveloper
    {
        private HashSet<Project> projects;

        public HashSet<Project> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                this.projects = value;
            }
        }

        public Developer(int id, string fname, string lname, decimal salary, Department department,
            HashSet<Project> projects)
                :base(id, fname, lname, salary, department)
        {
            this.Projects = projects;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString() + "\nProjects:");

            foreach(var project in this.Projects)
            {
                result.Append("\n\t" + project.ToString());
            }

            return result.ToString();
        }
    }
}
