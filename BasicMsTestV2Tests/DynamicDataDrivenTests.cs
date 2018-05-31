using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMsTestV2Tests
{
    [TestClass]
    public class DynamicDataDrivenTests
    {
        private static IEnumerable<object[]> ReusableTestData =>
            new List<object[]> {
            new object[] { 1,},
            new object[] { 2 },
            new object[] { 3 }
        };

        [TestMethod]
        [DynamicData(nameof(ReusableTestData))]
        public void TestMethod1(int a)
        {

        }
    }
}
