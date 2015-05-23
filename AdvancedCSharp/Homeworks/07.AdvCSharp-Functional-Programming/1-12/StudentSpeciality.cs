using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

class StudentSpeciality
{
    public string SpecialityName;
    public int FacultyNumber;

    public StudentSpeciality(string sName, int fNumber)
    {
        FacultyNumber = fNumber;
        SpecialityName = sName;
    }

    public static List<StudentSpeciality> GetSpecialities()
    {
        return new List<StudentSpeciality>()
        {
            new StudentSpeciality("Developer", 000114),
            new StudentSpeciality("Developer", 000214),
            new StudentSpeciality("Q&A", 000313),
            new StudentSpeciality("Junior Developer", 000413),
            new StudentSpeciality("Senior Developer", 000515),
            new StudentSpeciality("Junior Developer", 000614)
        };
    } 
}

