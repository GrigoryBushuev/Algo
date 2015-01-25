using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnionFind;

namespace UnionFindTest
{
	[TestClass]
	public class UnionFindUnitTest
	{
		[TestMethod]
		public void QuickFindTest()
		{
			//Arrange 
			var quickFind = new QuickFind(10);
			//Act
			quickFind.Union(4, 3);
			quickFind.Union(3, 8);
			quickFind.Union(6, 5);
			quickFind.Union(9, 4);
			quickFind.Union(2, 1);
			quickFind.Union(8, 9);
			quickFind.Union(5, 0);
			quickFind.Union(7, 2);
			quickFind.Union(6, 1);
			quickFind.Union(1, 0);
			quickFind.Union(6, 7);
			//Assert
			Assert.IsTrue(quickFind.IsConnected(4, 3));
			Assert.IsTrue(quickFind.IsConnected(3, 8));
			Assert.IsTrue(quickFind.IsConnected(6, 5));
			Assert.IsTrue(quickFind.IsConnected(9, 4));
			Assert.IsTrue(quickFind.IsConnected(2, 1));
			Assert.IsTrue(quickFind.IsConnected(8, 9));
			Assert.IsTrue(quickFind.IsConnected(5, 0));
			Assert.IsTrue(quickFind.IsConnected(7, 2));
			Assert.IsTrue(quickFind.IsConnected(6, 1));
			Assert.IsTrue(quickFind.IsConnected(1, 0));
			Assert.IsTrue(quickFind.IsConnected(6, 7));			
		}
	}
}
