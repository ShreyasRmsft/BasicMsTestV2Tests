﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicMsTestV2Tests
{
    [TestClass]
    public class PassingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Threading.Thread.Sleep(99999999);
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
