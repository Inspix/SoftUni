using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Project
    {
        private string name;
        private DateTime startDate;
        private string details;
        private bool state;

        public Project(string name, DateTime startingdate, string details, string state)
        {
            this.Name = name;
            this.StartDate = startingdate;
            this.Details = details;
            this.State = state;

        }

        public void CloseProject()
        {
            this.State = "closed";
        }


        public string State
        {
            get { return this.state ? "open" : "closed"; }
            set
            {
                if (value.ToLower() == "open")
                {
                    this.state = true;
                }
                else if (value.ToLower() == "closed")
                {
                    this.state = false;
                }
                else
                {
                    throw new ArgumentException("The project state should be open or closed");
                }
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.details = "N/A";
                }
                this.details = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                if (value < DateTime.MinValue)
                {
                    throw new Exception("Invalid project date");
                }
                this.startDate = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The poject name should contain characters..");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Project name:{0}, Start date:{1}, Details:{2}, State:{3}", this.Name,
                this.StartDate, this.Details, this.State);
        }

    }
}
