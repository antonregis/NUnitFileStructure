using Framework.Global;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace Framework.Tests
{
    [TestFixture]
    class TestCondition_005 : Base
    {
        [Test]
        public void TC_005_01()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_005_02()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_005_03()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }
    }
}