using System;
using NUnit.Framework;

namespace DataStructures.Tests
{
    [Category("List<T>")]
    [TestFixture]
    [SetUICulture("en-us")]
    public class ListTests
    {
        private List<int> _list = null;

        [SetUp]
        public void SetUp()
        {
            _list = new List<int>();
        }

        [TestCase(new[] { 0 })]
        [TestCase(new[] { 0, 1 })]
        [TestCase(new[] { 0, 1, 2 })]
        [TestCase(new[] { 0, 1, 2, 3 })]
        public void Add_OnValidParam_ShouldAddElementToList(int[] items)
        {
            //Act
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Assert
            CollectionAssert.AreEquivalent(items, _list);
        }

        [TestCase(new[] { 0 }, 0, 0)]
        [TestCase(new[] { 0, 1 }, 1, 1)]
        [TestCase(new[] { 0, 1, 2 }, 2, 2)]
        [TestCase(new[] { 0, 1, 2, 3 }, 3, 3)]
        public void IndexerGet_ShouldReturnExpectedValueByIndex(int[] items, int index, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            var actualResult = _list[index];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-1)]
        [TestCase(1)]
        public void IndexerGet_OnOutOfRangeIndex_ShouldThrowArgumentOutOfRangeException(int index)
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var res = _list[index];
            });
        }

        [TestCase(new[] { 0 }, 0, 1)]
        [TestCase(new[] { 0, 1 }, 1, 2)]
        [TestCase(new[] { 0, 1, 2 }, 2, 3)]
        [TestCase(new[] { 0, 1, 2, 3 }, 3, 4)]
        public void IndexerSet_ShouldContainExpectedValueByIndex(int[] items, int index, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            _list[index] = expectedResult;
            //Act
            var actualResult = _list[index];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-1)]
        [TestCase(1)]
        public void IndexerSet_OnOutOfRangeIndex_ShouldThrowArgumentOutOfRangeException(int index)
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _list[index] = Int32.MaxValue;
            });
        }

        [TestCase(new[] { 0 }, 1)]
        [TestCase(new[] { 0, 1 }, 2)]
        [TestCase(new[] { 0, 1, 2 }, 3)]
        [TestCase(new[] { 0, 1, 2, 3 }, 4)]
        public void Count_AfterAdd_ReturnsExpectedResult(int[] items, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            var actualResult = _list.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 0 })]
        [TestCase(new[] { 0, 1 })]
        [TestCase(new[] { 0, 1, 2 })]
        [TestCase(new[] { 0, 1, 2, 3 })]
        public void Clear_RemovesAllItemsFromList(int[] items)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
             _list.Clear();
            //Assert
            CollectionAssert.IsEmpty(_list);
        }

        [TestCase(new[] { 0 }, 0, true)]
        [TestCase(new[] { 0, 1 }, 1, true)]
        [TestCase(new[] { 0, 1, 2 }, 2, true)]
        [TestCase(new[] { 0, 1, 2, 3 }, 4, false)]
        [TestCase(new[] { 0, 1, 2, 3 }, 6, false)]
        public void Contains_ReturnsExpectedResult(int[] items, int valueToFind, bool expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            var actualResult = _list.Contains(valueToFind);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new[] { 0 }, 0, 0)]
        [TestCase(new[] { 0, 1 }, 1, 1)]
        [TestCase(new[] { 0, 1, 2 }, 2, 2)]
        [TestCase(new[] { 0, 1, 2, 3 }, 4, -1)]
        [TestCase(new[] { 0, 1, 2, 3 }, 6, -1)]
        public void Index_ReturnsExpectedResult(int[] items, int valueToFind, int expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            var actualResult = _list.IndexOf(valueToFind);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void IsReadOnly_ReturnsFalse()
        {
            Assert.IsFalse(_list.IsReadOnly);
        }

        [TestCase(new[] { 0 }, 0, new[] { 0 })]
        [TestCase(new[] { 0, 1 }, 1, new[] { 0, 0, 1 })]
        [TestCase(new[] { 0, 1, 2 }, 0, new[] { 0, 1, 2 })]
        [TestCase(new[] { 0, 1, 2, 3 }, 4, new [] { 0, 0, 0, 0, 0, 1, 2, 3 })]
        public void CopyTo_ContainsExpectedItems(int[] items, int index, int[] expectedItems)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            var actualResult = new int[expectedItems.Length];
            _list.CopyTo(actualResult, index);
            //Assert
            Assert.AreEqual(expectedItems, actualResult);
        }

        [Test]
        public void CopyTo_OnNullArrayParam_ThorwsArgumentNullException()
        {            
            //Assert
            Assert.Throws<ArgumentNullException>(() => _list.CopyTo(null, 0));
        }

        [TestCase(new[] { 0 }, 0, new int[]{})]
        [TestCase(new[] { 0, 1 }, 1, new[] { 0 })]
        [TestCase(new[] { 0, 1, 2 }, 0, new[] { 1, 2 })]
        [TestCase(new[] { 0, 1, 2, 3 }, 3, new[] { 0, 1, 2 })]
        public void RemoveAt_OnValidParams_RemovesExpectedItems(int[] items, int index, int[] expectedItems)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            _list.RemoveAt(index);
            //Assert
            Assert.AreEqual(expectedItems, _list);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new[] { 0 }, 1)]
        [TestCase(new[] { 0, 1 }, -1)]
        public void RemoveAt_OnInvalidIndex_ThrowsArgumentOutOfRangeException(int[] items, int index)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _list.RemoveAt(index));
        }

        [TestCase(new int[] { }, 0, Int32.MaxValue)]
        [TestCase(new[] { 0 }, 1, Int32.MaxValue)]
        [TestCase(new[] { 0, 1 }, 1, Int32.MaxValue)]
        public void Insert_OnValidParams_ContainsExpectedItem(int[] items, int index, int expectedItem)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            _list.Insert(index, expectedItem);
            //Assert
            Assert.AreEqual(expectedItem, _list[index]);
            CollectionAssert.Contains(_list, expectedItem);
        }

        [TestCase(new int[] { }, 1, Int32.MinValue)]
        [TestCase(new[] { 0 }, 5, Int32.MinValue)]
        [TestCase(new[] { 0, 1 }, -1, Int32.MinValue)]
        public void Insert_OnInvalidIndex_ThrowsArgumentOutOfRangeException(int[] items, int index, int itemValue)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _list.Insert(index, itemValue));
        }

        [TestCase(new int[] { }, 0, false)]
        [TestCase(new[] { 0 }, 0, true)]
        [TestCase(new[] { 0, 1 }, 1, true)]
        public void Remove_ReturnsExpectedValue(int[] items, int itemToRemove, bool expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            var actualResult = _list.Remove(itemToRemove);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[] { }, 0, new int[] { })]
        [TestCase(new[] { 0 }, 0,  new int[] { })]
        [TestCase(new[] { 0, 1 }, 1, new[] { 0 })]
        public void Remove_ReturnsExpectedValue(int[] items, int itemToRemove, int[] expectedResult)
        {
            //Arrange
            foreach (var item in items)
            {
                _list.Add(item);
            }
            //Act
            var actualResult = _list.Remove(itemToRemove);
            //Assert
            CollectionAssert.AreEquivalent(_list, expectedResult);
        }
    }
}
