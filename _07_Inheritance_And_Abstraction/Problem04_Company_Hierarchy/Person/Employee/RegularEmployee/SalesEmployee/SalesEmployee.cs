using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.SalesEmployee
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private HashSet<Sale> sales;

        public HashSet<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public SalesEmployee(int id, string fname, string lname, decimal salary, Department department,
            HashSet<Sale> sales)
                :base(id, fname, lname, salary, department)
        {
            this.Sales = sales;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString() + "\nSales:");

            foreach (var sale in this.Sales)
            {
                result.Append("\n\t" + sale.ToString());
            }

            return result.ToString();
        }
    }
}
