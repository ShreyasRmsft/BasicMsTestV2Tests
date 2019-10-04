using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMsTestV2Tests
{
    [TestClass]
    public class FailingTests
    {
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        [Owner("shrer")]
        public void TestMethod1()
        {
            Assert.Fail(TestContext.Properties["password"].ToString());
        }

        [TestMethod]
        [Owner("shrer")]
        public void TestMethod2()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual('a', Environment.GetEnvironmentVariable("VSTEST.TESTRUNID"));
        }
    }
}
