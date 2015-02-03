using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.Developer
{
    class Project : IProject
    {
        public enum ProjectState
        {
            Open, Closed
        }

        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private ProjectState state;

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("project name can't be null or empty");
                }
                else
                {
                    this.projectName = value;
                }
            }
        }

        public  DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("details can't be null or empty");
                }
                else
                {
                    this.details = value;
                }
            }
        }

        public ProjectState State
        {
            get { return this.state; }
        }

        public Project(string name, string details)
        {
            this.ProjectName = name;
            this.Details = details;
            this.projectStartDate = DateTime.Now;
            this.state = ProjectState.Open;
        }

        public void CloseProject()
        {
            this.state = ProjectState.Closed;
        }

        public override string ToString()
        {
            return String.Format("Project name: {0}, Start date: {1}, State: {2}\n\tDetails: {3}",
                this.ProjectName, this.ProjectStartDate, this.State, this.Details);
        }
    }
}
