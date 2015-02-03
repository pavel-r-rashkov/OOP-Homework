using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.SalesEmployee
{
    interface ISalesEmployee : IRegularEmployee
    {
        HashSet<Sale> Sales { get; set; }
    }
}
