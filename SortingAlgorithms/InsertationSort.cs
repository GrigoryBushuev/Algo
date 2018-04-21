using System;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace SortingAlgorithms
{
    public class InsertationSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
    {
        public void Sort(IEnumerable<T> sortingElements)
        {
            var arrayToSort = sortingElements as T[];
            if (arrayToSort == null)
                throw new InvalidCastException();
            for (int i = 1; i < arrayToSort.Count(); i++)
                //Starting from current index we compare two neighborhood elements. In case they are unordered we swap them. 
                //Thus by the end of the internal iteration all elements are ordered from 0 to i
                for (int j = i; j > 0 && arrayToSort[j].CompareTo(arrayToSort[j - 1]) < 0; j--)
                    arrayToSort.Swap(j - 1, j);
        }
    }
}
