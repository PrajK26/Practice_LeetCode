﻿//Problem: https://leetcode.com/problems/two-sum/

namespace LeetCode;

public class TwoSum
{
    public int[] GetResult(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                return new int[] { dict[nums[i]], i };
            }
            else
            {
                dict[target - nums[i]] = i;
            }
        }

        return new int[] { };
    }
}

