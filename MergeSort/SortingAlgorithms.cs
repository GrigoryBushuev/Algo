using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{

    public static class MySort
    {
        private static void Swap<T>(T[] array, int i, int j) where T : IComparable<T>
        {
            T temp;
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void InsertationSort<T>(this T[] arrayToSort) where T : IComparable<T>
        {
            for (int i = 1; i < arrayToSort.Count(); i++)
                //Starting from current index we compare two neighborhood elements. In case they are unordered we swap them. 
                //Thus by the end of the internal iteration all elements are ordered from 0 to i
                for (int j = i; j > 0 && arrayToSort[j].CompareTo(arrayToSort[j - 1]) < 0; j--)
                    Swap(arrayToSort, j - 1, j);
        }

        private static int Partition<T>(this T[] arrayToSort, int lo, int hi) where T : IComparable<T>
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
				Swap(arrayToSort, i, j);
			}

			Swap(arrayToSort, partitionIndex, i - 1);
            return i - 1;
        }

        private static void QuickSort<T>(this T[] arrayToSort, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi)
                return;

            int partitionIndex = arrayToSort.Partition(lo, hi);
            arrayToSort.QuickSort(lo, partitionIndex);
            arrayToSort.QuickSort(partitionIndex + 1, hi);
        }

        public static void QuickSort<T>(this T[] arrayToSort) where T : IComparable<T>
        {            
            QuickSort(arrayToSort, 0, arrayToSort.Length - 1);
        }
    }



    class SortingAlgorithms
    {
        static void Main(string[] args)
        {
            var arrayToSort = new []{5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };
            arrayToSort.QuickSort();
            Array.ForEach(arrayToSort, val => Console.Write(val));
            Console.ReadKey();
        }
    }
}
