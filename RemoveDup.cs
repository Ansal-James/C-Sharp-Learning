using System;
using System.Collections.Generic;
class NameSort
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 10, 20, 20, 30, 40, 10, 50 };

        for(int i  = 0; i < nums.Count-1; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    nums.RemoveAt(j);
                    j--;
                }
            }
        }
        foreach(int i in nums)
        {
            Console.Write(i + " ");
        }
    }
}