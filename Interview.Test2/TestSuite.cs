using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Interview.Test2
{

    class TestSuite
    {

        static void Main(string[] args)
        {                             }

        [SetUp]
        public void TcInitialize()
        {
            PropCollection.driver = new ChromeDriver();
            PropCollection.driver.Manage().Window.Maximize();
            PropCollection.driver.Navigate().GoToUrl("http://127.0.0.1:16864/index.html"); //replace with instance
            Console.WriteLine("Opened Browser");
        }

        [Test]
        public void TcLoginUsingExistingCredentials()
        {
            LoginPageObject loginObject = new LoginPageObject();
            UpdatePageObjects pageObj = loginObject.Login("austinryang1@gmail.com", "aA1asdfghjk");
        }         

        [Test]
        public void TcUpdateUserCredentials()
        {
            LoginPageObject loginObject = new LoginPageObject();
            UpdatePageObjects pageObj = loginObject.Login("forthisdemo@gmail.com", "aA1asdfghjk");
            pageObj.UpdateDetails("AR", "Autsin", "Govender", "autsin@gmail.com", "aA1fhashfj");
        }

        [Test]
        public void TcValidateEmailEntryAgainstDatasource()
        {
            GetMethods.GetText("emailT", PropertyType.Id);
        }

        [Test]
        public void TcValidatePasswordAgainstDatasource()
        {

        }

        [Test]
        public void TcValidateButtonProperties()
        {

        }

        [TearDown]
        public void TcCleanup()
        {
            PropCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}