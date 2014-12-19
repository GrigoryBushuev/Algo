using System;
using DataStructures.Linear;
using MergeSort;
using SortingAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SortUnitTest
{
	[TestClass]
	public class SortUnitTest
	{
		private static readonly int[] _arrayToSort = new[] { 5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };
		private static readonly int[] _sortedArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };		
			
		[ClassInitialize()]
		public static void ClassInit(TestContext context)
		{

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
			//Arrange
			MergeSort<int> mergeSort = new MergeSort<int>();
			var arrayToSort = new int[_arrayToSort.Length];
			_arrayToSort.CopyTo(arrayToSort, 0);
			//Act
			arrayToSort.Sort(mergeSort);
			//Assert
			Assert.IsTrue(arrayToSort.IsSorted());
		}

		[TestMethod]
		public void BottomUpMergeSortTest()
		{
			//Arrange
			var bottomUpMergeSort = new BottomUpMergeSort<int>();
			var arrayToSort = new int[_arrayToSort.Length];
			_arrayToSort.CopyTo(arrayToSort, 0);
			//Act
			arrayToSort.Sort(bottomUpMergeSort);
			//Asssert
			Assert.IsTrue(arrayToSort.IsSorted());
		}

		[TestMethod]
		public void NaturalMergeSortTest()
		{
			//Arrange
			var naturalMergeSort = new NaturalMergeSort<int>();
			var arrayToSort = new int[_arrayToSort.Length];
			_arrayToSort.CopyTo(arrayToSort, 0);
			//Act
			arrayToSort.Sort(naturalMergeSort);
			//Asssert
			Assert.IsTrue(arrayToSort.IsSorted());
		}

		[TestMethod]
		public void LinkedListSortTest()
		{
			//Arrange
			var linkedList = new LinkedList<int>();
			linkedList.AddFirst(5);
			linkedList.AddFirst(9);
			linkedList.AddFirst(8);

			linkedList.AddFirst(1);
			linkedList.AddFirst(4);
			linkedList.AddFirst(2);

			linkedList.AddFirst(6);
			linkedList.AddFirst(5);
			linkedList.AddFirst(3);
			linkedList.AddFirst(7);
			//Act
			linkedList.Sort();
			//Asssert
			//Assert.IsTrue(arrayToSort.IsSorted());
		}
	}
}
