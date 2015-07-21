namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        public LocalCourse(string name) : base(name)
        {
        }

        public LocalCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
        }

        public string Lab { get; set; } = null;


        public override string ToString()
        {
            return "LocalCourse " + base.ToString() + (this.Lab != null ? "; Lab = " + this.Lab : "") + " }";
        }
    }
}
