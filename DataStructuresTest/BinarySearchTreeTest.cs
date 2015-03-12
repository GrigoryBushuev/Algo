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
		public void MaxTest()
		{
			//Arrange
			var bst = new BinarySearchTree<int, string>();
			bst.Add(5, "A");
			bst.Add(4, "B");
			bst.Add(6, "C");
			bst.Add(0, "D");
			bst.Add(7, "E");
			//Act
			var testResult = bst.Max();
			//Assert
			Assert.AreEqual(testResult.Key, 7);
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
			var testResult = bst.GetNodeByKey(5).LeftNode;

			//Assert
			Assert.AreEqual(testResult.Key, 4);
		}


		[TestMethod]
		public void AllTest()
		{
			//Arrange
			var bst = new BinarySearchTree<int, string>();
			var testData = new[]
			{
				new KeyValuePair<int, string>(5, "A"),
				new KeyValuePair<int, string>(3, "B"),
				new KeyValuePair<int, string>(6, "C"),
				new KeyValuePair<int, string>(2, "D"),
				new KeyValuePair<int, string>(7, "E"),
				new KeyValuePair<int, string>(4, "F"),
			};

			//var res = testData. (t => bst.Add(t.Key, t.Value));

			//Act
			var testResult = bst.All();
			//Assert
			
		}
	}
}
