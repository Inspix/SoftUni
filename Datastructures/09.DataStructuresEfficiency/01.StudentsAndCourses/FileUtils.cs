namespace _01.StudentsAndCourses
{
    using System.IO;

    public static class FileUtils
    {
        public static string[] ReadFile(string filename)
        {
            if (File.Exists(filename))
            {
                return File.ReadAllLines(filename);
            }
            throw new FileNotFoundException("File not found.", filename);
        }
    }
}