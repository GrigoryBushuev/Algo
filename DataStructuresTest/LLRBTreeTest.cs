using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using System.Collections.Generic;

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


        [TestMethod]
        public void LevelOrderTraversalTest()
        {
            //Arrange
            var bst = new RedBlackTree<int, string>();

            //43 10 78 84 75 65 89 34 29 54 

            var testData = new[]
            {
                new KeyValuePair<int, string>(43, "43"),
                new KeyValuePair<int, string>(10, "10"),
                new KeyValuePair<int, string>(78, "78"),
                new KeyValuePair<int, string>(84, "84"),
                new KeyValuePair<int, string>(75, "75"),
                new KeyValuePair<int, string>(65, "65"),
                new KeyValuePair<int, string>(89, "89"),
                new KeyValuePair<int, string>(34, "34"),
                new KeyValuePair<int, string>(29, "29"),
                new KeyValuePair<int, string>(54, "54"),
            };

            //Act
            testData.All(t =>
            {
                bst.Add(t.Key, t.Value);
                return true;
            });
            var result = bst.LevelOrderTraversal();

            //Assert
            Assert.AreEqual(result.Count(), 10);

            Assert.AreEqual(result.ElementAt(0).Key, 43);
            Assert.AreEqual(result.ElementAt(1).Key, 10);
            Assert.AreEqual(result.ElementAt(2).Key, 78);
            Assert.AreEqual(result.ElementAt(3).Key, 34);
            Assert.AreEqual(result.ElementAt(4).Key, 75);
            Assert.AreEqual(result.ElementAt(5).Key, 84);
            Assert.AreEqual(result.ElementAt(6).Key, 29);
            Assert.AreEqual(result.ElementAt(7).Key, 65);
            Assert.AreEqual(result.ElementAt(8).Key, 89);
            Assert.AreEqual(result.ElementAt(9).Key, 54);
        }
    }
}
