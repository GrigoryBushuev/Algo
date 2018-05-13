using DataStructures.Linear;
using NUnit.Framework;

namespace DataStructures.Tests.Linear
{
    [Category("LinkedQueue<T>")]
    [TestFixture]
    public class LinkedQueueTest
    {
        private LinkedQueue<int> _queue;

        [SetUp]
        public void SetUp()
        {
            _queue = new LinkedQueue<int>();
        }

        [TestCase(new[] { 0 })]
        [TestCase(new[] { 0, 1 })]
        [TestCase(new[] { 0, 1, 2 })]
        [TestCase(new[] { 0, 1, 2, 3 })]
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

        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { 0, 1 }, 0)]
        [TestCase(new[] { 0, 1, 2 }, 0)]
        [TestCase(new[] { 0, 1, 2, 3 }, 0)]
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

        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { 0, 1 }, 0)]
        [TestCase(new[] { 0, 1, 2 }, 0)]
        [TestCase(new[] { 0, 1, 2, 3 }, 0)]
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

        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { 0, 1 }, 0)]
        [TestCase(new[] { 0, 1, 2 }, 0)]
        [TestCase(new[] { 0, 1, 2, 3 }, 0)]
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
