using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class SortingAlgorithms
    {
		public static void Sort<T>(this T[] arrayToSort, ISortingAlgorithm<T> sortingAlgorithm) where T : IComparable<T>
		{
			sortingAlgorithm.Sort(arrayToSort);
		}
    }
}
