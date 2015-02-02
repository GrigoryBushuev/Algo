using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;

namespace MergeSort
{
	public class ShellSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{
		public void Sort(IEnumerable<T> arrayToSort)
		{
			var arr = arrayToSort as T[];


		}
	}
}
