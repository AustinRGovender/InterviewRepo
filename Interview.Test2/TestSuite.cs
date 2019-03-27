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
    [TestFixture]
    class TestSuite
    {

        static void Main(string[] args)
        {                             }

        [SetUp]
        public void InitializeEnvironmentAndDatasources()
        {
            DataLib.PopulateInCollection(@"C:\Users\User\Desktop\New folder\Interview\Interview.Test2\DataSources\Data.xlsx");
            PropCollection.driver = new ChromeDriver();
            PropCollection.driver.Manage().Window.Maximize();
            PropCollection.driver.Navigate().GoToUrl("http://127.0.0.1:16864/index.html"); //replace with instance
            Console.WriteLine("Opened Browser");
        }



        [Test, Order(1)]
        public void tc1VerifyLoginProcedurePositeTest()
        {
            LoginPageObject loginObject = new LoginPageObject();
            UpdatePageObjects pageObj = loginObject.Login(DataLib.ReadData(1, "Email"), DataLib.ReadData(1, "Password"));
        }         

        [Test, Order(2)]
        public void tc2UpdateUserCredentialsUponLoginDDTPositiveTest()
        {
            //Testing cycle --dont forget to point to ExcelDataTableCount
            for(int i =1; i <6 ; i++) { 
            LoginPageObject loginObject = new LoginPageObject();

            UpdatePageObjects pageObj = loginObject.Login(DataLib.ReadData(i,"Email"), DataLib.ReadData(i, "Password"));

            pageObj.UpdateDetails(DataLib.ReadData(i,"Initial"), DataLib.ReadData(i, "Name"), DataLib.ReadData(i, "Surname"), 
                DataLib.ReadData(1, "UpdateEmail"), DataLib.ReadData(1, "UpdatePassword"));
            }
        }

        [Test, Order(3)]
        public void tc3ValidateButtonProperty()
        {
            
        }

        [Test, Order(4)]
        public void tc4ValidateHyperLinkNavigation()
        {
            LoginPageObject loginObject = new LoginPageObject();
            loginObject.VerifyHyperLinkGithub();
        }

        [TearDown]
        public void TcCleanup()
        {
            PropCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}