﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Test2
{
    public static class GetMethods
    {
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static string getTextFromDdl(this IWebElement element)
        {
            //Not in use
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
