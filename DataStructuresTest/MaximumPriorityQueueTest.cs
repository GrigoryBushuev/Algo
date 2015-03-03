using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructuresTest
{
	[TestClass]
	public class MaximumPriorityQueueTest
	{
		[TestMethod]
		public void InsertionTest()
		{
			//84 59 51 36 55 19 13 33 26 34 
			var maxPQ = new MaximumPriorityQueue<int>();
			maxPQ.Insert(84);
			maxPQ.Insert(59);
			maxPQ.Insert(51);
			maxPQ.Insert(36);
			maxPQ.Insert(55);
			maxPQ.Insert(19);
			maxPQ.Insert(13);
			maxPQ.Insert(33);
			maxPQ.Insert(26);
			maxPQ.Insert(34);
			maxPQ.Insert(61);
			maxPQ.Insert(93);
			maxPQ.Insert(62);

			Assert.AreEqual(maxPQ.Size, 13);
			Assert.AreEqual(maxPQ.Max, 93);
		}

		[TestMethod]
		public void DeleteMaxTest()
		{
			//88 80 72 65 70 68 54 11 49 42 
			var maxPQ = new MaximumPriorityQueue<int>();
			maxPQ.Insert(88);
			maxPQ.Insert(80);
			maxPQ.Insert(72);
			maxPQ.Insert(65);
			maxPQ.Insert(70);
			maxPQ.Insert(68);
			maxPQ.Insert(54);
			maxPQ.Insert(11);
			maxPQ.Insert(49);
			maxPQ.Insert(42);

			maxPQ.DeleteMax();
			maxPQ.DeleteMax();
			maxPQ.DeleteMax();

			Assert.AreEqual(maxPQ.Size, 7);
			Assert.AreEqual(maxPQ.Max, 72);
		}
	}
}
