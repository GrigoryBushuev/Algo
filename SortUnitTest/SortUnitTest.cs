using System;
using SortingAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SortUnitTest
{
	[TestClass]
	public class SortUnitTest
	{

		private static int[] _arrayToSort;

		[ClassInitialize()]
		public static void ClassInit(TestContext context)
		{
			_arrayToSort = new[] { 5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };
		}


		[TestMethod]
		public void MergeSortTest()
		{
			MergeSort<int> mergeSort = new MergeSort<int>();
			_arrayToSort.Sort(mergeSort);
			foreach (var item in _arrayToSort)
			{
		 
			} 
		}
	}
}
