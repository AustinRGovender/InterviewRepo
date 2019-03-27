﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interview.Test2
{
    [TestFixture]
    public class BaseTest
    {
        public ExtentReports extent = null;
        public ExtentTest test = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\User\Desktop\New folder\Interview\Interview.Test2\Reports\TestReport.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [SetUp]
        public void InitializeEnvironmentAndDatasources()
        {
            test = extent.CreateTest("InitializeEnvironmentAndDatasources").Info("Test Started");
            try
            {
                
                DataLib.PopulateInCollection(@"C:\Users\User\Desktop\New folder\Interview\Interview.Test2\DataSources\Data.xlsx");
                PropCollection.driver = new ChromeDriver();
                PropCollection.driver.Manage().Window.Maximize();
                test.Log(Status.Info,"Chrome Browser Launched Successfully");
                PropCollection.driver.Navigate().GoToUrl("https://austinrgovender.github.io/TestSampleWeb/"); //replace with instance   
                test.Log(Status.Info, "Navigated to Test Website Successfully");
                test.Log(Status.Pass, "Intitialization of Environment and Datasources Passed");

            }
            catch (Exception e)
            {
                throw;
            }
        }

        [TearDown]
        public void TcCleanup()
        {
            test = extent.CreateTest("TcCleanup").Info("Test Started");
            PropCollection.driver.Close();
            test.Log(Status.Pass, "Tear Down Successfull");
        }
    }
}
