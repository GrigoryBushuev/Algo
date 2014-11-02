using System;
using MergeSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SortUnitTest
{
	[TestClass]
	public class SortUnitTest
	{
		[TestMethod]
		public void MergeSortTest()
		{
			var arrayToSort = new[] { 5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };

			arrayToSort.MergeSort();


		}
	}
}
