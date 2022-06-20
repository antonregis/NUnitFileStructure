using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Framework.Global;

namespace Framework.Global
{
    public class Base
    {
        public static string ReportPath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"..\..\..\..\TestReports\ExtentReports\");
        public static ExtentReports extent;
        public static ExtentTest test;


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

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            test = extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
            test.Log(Status.Info);
        }
    }
}

[SetUpFixture]
public class SetUpExtentReports
{
    [OneTimeSetUp]
    public void InitializeExtentReports()
    {
        // Initialize ExtentReports
        var htmlReporter = new ExtentHtmlReporter(Base.ReportPath);
        Base.extent = new ExtentReports();
        Base.extent.AttachReporter(htmlReporter);

        Base.test = Base.extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
        Base.test.Log(Status.Info);
    }
    [OneTimeTearDown]
    public void FlushExtentReports()
    {
        Base.test = Base.extent.CreateTest(System.Reflection.MethodBase.GetCurrentMethod().Name);
        Base.test.Log(Status.Info);

        // Save Extentereport html file
        Base.extent.Flush();
    }
}