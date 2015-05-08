using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceOfKNumbers
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int k = int.Parse(Console.ReadLine());
        int count = 0;
        int lastNum = int.Parse(input[0]);
        List<int> result = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            int currentNum = int.Parse(input[i]);
            if (lastNum == currentNum)
            {
                count++;
            }
            else
            {
                for (int x = 0; x < count % k; x++)
                {
                    result.Add(lastNum);
                }
                lastNum = currentNum;
                count = 1;
            }
        }
        for (int x = 0; x < count % k; x++)
        {
            result.Add(lastNum);
        }
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }
}

