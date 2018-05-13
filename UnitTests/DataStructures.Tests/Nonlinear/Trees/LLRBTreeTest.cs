using DataStructures.Nonlinear.Trees;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Tests.Nonlinear.Trees
{
    [Ignore("Rewrite")]
    [Category("Left-leaning red–black tree")]
    [SetUICulture("en-us")]
    [TestFixture]
    public class LLRBTreeTest
    {
        [Test]
        public void AddTest()
        {
            //Arrange
            var bst = new RedBlackTree<int, string>();

            // 33 28 63 20 31 39 79 10 35 60          ( red links = 10 39 )
            var testData = new[]
            {
                new KeyValuePair<int, string>(33, "33"),
                new KeyValuePair<int, string>(28, "28"),
                new KeyValuePair<int, string>(63, "63"),
                new KeyValuePair<int, string>(20, "20"),
                new KeyValuePair<int, string>(31, "31"),
                new KeyValuePair<int, string>(39, "39"),
                new KeyValuePair<int, string>(79, "79"),
                new KeyValuePair<int, string>(10, "10"),
                new KeyValuePair<int, string>(35, "35"),
                new KeyValuePair<int, string>(60, "60"),
            };

            //Act
            Array.ForEach(testData, t =>
            {
                bst.Add(t.Key, t.Value);
            });


            bst.Add(75, "75");
            bst.Add(38, "38");
            bst.Add(12, "12");

            var result = bst.LevelOrderTraversal();

            //Assert
            Assert.AreEqual(result.ElementAt(0).Key, 33);
            Assert.AreEqual(result.ElementAt(1).Key, 28);
            Assert.AreEqual(result.ElementAt(2).Key, 63);
            Assert.AreEqual(result.ElementAt(3).Key, 12);
            Assert.AreEqual(result.ElementAt(4).Key, 31);
            Assert.AreEqual(result.ElementAt(5).Key, 39);
            Assert.AreEqual(result.ElementAt(6).Key, 79);
            Assert.AreEqual(result.ElementAt(7).Key, 10);
            Assert.AreEqual(result.ElementAt(8).Key, 20);
            Assert.AreEqual(result.ElementAt(9).Key, 38);
            Assert.AreEqual(result.ElementAt(10).Key, 60);
            Assert.AreEqual(result.ElementAt(11).Key, 75);
            Assert.AreEqual(result.ElementAt(12).Key, 35);

            //Assert are red nodes
            Assert.IsTrue(result.ElementAt(3).IsRed);
            Assert.IsTrue(result.ElementAt(5).IsRed);
            Assert.IsTrue(result.ElementAt(11).IsRed);
        }


        [Test]
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

            //Assert are red nodes
            Assert.IsTrue(result.ElementAt(1).IsRed);
            Assert.IsTrue(result.ElementAt(12).IsRed);
            Assert.IsTrue(result.ElementAt(11).IsRed);
        }
    }
}
