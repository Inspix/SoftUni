using System;

namespace OddEvenSum
{
    internal class OddEvenSum
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int index = 0;
            int oddsum = 0;
            int evensum = 0;
            for (int i = 0; i < n * 2; i++)
            {
                index++;
                if (index % 2 == 0)
                {
                    evensum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddsum += int.Parse(Console.ReadLine());
                }
            }
            if (oddsum == evensum)
            {
                Console.WriteLine("Yes,Sum={0}", oddsum);
            }
            else
            {
                Console.WriteLine("No,Diff={0}", Math.Abs(oddsum - evensum));
            }
        }
    }
}