namespace AATree
{
    using System;

    class AATreeTest
    {
        static void Main(string[] args)
        {
            AATree<int> test = new AATree<int>();

            for (int i = -2000; i < 2000; i++)
            {
                test.Insert(i);
            }

            
            Console.WriteLine("Contains: 3 - " + test.Contains(3));
            Console.WriteLine("Count after 4000 inserts: " + test.Count);
            int min = test.Min();
            Console.WriteLine("Min:" + min);

            for (int i = 550; i < 1500; i++)
            {
                test.Remove(i);
            }
            Console.WriteLine("хелло", "ворлд");
            Console.WriteLine("Count after 950 removes: " + test.Count);
            test.Clear();
            Console.WriteLine("Clear tree then print.");
            test.PrintTree();
        }
    }
}
