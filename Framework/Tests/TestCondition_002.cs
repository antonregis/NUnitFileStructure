using Framework.Global;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Framework.Tests
{
    [TestFixture]
    class TestCondition_002 : Base
    {
        [Test]
        public void TC_002_01()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_002_02()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_002_03()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }
    }
}