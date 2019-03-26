using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Interview.Test2
{
     class SetMethods
    {

        //Enter Text
        public static void EnterText(string elem, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropCollection.driver.FindElement(By.Id(elem)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropCollection.driver.FindElement(By.Name(elem)).SendKeys(value);
        }

        //Click Button Operation
        public static void Click(string elem, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropCollection.driver.FindElement(By.Id(elem)).Click();
            if (elementType == PropertyType.Name)
                PropCollection.driver.FindElement(By.Name(elem)).Click();
            if (elementType == PropertyType.CssSelector)
                PropCollection.driver.FindElement(By.CssSelector(elem)).Click();
        }

        //Selecting a dropdown control
        public static void SelectDropdown(string elem, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(PropCollection.driver.FindElement(By.Id(elem))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropCollection.driver.FindElement(By.Name(elem))).SelectByText(value);
        }
    }
}

