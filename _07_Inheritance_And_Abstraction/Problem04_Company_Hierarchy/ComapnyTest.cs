using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_Company_Hierarchy.Person.Employee;
using Problem04_Company_Hierarchy.Person.Employee.Manager;
using Problem04_Company_Hierarchy.Person.Employee.RegularEmployee;
using Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.SalesEmployee;
using Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.Developer;

namespace Problem04_Company_Hierarchy
{
    class ComapnyTest
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            HashSet<Sale> sales = new HashSet<Sale>();
            sales.Add(new Sale("Apple", 0.80M));
            sales.Add(new Sale("Orange", 0.90M));
            SalesEmployee salesEmployee = new SalesEmployee(12, "Ivan", "Ivanov", 900M, Employee.Department.Marketing, sales);

            HashSet<Project> projects = new HashSet<Project>();
            projects.Add(new Project("Secret project", "TOP SECRET"));
            Developer dev = new Developer(9, "Pesho", "Peshev", 1200M, Employee.Department.Production, projects);

            Manager manager = new Manager(10, "Gosho", "Goshev", 2000M, Employee.Department.Marketing, new HashSet<RegularEmployee>());

            employees.Add(salesEmployee);
            employees.Add(dev);
            employees.Add(manager);

            foreach(var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("======================================");
            }
        }
    }
}
