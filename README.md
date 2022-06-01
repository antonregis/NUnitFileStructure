## Proposed NUnit File Structure

Under "Tests" folder will contain individual Test Condition file. 

For example:
- TestCondition_001.cs
- TestCondition_002.cs
- TestCondition_003.cs 
- TestCondition_004.cs
- TestCondition_005.cs and so on

A more concrete example for the project:
- TC_001_Registration.cs
- TC_002_SignIn.cs
- TC_003_Profile_Location.cs
- TC_004_Profile_Availability.cs

Important Note:
- [OneTimeSetUp] should be placed on the first TestCondition_001.cs to initialize ExtentReports
- [OneTimeTearDown] should be placed on the last TestCondition_005.cs to flush ExtentReports
- [Setup] & [TearDown] should be placed in Base.cs

Download this project and do a test run and have a look at "\TestReports\ExtentReports\index.html" and observe the report sequence on what Test Conditions and Test Cases are run. Have a play on renaming TestCondition_00x.cs files (or class name) and Test Case method names and see how it affects the test run sequence. 

The purpose of this proposal is to break Test Conditions or Test Cases to different files instead of putting all of them together in one file. 
