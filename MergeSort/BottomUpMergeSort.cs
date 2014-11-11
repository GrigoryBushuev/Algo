using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;

namespace MergeSort
{
	public class BottomUpMergeSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{

		private void Merge(T[] arrayToSort, int lo, int mid, int hi)
		{

		}

		public void Sort(T[] arrayToSort)
		{
			int length = arrayToSort.Length;
			//calculate size
			for (int sz = 1; sz < length; sz += sz) //1, 2, 4, 8
			{
				//calculate lower bound
				for (int lo = 0; lo < length - sz; lo += sz + sz)// 0, 2, 4, 6
					Merge(arrayToSort, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, length - 1));
			}

		}
	}
}
