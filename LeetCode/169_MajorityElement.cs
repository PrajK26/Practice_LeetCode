using System;

namespace LeetCode
{
	public class MajorityElement
	{
		public int GetResult(int[] nums)
		{
			//Moore Voting Algorithm
			int count = 0;
			int candidate = 0;

			foreach(var num in nums)
			{
				if(count == 0)
				{
					candidate = num;
				}

				if(num == candidate)
				{
					count++;
				}
				else
				{
					count--;
				}
			}

			return candidate;
        }
    }
}

