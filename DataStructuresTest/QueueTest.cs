using System;
using DataStructures.Linear;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTest
{
	[TestClass]
	public class QueueTest
	{
		[TestMethod]
		public void EnqueueTest()
		{
			//Arrange
			Queue<int> queue = new Queue<int>();
			var expectedResult = 0;

			queue.Enqueue(expectedResult);
			//Act
			var actualResult = queue.Peek();
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void DequeueTest()
		{
			//Arrange
			Queue<int> queue = new Queue<int>();
			var expectedResult = 0;

			queue.Enqueue(expectedResult);
			//Act
			var actualResult = queue.Dequeue();
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void PeekTest()
		{
			//Arrange
			Queue<int> queue = new Queue<int>();
			var expectedResult = 0;

			queue.Enqueue(expectedResult);
			//Act
			var actualResult = queue.Peek();
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
