using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DataStructuresTest
{
	[TestFixture]
	public class LinkedListTest
	{
		[Test]
		public void LinkedListAddFirstIsNotEmpty()
		{
			//Arrange
			DataStructures.Linear.LinkedList<int> linkedList = new DataStructures.Linear.LinkedList<int>();

			//Act
			linkedList.AddFirst(0);

			//Assert
			Assert.IsFalse(linkedList.IsEmpty);			
		}


		[Test]
		public void LinkedListAddLastIsNotEmpty()
		{
			//Arrange
			DataStructures.Linear.LinkedList<int> linkedList = new DataStructures.Linear.LinkedList<int>();

			//Act
			linkedList.AddLast(0);			

			//Assert
			Assert.IsFalse(linkedList.IsEmpty);
		}

		[Test]
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

		[Test]
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
