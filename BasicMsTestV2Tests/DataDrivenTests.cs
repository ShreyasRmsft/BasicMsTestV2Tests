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
        public void TestMethod1()
        {
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethod2()
        {
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethod3()
        {
        }
    }
}
