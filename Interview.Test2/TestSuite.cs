using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Interview.Test2
{
    [TestFixture]
    public class TestSuite : BaseTest
    {static void Main(string[] args){}

        [Test, Order(1)]
        [Author("Austin Ryan Govender", "austinryang1@gmai.com")]
        [Description("This test is to simulate Logging in to the application via via credentials parsed in Excel Data Source")]
        public void tc1VerifyLoginProcedurePositiveTest()
        {           
            try {
                test = extent.CreateTest("tc1VerifyLoginProcedurePositeTest").Info("tc1VerifyLoginProcedurePositeTest Started");
                LoginPageObject loginObject = new LoginPageObject();
                UpdatePageObjects pageObj = loginObject.Login(DataLib.ReadData(1, "Email"), DataLib.ReadData(1, "Password"));
                test.Log(Status.Info, "Successfully Logged In with DS Data");
                test.Log(Status.Pass, "tc1VerifyLoginProcedurePositeTest Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
        }         

        [Test, Order(2)]
        public void tc2UpdateUserCredentialsUponLoginDDTPositiveTest()
        {
           
            DataLib2.PopulateInCollection2(@"C:\Users\User\Desktop\New folder\Interview\Interview.Test2\DataSources\Data2.xlsx");
            test = extent.CreateTest("tc2UpdateUserCredentialsUponLoginDDTPositiveTest").Info("tc2UpdateUserCredentialsUponLoginDDTPositiveTest Started");
            try
            { //Testing cycle --dont forget to point to ExcelDataTableCount
                for (int i = 1; i < 6; i++)
                {
                    LoginPageObject loginObject = new LoginPageObject();

                    UpdatePageObjects pageObj = loginObject.Login(DataLib2.ReadData2(i, "Email"), DataLib2.ReadData2(i, "Password"));
                    test.Log(Status.Info, "Successfully Logged In with DS Data. Email: " + DataLib2.ReadData2(i, "Email") + "With Password: " + DataLib2.ReadData2(i, "Password"));
                    test.Log(Status.Pass, "Login Passed for Line: " + i );
                    pageObj.UpdateDetails(DataLib2.ReadData2(i, "Initial"), DataLib2.ReadData2(i, "Name"), DataLib2.ReadData2(i, "Surname"),
                        DataLib2.ReadData2(i, "UpdateEmail"), DataLib2.ReadData2(i, "UpdatePassword"));
                    test.Log(Status.Pass, "Update Passed for: " + DataLib2.ReadData2(i, "Initial"));
                }
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
        }

        [Test, Order(3)]
        public void tc3ValidateButtonProperty()
        {
            
        }

        [Test, Order(4)]
        public void tc4ValidateHyperLinkNavigation()
        {
            test = extent.CreateTest("tc1VerifyLoginProcedurePositeTest").Info("tc1VerifyLoginProcedurePositeTest Started");
            try
            {   test = extent.CreateTest("tc1VerifyLoginProcedurePositeTest").Info("tc1VerifyLoginProcedurePositeTest Started");
                LoginPageObject loginObject = new LoginPageObject();
                loginObject.VerifyHyperLinkGithub();
                test.Log(Status.Info, "Successfully Logged In with DS Data");
                test.Log(Status.Pass, "tc1VerifyLoginProcedurePositeTest Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }
        }


    }
}