using System;
using NUnit.Framework;

namespace Utils.Tests
{
    [Category("ArrayUtils")]
    [TestFixture]
    public class ArrayUtilsTest
    {
        private int[] _array;

        [SetUp]
        public void SetUp()
        {
            _array = new[] { 11, 12, 17, 19, 23, 29, 31, 34, 40, 50, 70, 76, 81, 87, 89 };
        }

        [TestCase(11)]
        [TestCase(89)]
        [TestCase(29)]
        public void Rank_OnNullParam_ThrowsArgumentNullException(int keyToFind)
        {
            //Act, Assert
            Assert.Throws<ArgumentNullException>(() => ArrayUtils.Rank(null, keyToFind));
        }


        [TestCase(11, 0)]
        [TestCase(89, 14)]
        [TestCase(29, 5)]
        public void Rank_OnValidParam_ReturnsExpectedResult(int keyToFind, int expectedResult)
        {
            //Act
            var actualResult = _array.Rank(keyToFind);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void Rank_OnInvalidParam_ReturnsNull(int keyToFind)
        {
            var actualResult = _array.Rank(keyToFind);
            Assert.IsNull(actualResult);
        }

        [TestCase(0, 0, new[] { 11, 12, 17, 19, 23, 29, 31, 34, 40, 50, 70, 76, 81, 87, 89 })]
        [TestCase(0, 1, new[] { 12, 11, 17, 19, 23, 29, 31, 34, 40, 50, 70, 76, 81, 87, 89 })]
        [TestCase(0, 14, new[] { 89, 12, 17, 19, 23, 29, 31, 34, 40, 50, 70, 76, 81, 87, 11 })]
        public void Swap_OnValidParam_ReturnsExpectedResult(int i, int j, int[] expectedResult)
        {
            //Act
            _array.Swap(i, j);
            //Assert
            Assert.AreEqual(expectedResult, _array);
        }

        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 14)]
        public void Swap_OnNullParam_ThrowsArgumentNullException(int i, int j)
        {
            //Act, Assert
            Assert.Throws<ArgumentNullException>(() => ArrayUtils.Swap<int>(null, i, j));
        }

        [TestCase(-1, 0)]
        [TestCase(15, 1)]
        public void Swap_OnOutOfRangeiParam_ThrowsArgumentNullException(int i, int j)
        {
            //Act, Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _array.Swap(i, j));
            Assert.That(ex.ParamName, Is.EqualTo(nameof(i)));
        }

        [TestCase(0, -1)]
        [TestCase(1, 15)]
        public void Swap_OnOutOfRangejParam_ThrowsArgumentNullException(int i, int j)
        {
            //Act, Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => _array.Swap(i, j));
            Assert.That(ex.ParamName, Is.EqualTo(nameof(j)));
        }
    }
}
