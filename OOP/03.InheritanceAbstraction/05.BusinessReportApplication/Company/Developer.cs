using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    public class Developer : RegularEmployee,IDeveloper
    {
        private List<Project> projects;

        public Developer()
        {
            this.projects = new List<Project>();
        }

        public Developer(int id, string fname, string lname, string department, double salary,List<Project> projects)
            : base(id,fname,lname,department,salary)
        {
            this.Projects = projects;
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The projects list shouldn't be empty");
                }
                this.projects = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var project in Projects)
            {
                sb.Append(string.Format("\nProject name: {0}\nStart Date: {1}\nFinished: {2}\nDetails:{3}\n",project.Name,project.StartDate,project.State == "closed" ? "yes" : "no",project.Details));
            }

            return string.Format("Name: {0} {1}\nId: {2}\nDepartment:{3}\nSalary: {4:C}\n\nProjects:\n{5}",this.FirstName,this.LastName,this.ID,this.Department,this.Salary,sb);
        }
    }

}
