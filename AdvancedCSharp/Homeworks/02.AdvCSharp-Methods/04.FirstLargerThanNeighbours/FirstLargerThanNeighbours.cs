using System;
using System.Collections.Generic;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfBiggerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfBiggerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfBiggerThanNeighbours(sequenceThree));
    }


    static int GetIndexOfBiggerThanNeighbours(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (BiggerThanNeighbours(nums,i))
            {
                return i;
            }
        }
        return -1;
    }
    static bool BiggerThanNeighbours(int[] nums, int position)
    {
        if (position == 0)
        {
            if (nums[position] > nums[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (position > 0 && position < nums.Length - 1)
        {
            if ((nums[position] > nums[position - 1] && (nums[position] > nums[position + 1])))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (nums[position] > nums[position - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}