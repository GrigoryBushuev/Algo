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
    }
}
