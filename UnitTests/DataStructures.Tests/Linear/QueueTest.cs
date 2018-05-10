using DataStructures.Linear;
using NUnit.Framework;

namespace DataStructures.Tests.Linear
{
    [Category("Queue<T>")]
    [TestFixture]
    public class QueueTest
    {
        private Queue<int> _queue;

        [SetUp]
        public void SetUp()
        {
            _queue = new Queue<int>();
        }

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3 })]
        public void Enqueue_OnValidParam_ContainsEnqueuedItems(int[] expectedItems)
        {
            //Act
            foreach (var item in expectedItems)
            {
                _queue.Enqueue(item);
            }           
            //Assert
            CollectionAssert.AreEquivalent(expectedItems, _queue);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 0)]
        public void Dequeue_ReturnsExpectedResult(int[] items, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _queue.Enqueue(item);
            }
            //Act
            var actualResult = _queue.Dequeue();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);            
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 0)]
        public void Dequeue_DoesNotContainDequeuedItem(int[] items, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _queue.Enqueue(item);
            }
            //Act
            _queue.Dequeue();
            //Assert
            CollectionAssert.DoesNotContain(_queue, expectedResult);
        }

        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 0)]
        [TestCase(new int[] { 0, 1, 2 }, 0)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 0)]
        public void Peek_ReturnsExpectedResult(int[] items, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _queue.Enqueue(item);
            }
            //Act
            var actualResult = _queue.Peek();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
