using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gliese0
{
	public class TowSum
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
