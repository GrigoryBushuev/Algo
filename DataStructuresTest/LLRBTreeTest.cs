using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructuresTest
{
    [TestClass]
    public class LLRBTreeTest
    {

        [TestMethod]
        public void AddTest()
        {
            var bst = new RedBlackTree<int,string>();
            bst.Add(5, "A");
            bst.Add(4, "B");
            bst.Add(6, "C");
            bst.Add(3, "D");
            bst.Add(7, "E");

            //Assert.AreEqual(bst.Size, 5);

        }
    }
}
