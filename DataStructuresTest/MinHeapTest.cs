using DataStructures;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresTest
{
    [TestFixture]
    [SetUICulture("en-US")]
    public class MinHeapTest
    {        
        [TestCase(new int[] { 4, 3, 0, 1, 2, 0})]
        public void Add_OnValidParams_AddsParams(int[] testParams)
        {
            //Arrange
            var minHeap = new MinHeap<int>((uint)testParams.Count());
            //Act
            testParams.All(p =>
                {
                    minHeap.Add(p);
                    return true;
                });
            //Assert
            Assert.AreEqual(minHeap.Size, testParams.Count());
        }

        [TestCase(new int[] { 4, 3, -1, 1, 2, 0 }, new int[] { -1, 0, 1, 2, 3, 4 })]
        public void DeleteMin_OnValidParams_ReturnsMinValue(int[] testParams, int[] expectedResults)
        {
            //Arrange
            var minHeap = new MinHeap<int>((uint)testParams.Count());
            testParams.All(p =>
            {
                minHeap.Add(p);
                return true;
            });
            //Act            
            //Assert
            foreach (var expectedResult in expectedResults)
            {
                var actualResult = minHeap.DeleteMin();                
                Assert.AreEqual(expectedResult, actualResult);
            }
        }


    }
}
