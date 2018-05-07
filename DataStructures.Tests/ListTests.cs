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

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3 })]
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

        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[] { 0, 1 }, 1, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 2, 2)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 3, 3)]
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

        [TestCase(new int[] { 0 }, 0, 1)]
        [TestCase(new int[] { 0, 1 }, 1, 2)]
        [TestCase(new int[] { 0, 1, 2 }, 2, 3)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 3, 4)]
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

        [TestCase(new int[] { 0 }, 1)]
        [TestCase(new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { 0, 1, 2 }, 3)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 4)]
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

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3 })]
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

        [TestCase(new int[] { 0 }, 0, true)]
        [TestCase(new int[] { 0, 1 }, 1, true)]
        [TestCase(new int[] { 0, 1, 2 }, 2, true)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 4, false)]
        [TestCase(new int[] { 0, 1, 2, 3 }, 6, false)]
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
    }
}
