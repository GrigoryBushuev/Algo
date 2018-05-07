using System;
using System.Collections.Generic;
using NUnit.Framework;
using Utils;

namespace UtilsTest
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
    }
}
