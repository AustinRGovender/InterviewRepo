using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Test2
{
    class GetMethods
    {
        public static string GetText(string element, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                return PropCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == PropertyType.Name)
                return PropCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }   
    }
}
