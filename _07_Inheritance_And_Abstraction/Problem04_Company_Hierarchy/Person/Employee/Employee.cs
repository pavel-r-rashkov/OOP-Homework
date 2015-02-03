using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee
{
    abstract class Employee : Person, IEmployee
    {
        public enum Department
        {
            Production, Accounting, Sales, Marketing
        }

        protected decimal salary;
        protected Department employeeDepartment;

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("salary can't be negative");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public Department EmployeeDepartment
        {
            get
            {
                return this.employeeDepartment;
            }
            set
            {
                this.employeeDepartment = value;
            }
        }

        protected Employee(int id, string fname, string lname, decimal salary, Department department)
            :base(id, fname, lname)
        {
            this.Salary = salary;
            this.EmployeeDepartment = department;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\nSalary: {0}, Department: {1}", this.Salary, this.EmployeeDepartment);
        }
    }
}
