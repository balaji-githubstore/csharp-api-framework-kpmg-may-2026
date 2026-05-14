using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using DocumentFormat.OpenXml.Bibliography;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.Base
{
    public class BaseTest
    {
        private static ExtentReports Extent { get; set; }
        protected ExtentTest Test { get; set; }

        private string ProjectPath { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            if (Extent == null)
            {
                ProjectPath = TestContext.CurrentContext.TestDirectory;
                ProjectPath = ProjectPath.Remove(ProjectPath.IndexOf("bin"));

                var reporter = new ExtentSparkReporter(ProjectPath + @"\Reports\spark.html");
                Extent = new ExtentReports();
                Extent.AttachReporter(reporter);
            }
        }

        [OneTimeTearDown]
        public void Final()
        {
            Extent.Flush();
        }

        [SetUp]
        public void BeforeMethod()
        {
            Test = Extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterMethod()
        {
            string testName = TestContext.CurrentContext.Test.Name;

            TestStatus status = TestContext.CurrentContext.Result.Outcome.Status;

            if (status == TestStatus.Failed)
            {
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;

                Test.Log(Status.Fail, stackTrace + errorMessage);
            }
            else if (status == TestStatus.Passed)
            {
                Test.Log(Status.Pass, "Passed - Snapshot below:");
            }
            else if (status == TestStatus.Skipped)
            {
                Test.Log(Status.Skip, "Skipped - " + testName);
            }
        }
    }
}
