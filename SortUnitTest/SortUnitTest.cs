using MergeSort;
using SortingAlgorithms;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;


namespace SortUnitTest
{
    [Ignore("Rewrite")]
    [Category("Sort")]
    [TestFixture]
    public class SortUnitTest
    {		
        private static readonly int[] _arrayToSort = new[] { 5, 9, 8, 1, 4, 2, 6, 5, 3, 7 };
        private static readonly int[] _arrayToCountSplit = new[] { 1, 3, 5, 2, 4, 6 };
        private static readonly int[] _sortedArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static readonly int[] _sortedArrayIndex = new[] { 3, 5, 8, 4, 0, 7, 6, 9, 2, 1 };
        private static readonly string[] _q2 = new[]
        {
            "sole",
            "worm",
            "wasp",
            "deer",
            "pony",
            "hake",
            "lynx",
            "clam",
            "bull",
            "bass",
            "toad",
            "hare",
            "slug",
            "seal",
            "frog",
            "lamb"
        };

        [Test]
        public void IsSortedTest()
        {
            Assert.IsFalse(_arrayToSort.IsSorted());
            Assert.IsTrue(_sortedArray.IsSorted());
        }

        [Test]
        public void InsertationSortTest()
        {
            //Arrange
            var insertationSort = new InsertationSort<string>();
            var arrayToSort = new string[_q2.Length];
            _q2.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(insertationSort);
            //Assert
            Assert.IsTrue(arrayToSort.IsSorted());
        }

        [Test]
        public void ShellSortTest()
        {
            //Arrange
            var shellSort = new ShellSort<string>();
            var arrayToSort = new string[_q2.Length];
            _q2.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(shellSort);
            //Assert
            Assert.IsTrue(arrayToSort.IsSorted());
        }


        [Test]
        public void MergeSortTest()
        {
            //Arrange
            MergeSort<int> mergeSort = new MergeSort<int>();
            var arrayToSort = new int[_arrayToSort.Length];
            _arrayToSort.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(mergeSort);
            //Assert
            Assert.IsTrue(arrayToSort.IsSorted());
        }

        [Test]
        public void QuickSortTest()
        {
            //Arrange
            var quickSort = new QuickSort<int>();


            var arrayToSort = new []{ 19, 42, 25, 17, 10, 73, 13, 88, 80, 91, 18, 50 };
            //_arrayToSort.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(quickSort);
            //Assert
            Assert.IsTrue(arrayToSort.IsSorted());
        }

        [Test]
        public void ThreeWayQuickSortTest()
        {
            //Arrange
            var threeWayQuickSort = new ThreeWayQuickSort<int>();
            var arrayToSort = new []{ 53, 14, 39, 96, 37, 27, 53, 73, 53, 53};
            arrayToSort.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(threeWayQuickSort);
            //Assert
            Assert.IsTrue(arrayToSort.IsSorted());
        }

        [Test]
        public void BottomUpMergeSortTest()
        {
            //Arrange
            var bottomUpMergeSort = new BottomUpMergeSort<int>();
            var arrayToSort = new int[_arrayToSort.Length];
            _arrayToSort.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(bottomUpMergeSort);
            //Asssert
            Assert.IsTrue(arrayToSort.IsSorted());
        }

        [Test]
        public void NaturalMergeSortTest()
        {
            //Arrange
            var naturalMergeSort = new NaturalMergeSort<int>();
            var arrayToSort = new int[_arrayToSort.Length];
            _arrayToSort.CopyTo(arrayToSort, 0);
            //Act
            arrayToSort.Sort(naturalMergeSort);
            //Asssert
            Assert.IsTrue(arrayToSort.IsSorted());
        }

        [Test]
        public void InversionsCountTest()
        {
            //Arrange
            var arrayToSort = new int[_arrayToCountSplit.Length];
            _arrayToCountSplit.CopyTo(arrayToSort, 0);
            //Act
            var res = arrayToSort.InversionsCount();

            //Assert
            Assert.AreEqual(res.Item2, 3);
            
        }

        [Test]
        public void IndirectSortTest()
        {
            //Arrange
            var arrayToSort = new int[_arrayToSort.Length];
            _arrayToSort.CopyTo(arrayToSort, 0);
            //Act
            var res = arrayToSort.IndirectSort();

            //Assert
            Assert.IsTrue(res.SequenceEqual(_sortedArrayIndex));

        }

        [Test]
        public void TriplicatesTest()
        {
            //Arrange
            var triplicates = new Triplicates();
            var firstList = new List<string>();

            firstList.Add("Ann");
            firstList.Add("Annastacia");
            firstList.Add("Bridget");
            firstList.Add("John");

            var secondList = new List<string>();
            secondList.Add("Ann");
            secondList.Add("Annastacia");


            var thirdList = new List<string>();
            thirdList.Add("Ann");
            

            //Act
            var result = triplicates.GetTriplicates(firstList, secondList, thirdList);

            //Assert
            Assert.AreEqual(result.Count, 1);

        }

    }
}
