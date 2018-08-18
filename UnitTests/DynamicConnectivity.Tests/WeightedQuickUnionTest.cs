using DynamicConnectivity;
using NUnit.Framework;

namespace UnionFindTest
{
    [Category("WeightedQuickUnion")]
    [SetUICulture("en-us")]
    [TestFixture]
    public class WeightedQuickUnionTest
    {
        private WeightedQuickUnion _connectedAfterUnionWeightedQuickUnionSut;
        private WeightedQuickUnion _connectedWeightedQuickUnionSut;

        [SetUp]
        public void SetUp()
        {
            _connectedAfterUnionWeightedQuickUnionSut = new WeightedQuickUnion(10);
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _connectedWeightedQuickUnionSut = new WeightedQuickUnion(10);
            //7-9  0 1 2 3 4 5 6 7 8 7  1 1 1 1 1 1 1 2 1 1
            _connectedWeightedQuickUnionSut.Union(7, 9);
            //6-9  0 1 2 3 4 5 7 7 8 7  1 1 1 1 1 1 1 3 1 1
            _connectedWeightedQuickUnionSut.Union(6, 9);
            //2-0  2 1 2 3 4 5 7 7 8 7  1 1 2 1 1 1 1 3 1 1
            _connectedWeightedQuickUnionSut.Union(2, 0);
            //5-8  2 1 2 3 4 5 7 7 5 7  1 1 2 1 1 2 1 3 1 1
            _connectedWeightedQuickUnionSut.Union(5, 8);
            //7-4  2 1 2 3 7 5 7 4 5 7  1 1 2 1 1 2 1 4 1 1 
            _connectedWeightedQuickUnionSut.Union(7, 4);
            //6-1  2 7 2 3 7 5 7 4 5 7  1 1 2 1 1 2 1 5 1 1    
            _connectedWeightedQuickUnionSut.Union(6, 1);
            //0-5  2 7 2 3 7 2 7 7 5 7  1 1 4 1 1 2 1 5 1 1
            _connectedWeightedQuickUnionSut.Union(0, 5);
            //4-3  2 7 2 7 7 2 7 7 5 7  1 1 4 1 1 2 1 6 1 1
            _connectedWeightedQuickUnionSut.Union(4, 3);
            //2-4  2 7 7 7 7 2 7 7 5 7  1 1 4 1 1 2 1 10 1 1            
            _connectedWeightedQuickUnionSut.Union(2, 4);
            //2-4  2 7 7 7 7 2 7 7 5 7  1 1 4 1 1 2 1 10 1 1
            _connectedWeightedQuickUnionSut.Union(2, 2);
            //2-7  2 7 7 7 7 2 7 7 5 7  1 1 4 1 1 2 1 10 1 1
            _connectedWeightedQuickUnionSut.Union(2, 7);
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
        [TestCase(2, 2, true)]
        [TestCase(2, 7, true)]
        public void IsConnected_AfterUnion_ReturnsExpectedResult(int p, int q, bool expectedResult)
        {
            //7-9 6-9 2-0 5-8 7-4 6-1 0-5 4-3 2-4
            //    0 1 2 3 4 5 6 7 8 9
            //7-9 0 1 2 3 4 5 6 7 8 7  1 1 1 1 1 1 1 2 1 1
            //6-9 0 1 2 3 4 5 6 7 8 7  1 1 1 1 1 1 1 2 1 1
            //Arrange
            _connectedAfterUnionWeightedQuickUnionSut.Union(p, q);
            //Act
            var actualResult = _connectedAfterUnionWeightedQuickUnionSut.IsConnected(p, q);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
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
        [TestCase(2, 2, true)]
        [TestCase(2, 7, true)]
        public void IsConnected_ReturnsExpectedResult(int p, int q, bool expectedResult)
        {
            //Act
            var actualResult = _connectedWeightedQuickUnionSut.IsConnected(p, q);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
