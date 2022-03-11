using System;
using System.Collections.Generic;

namespace LeetCode___3_Sum_Problem
{
    class Program
    {
            public static IList<IList<int>> ThreeSum(int[] nums)
            {
                List<IList<int>> list = new List<IList<int>>();
                int prevI = 0;
                int prevJ = 0;
                int rest = 0;
                int lastNumber = 0;
                Array.Sort(nums);
                for (int i = nums.Length - 1; i > 1; i--)
                {
                    if (i != nums.Length - 1 && nums[i] == prevI)
                    {
                        continue;
                    }
                    rest = -nums[i];
                    prevI = nums[i];
                    prevJ = 0;
                    for (int j = i - 1; j > 0; j--)
                    {
                        if (j != i - 1 && nums[j] == prevJ)
                        {
                            continue;
                        }
                        lastNumber = rest - nums[j];
                        prevJ = nums[j];
                        if (Array.BinarySearch<int>(nums, 0, j, lastNumber) >= 0)
                        {
                            list.Add(new List<int>() { nums[i], nums[j], lastNumber });
                        }
                    }
                }
                return list;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> solution = ThreeSum(nums);

            foreach(IList<int> list in solution)
            {
                foreach (int e in list)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
