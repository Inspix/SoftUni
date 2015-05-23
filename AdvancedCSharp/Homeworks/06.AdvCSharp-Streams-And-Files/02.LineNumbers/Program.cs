using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("test.txt");
            StreamWriter writer = new StreamWriter("newText.txt");
            using (reader)
            {
                using (writer)
                {
                    int index = 1;
                    while (!reader.EndOfStream)
                    {                        
                        writer.WriteLine(string.Format("{0}.{1}",index++,reader.ReadLine()));
                    }
                }
            }
        }
    }
}