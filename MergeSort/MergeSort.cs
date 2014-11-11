using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{


	/// <summary>
	/// This is optimized version of the MergeSortAlgorithm
	/// 1. If size of array is smaller than 15 items we use InsertationSort
	/// 2. Checking whether the array is already sorted by comparing the element with the middle index and the element with index after the middle
	/// 3. Swapping array and auxiliary array
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class MergeSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{

		private const int insertationSortConst = 5;

		/// <summary>
		/// Switching to insertion sort for small subarrays (length 15 or less, say) 
		/// will improve the running time of a typical mergesort implementation by 10 to 15 percent. 
		/// Why this optimization works is written here
		/// http://stackoverflow.com/questions/4848387/prove-running-time-of-optimized-mergesort-is-thetank-nlogn-k?rq=1
		/// In short whe can get T(N) = N*K + N * log(N/K) 
		/// </summary>
		private void InsertationSort(T[] arrayToSort, int lo, int hi)
		{
			for (int i = lo + 1; i <= hi; i++)
				for (int j = i; j > lo && arrayToSort[j].CompareTo(arrayToSort[j - 1]) < 0; j--)
					arrayToSort.Swap(j - 1, j);
		}

		private void Merge(T[] arrayToSort, T[] auxiliaryArray, int lo, int mid, int hi)
		{
			int i = lo;
			int j = mid + 1;

			for (int k = lo; k <= hi; k++ )
			{
				//Check bounds before doing actual elements compare
				if (i > mid || j > hi)
					break;
				if (auxiliaryArray[i].CompareTo(auxiliaryArray[j]) < 0)
					arrayToSort[k] = auxiliaryArray[i++];
				else
					arrayToSort[k] = auxiliaryArray[j++];
			}
		}

		private void Sort(T[] arrayToSort, T[] auxiliaryArray, int lo, int hi)
		{
			//3. Check the borders 
			if (hi <= lo)
				return;

			if (hi - lo > insertationSortConst)
			{
				int mid = lo + (hi - lo) / 2;
				Sort(auxiliaryArray, arrayToSort, lo, mid);
				Sort(auxiliaryArray, arrayToSort, mid + 1, hi);

				//Check whether subarrays is in order so we don't need to merge them
				if (arrayToSort[mid].CompareTo(arrayToSort[mid + 1]) < 0)
					return;

				//Run actual mergin of two subarrays devided by the middle index
				Merge(arrayToSort, auxiliaryArray, lo, mid, hi);
			}
			else
			{
				InsertationSort(arrayToSort, lo, hi);
			}
		}


		public void Sort(T[] arrayToSort)
		{			
			//1. Create the auxiliary to copy sorted elements
			var auxiliaryArray = new T[arrayToSort.Length];
			//Copy elements from sorted array to auxiliary array
			for (int i = 0; i < arrayToSort.Length; i++)
				auxiliaryArray[i] = arrayToSort[i];

			//2. Run sorting algorithm 
			Sort(arrayToSort, auxiliaryArray, 0,  arrayToSort.Length - 1);
		}
	}
}
