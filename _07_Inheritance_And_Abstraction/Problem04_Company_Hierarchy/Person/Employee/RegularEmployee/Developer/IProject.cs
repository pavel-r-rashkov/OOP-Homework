using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.Developer
{
    interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; }
        string Details { get; set; }
        Project.ProjectState State { get; }
        void CloseProject();
    }
}
