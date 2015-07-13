using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            numbers.ReverseNumbers();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }

    public static class Extension
    {
        public static void ReverseNumbers(this int[] numbers)
        {
            if (numbers == null) return;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = stack.Pop();
            }
        }
    }
}
