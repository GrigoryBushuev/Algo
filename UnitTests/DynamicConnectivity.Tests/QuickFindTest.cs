using DynamicConnectivity;
using NUnit.Framework;

namespace UnionFindTest
{
    [Category("QuickFind")]
    [SetUICulture("en-us")]
    [TestFixture]
    public class QuickFindTest
    {
        private QuickFind _quickFind;

        [SetUp]
        public void SetUp()
        {
            _quickFind = new QuickFind(10);
        }

        [TestCase(7, 9, true)]
        [TestCase(6, 9, true)]
        [TestCase(2, 0, true)]
        [TestCase(5, 8, true)]
        [TestCase(7, 4, true)]
        [TestCase(6, 1, true)]
        [TestCase(0, 5, true)]
        [TestCase(4, 3, true)]
        [TestCase(2, 4, true)]
        public void IsConnected_ReturnsExpectedResult(int p, int q, bool expectedResult)
        {
            //7-9 6-9 2-0 5-8 7-4 6-1 0-5 4-3 2-4 
            //Arrange
            _quickFind.Union(p, q);
            //Act
            var actualResult = _quickFind.IsConnected(p, q);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}