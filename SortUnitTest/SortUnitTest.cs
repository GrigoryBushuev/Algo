using System;
using SortingAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SortUnitTest
{
	[TestClass]
	public class SortUnitTest
	{
		private static int[] _arrayToSort;
		private static int[] _sortedArray;

		[ClassInitialize()]
		public static void ClassInit(TestContext context)
		{
			_arrayToSort = new[] { 5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };
			_sortedArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
		}


		[TestMethod]
		public void IsSortedTest()
		{
			Assert.IsFalse(_arrayToSort.IsSorted());
			Assert.IsTrue(_sortedArray.IsSorted());
		}



		[TestMethod]
		public void MergeSortTest()
		{
			MergeSort<int> mergeSort = new MergeSort<int>();
			_arrayToSort.Sort(mergeSort);
			Assert.IsTrue(_arrayToSort.IsSorted());
		}
	}
}
