using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Test2
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "emailT")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Name, Using = "psw")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#pageContent > div.container > form > input[type=" + "submit" + "]:nth-child(5)")]
        public IWebElement btnSubmit { get; set; }

        public UpdatePageObjects Login(string email, string password)
        {
            txtEmail.EnterText(email);
            Console.WriteLine("Email is: " + txtEmail.GetText());
            txtPassword.EnterText(password);
            Console.WriteLine("Passwprd is: " + txtPassword.GetText());
            btnSubmit.Clicks();

            return new UpdatePageObjects();
        }
    }
}
