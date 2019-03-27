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
            DataLib.PopulateInCollection(@"C:\Users\User\Desktop\New folder\Interview\Interview.Test2\DataSources\Data.xlsx");

            LoginPageObject loginObject = new LoginPageObject();

            UpdatePageObjects pageObj = loginObject.Login(DataLib.ReadData(1, "Email"), DataLib.ReadData(1, "Password"));
        }         

        [Test]
        public void TcUpdateUserCredentials()
        {
            DataLib.PopulateInCollection(@"C:\Users\User\Desktop\Data.xlsx");

            LoginPageObject loginObject = new LoginPageObject();

            UpdatePageObjects pageObj = loginObject.Login(DataLib.ReadData(1,"Email"), DataLib.ReadData(1, "Password"));

            pageObj.UpdateDetails(DataLib.ReadData(1,"Initial"), DataLib.ReadData(1, "Name"), DataLib.ReadData(1, "Surname"), 
                DataLib.ReadData(1, "UpdateEmail"), DataLib.ReadData(1, "UpdatePassword"));
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