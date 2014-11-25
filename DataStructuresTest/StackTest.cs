using System;
using DataStructures.Linear;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTest
{
	[TestClass]
	public class StackTest
	{

		[TestMethod]
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

		[TestMethod]
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

		[TestMethod]
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
