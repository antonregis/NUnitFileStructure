using NUnit.Framework;
using AventStack.ExtentReports;


namespace Framework.Global
{
    class Base
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
    }
}
