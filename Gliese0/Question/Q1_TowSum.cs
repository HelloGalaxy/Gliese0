using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gliese0
{
	/// <summary>
	/// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
	/// You may assume that each input would have exactly one solution.
	///Example:
	///Given nums = [2, 7, 11, 15], target = 9,
	//Because nums[0] + nums[1] = 2 + 7 = 9,
	//return [0, 1].
	/// </summary>
	public class Q1_TowSum
	{
		public int[] TwoSum(int[] nums, int target)
		{
			var result = new int[2];
			for (var i = 0; i < nums.Length - 1; i++)
			{
				for (var j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						result[0] = i;
						result[1] = j;
						break;
					}
				}
			}
			return result;
		}
	}
}
