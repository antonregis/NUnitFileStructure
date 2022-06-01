using Framework.Global;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace Framework.Tests
{
    [TestFixture]
    class TestCondition_001 : Base
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            // Initialize ExtentReports
            var htmlReporter = new ExtentHtmlReporter(ReportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_001_01()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_001_02()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [Test]
        public void TC_001_03()
        {
            // Code may look like this below
            
            try
            {
                // Arrange
                
                // Action
                
                // Assert                

                // Log status in Extentreports
                // test.Log(Status.Pass, "Passed, action successfull.");
                test.Log(Status.Info);
            }
            catch (Exception ex)
            {
                // Log status in Extentreports
                // test.Log(Status.Fail, "Failed, action unsuccessfull.");
                // test.Log(Status.Info, ex.Message);
            }
        }

        // [OneTimeTearDown] should be placed on the last TextCondition_005.cs to flush ExtentReports
    }
}