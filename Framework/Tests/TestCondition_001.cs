using Framework.Global;
using NUnit.Framework;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace Framework.Tests
{
    [TestFixture]
    class TestCondition_001 : Base
    {
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

            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);

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
    }
}