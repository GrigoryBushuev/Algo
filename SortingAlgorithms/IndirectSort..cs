using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
	/// <summary>
	/// A version of merge-sort that does not rearrange the array, 
	/// but returns an int[] array perm such that perm[i] is the index of the ith smallest entry in the array.
	/// </summary>
	public static  class IndirectSortUtil
	{
		public static int[] IndirectSort<T>(this IEnumerable<T> arrayToIndex) where T : IComparable<T>
		{			
			var indexArray = new int[arrayToIndex.Count()];
			var auxIndexArray = new int[arrayToIndex.Count()];
			for (int i = 0; i < arrayToIndex.Count(); i++)
			{
				indexArray[i] = i;
				auxIndexArray[i] = i;
			}

			Sort(arrayToIndex as T[], indexArray, auxIndexArray, 0, arrayToIndex.Count() - 1);
			return indexArray;
		}


		private static void Sort<T>(T[] arrayToIndex, int[] indexArray, int[] auxIndexArray, int startIndex, int endIndex) where T : IComparable<T>
		{
			if (endIndex <= startIndex)
				return;

			var midIndex = startIndex + (endIndex - startIndex) / 2;
			Sort(arrayToIndex, indexArray, auxIndexArray, startIndex, midIndex);
			Sort(arrayToIndex, indexArray, auxIndexArray, midIndex + 1, endIndex);
			Merge(arrayToIndex, indexArray, auxIndexArray, startIndex, midIndex, endIndex);
		}


		private static void Merge<T>(T[] arrayToIndex, int[] indexArray, int[] auxIndexArray, int startIndex, int midIndex, int endIndex) where T : IComparable<T>
		{
			var i = startIndex;
			var j = midIndex + 1;

			for (var k = startIndex; k <= endIndex; k++)
			{
				auxIndexArray[k] = indexArray[k];
			}

			for(int k = startIndex; k <= endIndex; k++)
			{
				if (i > midIndex)
				{
					indexArray[k] = auxIndexArray[j++];
				}
				else if (j > endIndex)
				{
					indexArray[k] = auxIndexArray[i++];
				}
				else if (arrayToIndex[auxIndexArray[i]].CompareTo(arrayToIndex[auxIndexArray[j]]) <= 0)
				{
					indexArray[k] = auxIndexArray[i++];
				}
				else
				{
					indexArray[k] = auxIndexArray[j++];
				}
			}
		}

	}
}
