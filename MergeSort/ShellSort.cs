using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;
using Utils;

namespace MergeSort
{
	public class ShellSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{
		public void Sort(IEnumerable<T> arrayToSort)
		{
			var arr = arrayToSort as T[];
			var k = 1;

			while (k < arr.Length / 3) k = 3 * k + 1;

			while(k >= 1)
			{
				for (int i = k; i < arr.Length; i++)
				{
					for (int j = i; j >= k && arr[j].CompareTo(arr[j - k]) < 0 ; j -= k)					
						arr.Swap(j, j - k);					
				}
				k = k / 3;
			}

		}
	}
}
