using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee
{
    abstract class RegularEmployee : Employee, IRegularEmployee
    {
        protected RegularEmployee(int id, string fname, string lname, decimal salary, Department department)
            :base(id, fname, lname, salary, department)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
