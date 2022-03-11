using System;

namespace LeetCode___2_Sum_Problem
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int[] result = TwoSum(nums, 9);

            foreach(int e in result)
            {
                Console.WriteLine(e);
            }
        }
    }
}
