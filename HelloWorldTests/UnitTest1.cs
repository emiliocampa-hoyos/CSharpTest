using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test5plus4Equals9() {
            HelloWorld.Sample hw = new HelloWorld.Sample();
            Assert.AreEqual(9, hw.AddXandY(5, 4));
        }

        [TestMethod]
        public void Test3DividedBy3Equals1() {
            HelloWorld.Sample hw = new HelloWorld.Sample();
            Assert.AreEqual(1, hw.DivideXbyY(3, 3));
        }
    }
}
