using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class ArrayUtils
    {

	    public static void Swap<T>(this T[] array, int i, int j) where T : IComparable<T>
	    {
		    var temp = array[i];
		    array[i] = array[j];
		    array[j] = temp;
	    }

        public static int? Rank<T>(this T[] sortedArray, T key) where T : IComparable<T>
        {
            int lo = 0;
            int hi = sortedArray.Length - 1;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                int cmp = key.CompareTo(sortedArray[mid]);
                if (cmp < 0)
                    hi = mid - 1;
                else if (cmp > 0)
                    lo = mid + 1;
                else
                    return mid;
            }
            return null;
        }

    }
}
