using System;

namespace SortingAlgorithms
{
	public static class SortingUtils
	{

		public static bool IsSorted<T>(this T[] sortedArray, bool ascending = true) where T : IComparable<T>
		{
			bool isSorted = true;
			if (sortedArray.Length == 1)
				return true;

			int comparableValue = ascending ? 1 : -1;

			for (int i = 1; i < sortedArray.Length; i++)
			{
				var compareResult = sortedArray[i].CompareTo(sortedArray[i - 1]);
				if (compareResult != comparableValue && compareResult != 0)
				{
					isSorted = false;
					break;
				}						
			}
			

			return isSorted;
		}
	}
}
