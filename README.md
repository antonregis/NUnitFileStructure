## Proposed NUnit File Structure

The purpose of this proposal is to break Test Conditions in to different files instead of putting all of them together in one file. 

Under "Tests" folder will contain individual Test Condition file. 

For example:
- TestCondition_001.cs
- TestCondition_002.cs
- TestCondition_003.cs and so on

A more concrete example for a project:
- TC_001_Registration.cs
- TC_002_SignIn.cs
- TC_003_Profile_Location.cs
- TC_004_Profile_Availability.cs

The following NUnit attributes are placed in Base.cs:
- [Setup]
- [TearDown]
- [OneTimeSetUp]
- [OneTimeTearDown]
- [SetUpFixture]

The trick to ExtentReports initialization and flushing is [SetUpFixture] which is explained here:
https://dzone.com/articles/most-complete-nunit-unit-testing-framework-cheat-s-1 (thanks to Aman B. for this link).

Download this project and do a test run and have a look at "\TestReports\ExtentReports\index.html" and observe the report sequence on what Test Conditions and Test Cases are run. 