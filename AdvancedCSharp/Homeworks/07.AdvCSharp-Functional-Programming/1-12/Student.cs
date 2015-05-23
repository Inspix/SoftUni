using System.Collections.Generic;

class Student
{
    public string FirstName;
    public string LastName;
    public int Age;
    public int FacultyNumber;
    public string Phone;
    public string Email;
    public IList<int> Marks;
    public int GroupNumber;
    public string GroupName;

    public Student()
    {

    }
    public Student(string fName, string lName, int age,
        int fNumber, string phone, string email,
        IList<int> marks, int groupNumber,string groupName)
    {
        FirstName = fName;
        LastName = lName;
        Age = age;
        FacultyNumber = fNumber;
        Phone = phone;
        Email = email;
        Marks = marks;
        GroupNumber = groupNumber;
        GroupName = groupName;

    }

    public static List<Student> GetList()
    {
        return new List<Student>
        {
            new Student("Maria", "Ignatova", 19, 000114, "+359899444444", "maria@abv.bg", new List<int> {5, 4, 6, 3}, 2,"C#"),
            new Student("Boni", "Tailur", 55, 000214, "0245553445", "boni@abv.bg", new List<int> {2, 2}, 2,"C#"),
            new Student("Kiril", "Kurtev", 24, 000313, "+359892644554", "kiril@gmail.com", new List<int> {4, 4, 4, 4}, 1,"Java"),
            new Student("Ognqn", "Vulev", 46, 000413, "+3592877333333", "ognqn@hotmail.com", new List<int> {5, 2, 6, 2}, 1, "ADO.NET"),
            new Student("Hristo", "Hristomirov", 14, 000515, "+359893123123", "hristo@abv.bg", new List<int> {5, 4, 6, 3}, 3, "JavaScript"),
            new Student("Shisho", "Bakshisho", 30, 000614, "003592899404040", "shisho@mail.bg", new List<int> {3, 6, 6, 3}, 3, "JavaScript"),
        };
    }
}

