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

		private static void Merge(T[] arrayToSort, T[] auxiliaryArray, int lo, int mid, int hi)
		{
			int i = lo;
			int j = mid + 1;

			//Copy elements from sorted array to auxiliary array
			for (int n = lo; n <= hi; n++)
				auxiliaryArray[n] = arrayToSort[n];

			for (int k = lo; k <= hi; k++ )
			{
				//Check bounds before doing actual elements compare
				if (i > mid)
					arrayToSort[k] = auxiliaryArray[j++];
				else if (j > hi)
					arrayToSort[k] = auxiliaryArray[i++];
				else if (auxiliaryArray[i].CompareTo(auxiliaryArray[j]) < 0)
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

			int mid = lo + (hi - lo) / 2;
			Sort(arrayToSort, auxiliaryArray, lo, mid);
			Sort(arrayToSort, auxiliaryArray, mid + 1, hi);
			//Run actual mergin of two subarrays devided by the middle index
			Merge(arrayToSort, auxiliaryArray, lo, mid, hi);
		}


		public void Sort(T[] arrayToSort)
		{			
			//1. Create the auxiliary to copy sorted elements
			var auxiliaryArray = new T[arrayToSort.Length];
			//2. Run sorting algorithm 
			Sort(arrayToSort, auxiliaryArray, 0,  arrayToSort.Length - 1);
		}
	}
}
