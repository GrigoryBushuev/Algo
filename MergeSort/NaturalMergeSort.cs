using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
	public class NaturalMergeSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{

		private T[] _auxiliaryArray;

		private void Merge(T[] arrayToSort, int lo, int mid, int hi)
		{ 
			int i = lo;
			int j = mid + 1;

			for (int k = lo; k <= hi; k++)
				_auxiliaryArray[k] = arrayToSort[k];

			for (int k = lo; k <= hi; k++)
			{
				if (i > mid)
					arrayToSort[k] = _auxiliaryArray[j++];
				else if (j > hi)
					arrayToSort[k] = _auxiliaryArray[i++];
				else if (_auxiliaryArray[i].CompareTo(_auxiliaryArray[j]) < 0)
					arrayToSort[k] = _auxiliaryArray[i++];
				else
					arrayToSort[k] = _auxiliaryArray[j++];
			}

		}

		private int GetNextSentinelIndex(T[] arrayToScan, int startIndex)
		{
			if (startIndex == arrayToScan.Length - 1)
				return startIndex;

			while (startIndex <= arrayToScan.Length - 2 && arrayToScan[startIndex - 1].CompareTo(arrayToScan[startIndex]) < 0)
				startIndex++;
			return startIndex;				 
		}

		public void Sort(IEnumerable<T> arrayToSort)
		{
			var arr = arrayToSort as T[];
			_auxiliaryArray = new T[arr.Length];


			int lo = 0;
			int mid = arr.Length - 1;
			int hi = arr.Length - 1;

			while (lo < arr.Length)
			{
				mid = GetNextSentinelIndex(arr, lo);
				hi = GetNextSentinelIndex(arr, mid + 1);
				if (lo != hi)
					Merge(arr, lo, mid, hi);

				if (lo == 0 && mid == hi)
					break;
				else if (hi == arr.Length - 1)
					lo = 0;
				else
					lo = hi + 1;
			}

		}
	}
}
