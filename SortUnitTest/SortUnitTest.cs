using System;
using DataStructures.Linear;
using MergeSort;
using SortingAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SortUnitTest
{
	[TestClass]
	public class SortUnitTest
	{
		private static readonly int[] _arrayToSort = new[] { 5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };
		private static readonly int[] _arrayToCountSplit = new[] { 1, 3, 5, 2, 4, 6 };
		private static readonly int[] _sortedArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		private static readonly int[] _sortedArrayIndex = new[] { 3, 5, 8, 4, 0, 7, 6, 9, 2, 1 };		
			
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
			var linkedList = new DataStructures.Linear.LinkedList<int>();
			linkedList.AddFirst(10);
			linkedList.AddFirst(9);
			linkedList.AddFirst(8);
			linkedList.AddFirst(8);

			linkedList.AddFirst(7);
			linkedList.AddFirst(6);
			linkedList.AddFirst(5);

			linkedList.AddFirst(4);
			linkedList.AddFirst(3);
			linkedList.AddFirst(2);
			linkedList.AddFirst(1);
			//Act
			var result = LinkedListSort.Sort(linkedList.First);
			//Asssert
			//Assert.IsTrue(arrayToSort.IsSorted());
		}

		[TestMethod]
		public void ShuffleTest()
		{
			//Arrange
			var linkedList = new DataStructures.Linear.LinkedList<int>();
			linkedList.AddFirst(10);
			linkedList.AddFirst(9);
			linkedList.AddFirst(8);
			linkedList.AddFirst(8);

			linkedList.AddFirst(7);
			linkedList.AddFirst(6);
			linkedList.AddFirst(5);

			linkedList.AddFirst(4);
			linkedList.AddFirst(3);
			linkedList.AddFirst(2);
			linkedList.AddFirst(1);
			//Act
			var result = LinkedListShuffle.Shuffle(linkedList.First);
			//Asssert
			//Assert.IsTrue(arrayToSort.IsSorted());
		}


		[TestMethod]
		public void InversionsCountTest()
		{
			//Arrange
			var arrayToSort = new int[_arrayToCountSplit.Length];
			_arrayToCountSplit.CopyTo(arrayToSort, 0);
			//Act
			var res = arrayToSort.InversionsCount();

			//Assert
			Assert.AreEqual(res.Item2, 3);
			
		}

		[TestMethod]
		public void IndirectSortTest()
		{
			//Arrange
			var arrayToSort = new int[_arrayToSort.Length];
			_arrayToSort.CopyTo(arrayToSort, 0);
			//Act
			var res = arrayToSort.IndirectSort();

			//Assert
			Assert.IsTrue(res.SequenceEqual(_sortedArrayIndex));

		}

		[TestMethod]
		public void TriplicatesTest()
		{
			//Arrange
			var triplicates = new Triplicates();
			var firstList = new List<string>();

			firstList.Add("Ann");
			firstList.Add("Annastacia");
			firstList.Add("Bridget");
			firstList.Add("John");

			var secondList = new List<string>();
			secondList.Add("Ann");
			secondList.Add("Annastacia");


			var thirdList = new List<string>();
			thirdList.Add("Ann");
			

			//Act
			var result = triplicates.GetTriplicates(firstList, secondList, thirdList);

			//Assert
			Assert.AreEqual(result.Count, 1);

		}

	}
}
