using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
	/// <summary>
	/// A version of mergesort that does not rearrange the array, 
	/// but returns an int[] array perm such that perm[i] is the index of the ith smallest entry in the array.
	/// </summary>
	public static  class IndirectSortUtil
	{
		public static int[] IndirectSort<T>(this IEnumerable<T> arrayToIndex) where T : IEnumerable<T>
		{
			var indexArray = new int[arrayToIndex.Count()];
			var aux = new T[arrayToIndex.Count()];
			for (int i = 0; i < arrayToIndex.Count(); i++)
			{
				indexArray[i] = i;

			}
			
			Sort(arrayToIndex, indexArray, 0, arrayToIndex.Count() - 1);
			return indexArray;
		}


		private static void Sort<T>(T[] arrayToIndex, T[] aux, int[] indexArray, int startIndex, int endIndex) where T : IEnumerable<T>
		{
			if (endIndex <= startIndex)
				return indexArray;

			int midIndex = startIndex + (endIndex - startIndex) / 2;
			Sort(arrayToIndex, indexArray, startIndex, midIndex);
			Sort(arrayToIndex, indexArray, midIndex + 1, endIndex);
			Merge(arrayToIndex, indexArray, startIndex, midIndex, endIndex);
		}


		private static void Merge<T>(T[] arrayToIndex, T[] aux, int[] indexArray, int startIndex, int midIndex, int endIndex) where T : IEnumerable<T>
		{
			int i = startIndex;
			int j = midIndex + 1;

			while(i < midIndex || j < endIndex)
			{
				if (i > midIndex)
				{

				}
				else if (j > endIndex)
				{

				}
				else if ()
				{

				}
				else
				{

				}
			}

		}

	}
}
