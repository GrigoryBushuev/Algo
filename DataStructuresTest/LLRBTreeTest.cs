using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using System.Collections.Generic;
using System.Linq;

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

            //70 40 81 13 57 75 85 10 32 48 66 82 43  

            var testData = new[]
            {
                new KeyValuePair<int, string>(70, "70"),
                new KeyValuePair<int, string>(40, "40"),
                new KeyValuePair<int, string>(81, "81"),
                new KeyValuePair<int, string>(13, "13"),
                new KeyValuePair<int, string>(57, "57"),
                new KeyValuePair<int, string>(75, "75"),
                new KeyValuePair<int, string>(85, "85"),
                new KeyValuePair<int, string>(10, "10"),
                new KeyValuePair<int, string>(32, "32"),
                new KeyValuePair<int, string>(48, "48"),
                new KeyValuePair<int, string>(66, "66"),
                new KeyValuePair<int, string>(82, "82"),
                new KeyValuePair<int, string>(43, "43"),
            };



            //Act
            Array.ForEach(testData, t =>
            {
                bst.Add(t.Key, t.Value);
            });

            var result = bst.LevelOrderTraversal();

            //Assert
            Assert.AreEqual(result.ElementAt(0).Key, 70);
            Assert.AreEqual(result.ElementAt(1).Key, 40);
            Assert.AreEqual(result.ElementAt(2).Key, 81);
            Assert.AreEqual(result.ElementAt(3).Key, 13);
            Assert.AreEqual(result.ElementAt(4).Key, 57);
            Assert.AreEqual(result.ElementAt(5).Key, 75);
            Assert.AreEqual(result.ElementAt(6).Key, 85);
            Assert.AreEqual(result.ElementAt(7).Key, 10);
            Assert.AreEqual(result.ElementAt(8).Key, 32);
            Assert.AreEqual(result.ElementAt(9).Key, 48);
            Assert.AreEqual(result.ElementAt(10).Key, 66);
            Assert.AreEqual(result.ElementAt(11).Key, 82);
            Assert.AreEqual(result.ElementAt(12).Key, 43);
        }
    }
}
