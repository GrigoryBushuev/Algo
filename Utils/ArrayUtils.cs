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
    }
}
