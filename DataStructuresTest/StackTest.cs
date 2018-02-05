using System;
using DataStructures.Linear;
using NUnit.Framework;

namespace DataStructuresTest
{
	[TestFixture]
	public class StackTest
	{

		[Test]
		public void PushTest()
		{
			//Arrange
			Stack<int> stack = new Stack<int>();
			var expectedResult = 0;
			stack.Push(expectedResult);
			//Act
			var actualResult = stack.Peek();
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void PeekTest()
		{
			//Arrange
			Stack<int> stack = new Stack<int>();
			var expectedResult = 0;
			stack.Push(expectedResult);
			//Act
			var actualResult = stack.Peek();
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void PopTest()
		{
			//Arrange
			Stack<int> stack = new Stack<int>();
			var expectedResult = 0;
			stack.Push(expectedResult);
			//Act
			var actualResult = stack.Pop();
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
