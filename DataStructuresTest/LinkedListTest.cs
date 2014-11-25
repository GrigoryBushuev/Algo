using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTest
{
	[TestClass]
	public class LinkedListTest
	{
		[TestMethod]
		public void LinkedListAddFirstIsNotEmpty()
		{
			//Arrange
			DataStructures.Linear.LinkedList<int> linkedList = new DataStructures.Linear.LinkedList<int>();

			//Act
			linkedList.AddFirst(0);

			//Assert
			Assert.IsFalse(linkedList.IsEmpty);			
		}


		[TestMethod]
		public void LinkedListAddLastIsNotEmpty()
		{
			//Arrange
			DataStructures.Linear.LinkedList<int> linkedList = new DataStructures.Linear.LinkedList<int>();

			//Act
			linkedList.AddLast(0);			

			//Assert
			Assert.IsFalse(linkedList.IsEmpty);
		}

		[TestMethod]
		public void LinkedListRemoveFirst()
		{
			//Arrange
			DataStructures.Linear.LinkedList<int> linkedList = new DataStructures.Linear.LinkedList<int>();

			//Act
			linkedList.AddFirst(0);
			linkedList.RemoveFirst();

			//Assert
			Assert.IsTrue(linkedList.IsEmpty);
		}

		[TestMethod]
		public void LinkedListCount()
		{
			//Arrange
			DataStructures.Linear.LinkedList<int> linkedList = new DataStructures.Linear.LinkedList<int>();

			//Act
			linkedList.AddFirst(0);
			//Assert
			Assert.IsTrue(linkedList.Count > 0);
			linkedList.RemoveFirst();

			//Assert
			Assert.IsTrue(linkedList.Count == 0);
		}

	}
}
