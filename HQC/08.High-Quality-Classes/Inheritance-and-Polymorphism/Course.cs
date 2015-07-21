using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private IList<string> students;

        protected Course(string name) : this(name,null)
        {
        }

        protected Course(string courseName, string teacherName) : this(courseName,teacherName,null)
        {
        }


        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get { return this.name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("The course name can not be null or empty");
                }
                this.name = value;
            }
        }

        public string TeacherName { get; set; }

        public IList<string> Students
        {
            get
            {
                if (this.students == null)
                {
                    this.students = new List<string>();
                }
                return this.students;
            }
            set { this.students = value; }
        }

        protected string GetStudentsAsString()
        {
            if (this.students == null || this.students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{ Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            if (this.students != null)
            {
                result.Append("; Students = ");
                result.Append(this.GetStudentsAsString());
            }
            return result.ToString();
        }
    }
}
