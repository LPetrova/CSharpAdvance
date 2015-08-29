using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    static bool IsLargerThanNeighbours (int[] nums, int i)
    {
        bool isLarger = false;

        if (i == 0)
        {
            isLarger = nums[i + 1] < nums[i];
        }
        else if (i > 0 && i < nums.Length - 1)
        {
            isLarger = nums[i - 1] < nums[i] && nums[i + 1] < nums[i];
        }
        else
        {
            isLarger = nums[i - 1] < nums[i];
        }
        return isLarger;
    }
}

