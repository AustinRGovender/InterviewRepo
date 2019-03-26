using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Interview.Test2
{
    class UpdatePageObjects
    {
        public UpdatePageObjects()
        {
            PageFactory.InitElements(PropCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "initials")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement txtName { get; set; }

        [FindsBy(How = How.Id, Using = "surname")]
        public IWebElement txtSurname { get; set; }

        [FindsBy(How = How.Id, Using = "emailT")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Name, Using = "psw")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#pageContent > div.container > form > input[type="+"submit"+"]:nth-child(11)")]
        public IWebElement btnSubmit { get; set; }

        public void UpdateDetails(string initial, string name, string surname, string email, string password)
        {
            txtInitial.SendKeys(initial);
            Console.WriteLine("Intitials are: " + GetMethods.GetText("initials", PropertyType.Id));
            txtName.SendKeys(name);
            txtSurname.SendKeys(surname);
            txtEmail.SendKeys(email);
            txtPassword.SendKeys(password);
           
            btnSubmit.Click();
        }
    }
}
