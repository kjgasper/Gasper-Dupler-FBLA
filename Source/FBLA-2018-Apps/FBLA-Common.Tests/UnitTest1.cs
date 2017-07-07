using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FBLA_Common.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Hello world!", class1.helloWorld());
        }
    }
}
