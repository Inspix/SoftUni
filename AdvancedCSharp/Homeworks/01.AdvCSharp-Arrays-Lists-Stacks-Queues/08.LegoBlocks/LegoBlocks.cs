using System;
using System.Collections.Generic;
using System.Linq;

class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] firstBlock = new int[n][];
        int[][] secondBlock = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int[] x = GetNumArray(Console.ReadLine());
            firstBlock[i] = x;
        }
        for (int i = 0; i < n; i++)
        {
            int[] y = GetNumArray(Console.ReadLine());
            secondBlock[i] = y;
        }

        int[][] result = Glue(firstBlock,secondBlock);
        if (checkEquality(firstBlock,secondBlock))
        {
            for (int i = 0; i <= result.GetUpperBound(0); i++)
            {
                int[] inner = result[i];
                string x = string.Empty;
                Console.Write('[');
                for (int z = 0; z < inner.Length; z++)
                {
                    x += inner[z] + ",";
                }
                x = x.Remove(x.Length - 1);
                Console.Write(x);
                Console.WriteLine(']');
            }
        }
        else
        {
            int cells = 0;
            for (int i = 0; i <= result.GetUpperBound(0); i++)
            {
                cells += result[i].Length;
            }
            Console.WriteLine("The total number of cells is: {0}",cells);
        }
    }

    static bool checkEquality(int[][] x, int[][] y)
    {
        int count = x[0].Length + y[0].Length - 2;
        for (int i = 0; i <= x.GetUpperBound(0); i++)
        {
            if (count != x[i].Length + y[i].Length - 2)
            {
                return false;
            }
        } return true;
    }

    static int[][] Glue(int[][] x, int[][] y)
    {
        for (int i = 0; i <= y.GetUpperBound(0); i++)
			{
			    Array.Reverse(y[i]);
			}

        int[][] glued = new int[x.GetUpperBound(0)+1][];

        for (int i = 0; i <= x.GetUpperBound(0); i++)
        {
            int index = 0;
            int[] result = new int[x[i].Length + y[i].Length];
            for (int z = 0; z < x[i].Length; z++)
            {
                result[index] = x[i][z];
                index++;
            }
            for (int z = 0; z < y[i].Length; z++)
            {
                result[index] = y[i][z];
                index++;
            }
            glued[i] = result;
        }
        return glued;
        
    }

    static int[] GetNumArray(string x)
    {
        List<int> numbers = new List<int>();
        Array.ForEach(x.Split(' '), s =>
        {
            int cNum;
            if (Int32.TryParse(s, out cNum))
            {
                numbers.Add(cNum);
            }
        });
        return numbers.ToArray();
    }
}