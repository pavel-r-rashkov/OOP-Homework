using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee
{
    interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
        Employee.Department EmployeeDepartment { get; set; }
    }
}
