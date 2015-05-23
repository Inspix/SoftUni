using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
class Problems
{
    static void Main()
    {
        List<Student> students = Student.GetList();
        List<StudentSpeciality> specialities = StudentSpeciality.GetSpecialities();

        #region Problem 2
        Console.WriteLine("Problem 2\n");

        var result2 = from student in students
                      where student.GroupNumber == 2
                      select student;

        foreach (var student in result2)
        {
            Console.WriteLine(student.FirstName);
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 3
        Console.WriteLine("Problem 3\n");

        var result3 = from student in students
                      where student.FirstName[0] < student.LastName[0]
                      orderby student.FirstName
                      select student;

        foreach (var student in result3)
        {
            Console.WriteLine(student.FirstName);
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 4
        Console.WriteLine("Problem 4\n");
        var result4 = from student in students
            where student.Age >= 18 && student.Age <= 24
            select new {student.FirstName, student.LastName, student.Age};

        foreach (var student in result4)
        {
            Console.WriteLine("{0} {1} - Age:{2}", student.FirstName, student.LastName, student.Age);
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 5
        Console.WriteLine("Problem 5\n");
        var result5 = from student in students
                      orderby student.LastName
                      orderby student.FirstName
                      select student;

        Console.WriteLine("Linq querry:\n");
        foreach (var student in result5)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
        Console.WriteLine();

        Console.WriteLine("Lamda expression:\n");
        foreach (var student in students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName))
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
        }
        Console.ReadKey();
        Console.Clear();
        #endregion

        #region Problem 6
        Console.WriteLine("Problem 6\n");
        var result6 = from student in students
                      where student.Email.Contains("@abv.bg")
                      select student;

        foreach (var student in result6)
        {
            Console.WriteLine(student.FirstName + " - " + student.Email);
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 7
        Console.WriteLine("Problem 7:\n");
        var results7 = from student in students
                       where
                           student.Phone.StartsWith("02") ||
                           student.Phone.StartsWith("+3592") ||
                           student.Phone.StartsWith("003592")
                       select student;
        foreach (var student in results7)
        {
            Console.WriteLine(student.FirstName + ":" + student.Phone);
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 8
        Console.WriteLine("Problem: 8");
        var result8 = from student in students
                      where student.Marks.Contains(6)
                      select new { student.FirstName, student.Marks };
        foreach (var student in result8)
        {
            Console.WriteLine("{0}: {1}", student.FirstName, student.Marks.Select(s => s.ToString()).Aggregate((a, b) => a + "," + b));
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 9
        Console.WriteLine("Problem 9:\n");
        var result9 = students.Where(s => s.Marks.Count(m => m.Equals(2)).Equals(2)).ToList();
        foreach (var student in result9)
        {
            Console.WriteLine("{0} - {1}", student.FirstName, student.Marks.Select(a => a.ToString()).Aggregate((a, b) => a + "," + b));
        }
        Console.ReadKey();
        Console.Clear();
        #endregion

        #region Problem 10
        Console.WriteLine("Problem 10:\n");
        var result10 = from student in students
                       where student.FacultyNumber % 100 == 14
                       select student;
        foreach (var student in result10)
        {
            Console.WriteLine(student.FirstName + " " + student.LastName);
            Console.WriteLine("\t-- " + student.Marks.Select(s => s.ToString()).Aggregate((a, b) => a + ", " + b));
        }
        Console.ReadKey();
        Console.Clear();
        #endregion

        #region Problem 11
        Console.WriteLine("Problem 11:\n");
        var result11 = from student in students
                       group student.FirstName by student.GroupName
                           into NewGroup
                           select NewGroup;
        foreach (var group in result11)
        {
            Console.WriteLine(group.Key);
            foreach (var student in group)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

        #region Problem 12
        Console.WriteLine("Poblem 12:\n");
        var result12 = from student in students
                       join s in specialities on student.FacultyNumber equals s.FacultyNumber
                       select new { Name = student.FirstName, FacultyN = student.FacultyNumber, Speciality = s.SpecialityName };

        foreach (var joined in result12)
        {
            Console.WriteLine(joined.Name + "\t" + joined.FacultyN + "\t" + joined.Speciality);
        }
        Console.ReadKey();
        Console.Clear(); 
        #endregion

    }
}
