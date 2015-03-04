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
		}
	}
}
