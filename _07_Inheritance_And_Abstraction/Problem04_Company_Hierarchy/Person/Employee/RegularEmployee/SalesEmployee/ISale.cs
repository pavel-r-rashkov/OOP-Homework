using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.SalesEmployee
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime SaleDate { get; }
        decimal ProductPrice { get; set; }
    }
}
