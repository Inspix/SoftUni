using System;
using System.IO;
using System.Text;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("Windows-1251"));

            using (reader)
            {
                int index = 0;
                using (reader)
                {
                    
                }
                string line = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    if (index % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    index++;
                }
            }
        }
    }
}
