namespace _02.IntervalTree
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            IntervalTree<int> tree = new IntervalTree<int>();

            tree.Add(5,10);
            tree.Add(6,11);
            tree.Add(7,12);

            foreach (var interval in tree.GetAllIntersecting(7,15))
            {
                Console.WriteLine(interval.Min + " " + interval.Max);
            }

            foreach (var interval in tree.GetAllContaining(6, 15))
            {
                Console.WriteLine(interval.Min + " " + interval.Max);
            }
        }
    }
}
