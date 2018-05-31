using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMsTestV2Tests
{
    [TestClass]
    public class DataDrivenTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethod1(int a)
        {
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethod2(int a)
        {
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethod3(int a)
        {
        }
    }
}
