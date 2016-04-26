using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gliese0
{
	class Program
	{
		static void Main(string[] args)
		{
			TowSum tsum = new TowSum();

			var intArr = new int[] { 3, 2, 1, 3, 4, 5 };
			var target = 9;

			PrintArray(tsum.TwoSum(intArr, target));
			Console.ReadLine();
		}

		static void PrintArray(int[] array)
		{
			foreach (var i in array)
				Console.Write(i + " ");
		}
	}
}
