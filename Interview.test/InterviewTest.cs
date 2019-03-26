using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Interview.Test
{

    [TestFixture]
    public class InterviewTest
    {
        [Test]
        public void Tclogin()
        {
            //Open Browser
            IWebDriver driver = new FirefoxDriver();//Interface object because you can implement it in any way ie. chrome, firefox...
            driver.Navigate().GoToUrl("http://www.trainingrite.net");
            driver.FindElement(By.Id("txtphone")).SendKeys("0726085092");
            driver.FindElement(By.Id("txtpassword")).SendKeys("Password");
            driver.FindElement(By.Id("btnSubmit")).Click();

            driver.Close();

        }

        [Test]
        public void Tctwo()
        {

        }
        
    }
}
