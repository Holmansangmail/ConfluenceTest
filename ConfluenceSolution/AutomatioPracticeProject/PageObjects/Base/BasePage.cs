using AutomatioPracticeProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects.Base
{
    public class BasePage
    {
        protected Helpers Helper { get; }

        protected BasePage(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }

    }
}
