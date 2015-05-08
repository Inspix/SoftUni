using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 0, 1, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(BiggerThanNeighbours(numbers,i));
        }

    }

    static bool BiggerThanNeighbours(int[] nums, int position)
    {
        if (position == 0)
        {
            if (nums[position] > nums[position+1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (position > 0 && position < nums.Length-1)
        {
            if ((nums[position] > nums[position-1] &&(nums[position] > nums[position+1])))
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
