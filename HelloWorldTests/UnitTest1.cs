using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HelloWorld.Sample hw = new HelloWorld.Sample();

            Assert.AreEqual(9, hw.AddXandY(5, 4));

        }
    }
}
