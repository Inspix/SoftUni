using System;

namespace Problem7.ImplementaLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> bla = new LinkedList<string>();
            bla.Add("blabal");
            bla.Add("blabal2");
            bla.Add("blabal3");
            bla.Add("blabal4");
            bla.Add("blabal5");
            bla.Add("blabal6");
            bla.Add("blabal6");
            bla.Add("blabal6");
            bla.Add("blabal6");
            bla.Add("blabal6");
            bla.Add("blabal4");
            bla.Add("blabal4");
            bla.Add("blabal4");

            LinkedList<long> bla2 = new LinkedList<long>();

            long[] data = new long[] {12345, 4323, 455, 33, 4, 4323, 455, 33, 4};
            foreach (var l in data)
            {
                bla2.Add(l);
            }
            int[] toRemove = new int[] { 5, 3, 6, 1 };
            foreach (var i in toRemove)
            {
                bla2.Remove(i);
            }
            foreach (var l in bla2)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();

            bla.Remove(2);

            foreach (var VARIABLE in bla)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine(bla.GetCurrent);
            Console.WriteLine(bla.First);


            Console.WriteLine(bla.FirstIndexOf("gosho"));
            Console.WriteLine(bla.LastIndexOf("blabal6"));
        }
    }
}
