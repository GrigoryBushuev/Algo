using DataStructures.Linear;
using NUnit.Framework;

namespace DataStructuresTest
{
	[TestFixture]
	public class QueueTest
	{
		[Test]
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

		[Test]
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

		[Test]
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
