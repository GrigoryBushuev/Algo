﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;

namespace MergeSort
{
	public class BottomUpMergeSort<T> : ISortingAlgorithm<T> where T : IComparable<T>
	{

		private T[] _auxiliaryArray = null;

		private void Merge(T[] arrayToSort, int lo, int mid, int hi)
		{
			int i = lo;//0
			int j = mid + 1;//2 hi:3

			for (int aIndex = lo; aIndex <= hi; aIndex++)
			{
				_auxiliaryArray[aIndex] = arrayToSort[aIndex];
			}

			for (int k = lo; k <= hi; k++)
			{
				if (i > mid)
					arrayToSort[k] = _auxiliaryArray[j++];
				else if (j > hi)
					arrayToSort[k] = _auxiliaryArray[i++];
				else if (_auxiliaryArray[i].CompareTo(_auxiliaryArray[j]) < 1)
					arrayToSort[k] = _auxiliaryArray[i++];
				else
					arrayToSort[k] = _auxiliaryArray[j++];
			}
		}

		public void Sort(T[] arrayToSort)
		{			
			int length = arrayToSort.Length;
			_auxiliaryArray = new T[length];

			//calculate size
			for (int sz = 1; sz < length; sz = sz << 1) //1, 2, 4, 8
			{
				//calculate lower bound
				for (int lo = 0; lo < length - sz; lo = (sz << 1) + lo)// 0, 2, 4, 6
					Merge(arrayToSort, lo, lo + sz - 1, Math.Min(lo + sz + sz - 1, length - 1));
			}

		}
	}
}