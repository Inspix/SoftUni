using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.ImplementtheDataStructureReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseList<string> test = new ReverseList<string>();
            test.Add("blabla");
            test.Add("blabla2");
            test.Add("blabla3");
            test.Add("blabla4");
            test.Add("blabla5");
            test.Add("blabla6");
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }
            test.Remove(2);
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }

            foreach (var VARIABLE in test)
            {
                Console.WriteLine(VARIABLE);
            }

        }
    }
}
