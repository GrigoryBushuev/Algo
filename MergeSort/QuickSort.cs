﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
	public class QuickSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{
		private int Partition(T[] arrayToSort, int lo, int hi)
		{
			int partitionIndex = lo;
			var partitionValue = arrayToSort[partitionIndex];

			int i = lo + 1;
			int j = hi;

			while (true)
			{
				while (i < hi && arrayToSort[i].CompareTo(partitionValue) < 0) i++;
				while (j > lo && arrayToSort[j].CompareTo(partitionValue) > 0) j--;
				if (i >= j) break;
				arrayToSort.Swap(i, j);
			}

			arrayToSort.Swap(partitionIndex, i - 1);
			return i - 1;
		}

		private void Sort(T[] arrayToSort, int lo, int hi)
		{
			if (lo >= hi)
				return;

			int partitionIndex = Partition(arrayToSort, lo, hi);
			Sort(arrayToSort, lo, partitionIndex);
			Sort(arrayToSort, partitionIndex + 1, hi);
		}

		public void Sort(T[] arrayToSort)
		{
			Sort(arrayToSort, 0, arrayToSort.Length - 1);
		}
	}
}