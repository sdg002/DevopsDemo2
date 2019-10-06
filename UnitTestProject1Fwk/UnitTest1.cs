using System;
using System.Diagnostics;
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
        [TestMethod]
        [DeploymentItem("Junk.txt")]
        public void MyTestMethodWithDeployment()
        {
            var assem = System.Reflection.Assembly.GetExecutingAssembly();
            string locn = assem.Location;
            Trace.WriteLine($"1 Inside method {nameof(MyTestMethodWithDeployment)} Location of assembly={locn}");
            Trace.WriteLine($"Deployment direc={TestContext.DeploymentDirectory}");
        }
        public TestContext TestContext { get; set; }
    }
}
