using System.Collections.Generic;
using System.Linq;
using DataStructures;
using NUnit.Framework;

namespace DataStructuresTest
{
    [TestFixture]	
    public class BinarySearchTreeTest
    {
        [Test]
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

        [Test]
        public void Min()
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

        [Test]
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

        [Test]
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

        [Test]
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


        [Test]
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

            //Act
            testData.All(t =>
            {
                bst.Add(t.Key, t.Value);
                return true;				
            });
            var resultList = bst.All().ToList();

            //Assert
            Assert.AreEqual(resultList.Count, 6);

            Assert.AreEqual(resultList[0].Key, 2);
            Assert.AreEqual(resultList[1].Key, 3);
            Assert.AreEqual(resultList[2].Key, 4);
            Assert.AreEqual(resultList[3].Key, 5);
            Assert.AreEqual(resultList[4].Key, 6);
            Assert.AreEqual(resultList[5].Key, 7);			
        }

        [Test]
        public void RangeTest()
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

            //Act
            testData.All(t =>
            {
                bst.Add(t.Key, t.Value);
                return true;
            });
            var resultList = bst.Range(4, 7).ToList();

            //Assert
            Assert.AreEqual(resultList.Count, 4);

            Assert.AreEqual(resultList[0].Key, 4);
            Assert.AreEqual(resultList[1].Key, 5);
            Assert.AreEqual(resultList[2].Key, 6);
            Assert.AreEqual(resultList[3].Key, 7);
        }

        [Test]
        public void LevelOrderTraversalTest()
        {
            //Arrange
            var bst = new BinarySearchTree<int, string>();

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

        [Test]
        public void LevelOrderTraversalAfterRemovingTest()
        {
            //Arrange
            var bst = new BinarySearchTree<int, string>();

            //88 48 91 26 55 11 43 65 12 57 23 62
            var testData = new[]
            {
                new KeyValuePair<int, string>(88, "88"),
                new KeyValuePair<int, string>(48, "48"),
                new KeyValuePair<int, string>(91, "91"),
                new KeyValuePair<int, string>(26, "26"),
                new KeyValuePair<int, string>(55, "55"),
                new KeyValuePair<int, string>(11, "11"),
                new KeyValuePair<int, string>(43, "43"),
                new KeyValuePair<int, string>(65, "65"),
                new KeyValuePair<int, string>(12, "12"),
                new KeyValuePair<int, string>(57, "57"),
                new KeyValuePair<int, string>(23, "23"),
                new KeyValuePair<int, string>(62, "62"),
            };

            //Act
            testData.All(t =>
            {
                bst.Add(t.Key, t.Value);
                return true;
            });
            var result = bst.LevelOrderTraversal();


            //Assert
            Assert.AreEqual(result.Count(), 12);

            Assert.AreEqual(result.ElementAt(0).Key, 88);
            Assert.AreEqual(result.ElementAt(1).Key, 48);
            Assert.AreEqual(result.ElementAt(2).Key, 91);
            Assert.AreEqual(result.ElementAt(3).Key, 26);
            Assert.AreEqual(result.ElementAt(4).Key, 55);
            Assert.AreEqual(result.ElementAt(5).Key, 11);
            Assert.AreEqual(result.ElementAt(6).Key, 43);
            Assert.AreEqual(result.ElementAt(7).Key, 65);
            Assert.AreEqual(result.ElementAt(8).Key, 12);
            Assert.AreEqual(result.ElementAt(9).Key, 57);
            Assert.AreEqual(result.ElementAt(10).Key, 23);
            Assert.AreEqual(result.ElementAt(11).Key, 62);


            //91 12 48
            bst.Delete(91);
            bst.Delete(12);
            bst.Delete(48);
            result = bst.LevelOrderTraversal();

            //Assert
            Assert.AreEqual(result.Count(), 9);

            Assert.AreEqual(result.ElementAt(0).Key, 88);
            Assert.AreEqual(result.ElementAt(1).Key, 55);
            Assert.AreEqual(result.ElementAt(2).Key, 26);
            Assert.AreEqual(result.ElementAt(3).Key, 65);
            Assert.AreEqual(result.ElementAt(4).Key, 11);
            Assert.AreEqual(result.ElementAt(5).Key, 43);
            Assert.AreEqual(result.ElementAt(6).Key, 57);
            Assert.AreEqual(result.ElementAt(7).Key, 23);
            Assert.AreEqual(result.ElementAt(8).Key, 62);

        }
    }
}
