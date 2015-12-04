using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CSharpTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CSharpTest()
        {
            var expected = new[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            var actual = Enumerable.Range(2, 20).Where(PrimesLib.isPrime).ToArray();
            Assert.AreEqual(string.Join(",", expected), string.Join(",", actual)); // in F# you can compare directly
        }
    }
}
