using System;
using NUnit.Framework;
using Utils;

namespace UtilsTest
{
    [TestFixture]
    public class UtilsTest
    {
        [Test]
        public void RankTest()
        {
            //11 12 17 19 23 29 31 34 40 50 70 76 81 87 89 
            var array = new[] { 11, 12, 17, 19, 23, 29, 31, 34, 40, 50, 70, 76, 81, 87, 89 };


            Assert.AreEqual(0, array.Rank(11));
            Assert.AreEqual(14, array.Rank(89));
            Assert.AreEqual(5, array.Rank(29));
            Assert.AreEqual(null, array.Rank(59));
        }
    }
}
