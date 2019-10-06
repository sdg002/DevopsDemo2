using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1Fwk
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var o = new SomeClassLib1.Class1();
            o.DoSomething();
        }
    }
}
