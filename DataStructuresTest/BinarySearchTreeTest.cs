using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresTest
{
	[TestClass]	
	public class BinarySearchTreeTest
	{
		[TestMethod]
		public void AddTest()
		{
			var bst = new BinarySearchTree<int, string>();
			bst.Add(5, "A");
			bst.Add(4, "B");
			bst.Add(6, "C");
			bst.Add(3, "D");
			bst.Add(7, "E");

			Assert.AreEqual(bst.Size, 5);
		}

		[TestMethod]
		public void MinTest()
		{
			//Arrange
			var bst = new BinarySearchTree<int, string>();
			bst.Add(5, "A");
			bst.Add(4, "B");
			bst.Add(6, "C");
			bst.Add(0, "D");
			bst.Add(7, "E");
			//Act
			var testResult = bst.Min();
			//Assert
			Assert.AreEqual(testResult.Key, 0);
		}

		[TestMethod]
		public void DeleteMinTest()
		{
			//Arrange
			var bst = new BinarySearchTree<int, string>();
			bst.Add(5, "A");
			bst.Add(3, "B");
			bst.Add(6, "C");
			bst.Add(2, "D");
			bst.Add(7, "E");
			bst.Add(4, "F");
			//Act
			bst.DeleteMin();
			var testResult = bst.Min();
			//Assert
			Assert.AreEqual(testResult.Key, 3);
		}

		[TestMethod]
		public void DeleteTest()
		{
			//Arrange
			var bst = new BinarySearchTree<int, string>();
			bst.Add(5, "A");
			bst.Add(3, "B");
			bst.Add(6, "C");
			bst.Add(2, "D");
			bst.Add(7, "E");
			bst.Add(4, "F");
			//Act
			bst.Delete(3);
			
			//Assert
			//Assert.AreEqual(testResult.Key, 3);
		}
	}
}
