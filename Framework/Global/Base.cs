using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Framework.Global
{
    class Base
    {
        public static string ReportPath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"..\..\..\..\TestReports\ExtentReports\");
        public static ExtentReports extent;
        public static ExtentTest test;

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

        [SetUp]
        public void Setup()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [TearDown]
        public void TearDown()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);

            // Save Extentereport html file
            extent.Flush();
        }
    }
}
