using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
	public static class InversionsCount
	{

		public static int SplitAndCount<T>(this IEnumerable<T> collection) where T : IComparable<T>
		{
			if (collection == null)
				throw new ArgumentNullException();

			var arr = (T[])collection;
			if (arr.Count() == 1)
				return 1;

			var aux = new T[arr.Count()];
			for (var i = 0; i < aux.Length; i++)
			{
				aux[i] = arr[i];
			}


			return SplitAndCount(arr, aux, 0, arr.Count() - 1);
		}


		private static int SplitAndCount<T>(IEnumerable<T> arr, IEnumerable<T> aux, int startIndex, int endIndex) where T : IComparable<T>
		{

			var midIndex = (endIndex - startIndex) / 2;

			var x = SplitAndCount(arr, aux, startIndex, midIndex);
			var y = SplitAndCount(arr, aux, midIndex, endIndex);
			var z = MergeAndCount(arr, aux, startIndex, midIndex, endIndex);

			return x + y + z;
		}


		private static int MergeAndCount<T>(IEnumerable<T> arr, IEnumerable<T> aux, int leftIndex, int rightIndex, int mid) where T : IComparable<T>
		{
			var i = leftIndex;
			var j = mid;

			var temp = new T[rightIndex - leftIndex];
			for (int k = leftIndex; k < rightIndex; k++)
			{
				temp
			}

			while (true)
			{
				
			}
			return 0;
		}


	}
}
