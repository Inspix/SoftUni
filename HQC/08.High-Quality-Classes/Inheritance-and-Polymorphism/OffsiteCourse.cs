namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string name) : base(name)
        {
        }

        public OffsiteCourse(string courseName, string teacherName) : base(courseName,teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) : base(courseName,teacherName,students)
        {
        }

        public string Town { get; set; } = null;


        public override string ToString()
        {
            return "OffsiteCourse " + base.ToString() + (this.Town != null ? "; Town = " + this.Town : "") + " }";
        }
    }
}
