using NUnit.Framework;

namespace DataStructures.Tests.Linear
{
    [Category("LinkedList")]
    [TestFixture]
    public class LinkedListTest
    {
        private DataStructures.Linear.LinkedList<int> _linkedList;

        [SetUp]
        public void SetUp()
        {
            //Arrange
            _linkedList = new DataStructures.Linear.LinkedList<int>();
        }

        [TestCase(new int[] { 0, 1, 2 })]
        public void AddFirst_OnValidParam_ContainsExpectedItems(int[] expectedItems)
        {
            //Act
            foreach (var item in expectedItems)
            {
                _linkedList.AddFirst(item);
            }
            //Assert
            CollectionAssert.AreEquivalent(_linkedList, expectedItems);
        }

        [TestCase(new int[] { 0, 1, 2 })]
        public void AddLast_OnValidParam_ContainsExpectedItems(int[] expectedItems)
        {
            //Act
            foreach (var item in expectedItems)
            {
                _linkedList.AddLast(item);
            }
            //Assert
            CollectionAssert.AreEquivalent(_linkedList, expectedItems);
        }

        [TestCase(new int[] { 0, 1, 2 }, 2)]
        public void RemoveFirst_OnValidParam_DoesNotContainRemovedFirstItem(int[] itemsToAdd, int removedItem)
        {
            //Arrange
            foreach (var item in itemsToAdd)
            {
                _linkedList.AddFirst(item);
            }
            //Act
            _linkedList.RemoveFirst();
            //Assert
            CollectionAssert.DoesNotContain(_linkedList, removedItem);
        }

        [TestCase(new int[] { 0, 1, 2 }, 2)]
        public void RemoveLast_OnValidParam_DoesNotContainRemovedLastItem(int[] itemsToAdd, int removedItem)
        {
            //Arrange
            foreach (var item in itemsToAdd)
            {
                _linkedList.AddLast(item);
            }            
            //Act
            _linkedList.RemoveLast();
            //Assert
            CollectionAssert.DoesNotContain(_linkedList, removedItem);
        }

        [TestCase(new int[] { 0, 1, 2 }, 3)]
        [TestCase(new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { 0 }, 1)]
        [TestCase(new int[] { }, 0)]
        public void Count_ReturnsExpectedResult(int[] itemsToAdd, int expectedResult)
        {
            //Arrange
            foreach (var item in itemsToAdd)
            {
                _linkedList.AddLast(item);
            }
            //Act
            var actualResult = _linkedList.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}