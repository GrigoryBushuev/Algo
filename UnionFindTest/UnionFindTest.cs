using NUnit.Framework;
using UnionFind;
using System.Diagnostics;

namespace UnionFindTest
{
    [Ignore("Rewrite")]
    [Category("UnionFind")]
    [TestFixture]
    public class UnionFindUnitTest
    {
        [Test]
        public void QuickFindTest()
        {
            //Arrange 
            var quickFind = new QuickFind(10);
            //Act

            //7-9 0-3 5-0 5-6 0-8 4-1
            quickFind.Union(7, 9);
            quickFind.Union(0, 3);
            quickFind.Union(5, 0);
            quickFind.Union(5, 6);
            quickFind.Union(0, 8);
            quickFind.Union(4, 1);
            //Assert
            Assert.IsTrue(quickFind.IsConnected(7, 9));
            Assert.IsTrue(quickFind.IsConnected(0, 3));
            Assert.IsTrue(quickFind.IsConnected(5, 0));

            Assert.IsTrue(quickFind.IsConnected(5, 6));
            Assert.IsTrue(quickFind.IsConnected(0, 8));
            Assert.IsTrue(quickFind.IsConnected(4, 1));

            foreach (var component in quickFind.Components)
            {
                Trace.WriteLine(component);		 
            } 
        }

        [Test]
        public void WeightedQuickUnionTest()
        {
            //Arrange 
            var weightedQuickUnion = new WeightedQuickUnion(10);

            //7-9 6-9 2-0 5-8 7-4 6-1 0-5 4-3 2-4 

            //Act
            weightedQuickUnion.Union(7, 9);
            weightedQuickUnion.Union(6, 9);
            weightedQuickUnion.Union(2, 0);
            weightedQuickUnion.Union(5, 8);
            weightedQuickUnion.Union(7, 4);
            weightedQuickUnion.Union(6, 1);
            weightedQuickUnion.Union(0, 5);
            weightedQuickUnion.Union(4, 3);
            weightedQuickUnion.Union(2, 4);
            //Assert
            Assert.IsTrue(weightedQuickUnion.IsConnected(7, 9));
            Assert.IsTrue(weightedQuickUnion.IsConnected(6, 9));
            Assert.IsTrue(weightedQuickUnion.IsConnected(2, 0));
            Assert.IsTrue(weightedQuickUnion.IsConnected(5, 8));
            Assert.IsTrue(weightedQuickUnion.IsConnected(7, 4));
            Assert.IsTrue(weightedQuickUnion.IsConnected(6, 1));
            Assert.IsTrue(weightedQuickUnion.IsConnected(0, 5));
            Assert.IsTrue(weightedQuickUnion.IsConnected(4, 3));
            Assert.IsTrue(weightedQuickUnion.IsConnected(2, 4));

            foreach (var component in weightedQuickUnion.Components)
            {
                Trace.WriteLine(component);
            } 
        }
    }
}
