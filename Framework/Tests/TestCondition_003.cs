using Framework.Global;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Framework.Tests
{
    [TestFixture]
    class TestCondition_003 : Base
    {
        [Test]
        public void TC_003_01()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_003_02()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_003_03()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }
    }
}