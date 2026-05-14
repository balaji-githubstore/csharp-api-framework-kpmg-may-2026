using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace AutomationFramework.Helpers
{
    public class ZDemo3ExtentReport
    {
        [Test]
        public void ExtentTest()
        {
            //run only once in the beginning for the application 
            ExtentSparkReporter reporter = new ExtentSparkReporter("spark.html");
            ExtentReports extent = new ExtentReports();
            extent.AttachReporter(reporter);

            //before the [Test] run
            ExtentTest test= extent.CreateTest("AddPetTest");


            test.Log(Status.Info, "Request server to add pet");


            //After the [Test] run even-always
            test.Log(Status.Pass, "AddPetTestPassed");


            //flush to generate report // at the last after all [Test] run
            extent.Flush();

        }
    }
}
