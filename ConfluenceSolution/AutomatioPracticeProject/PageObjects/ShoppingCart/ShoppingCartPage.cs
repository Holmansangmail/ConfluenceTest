using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects
{
    public class ShoppingCartPage
    {

        private readonly IWebDriver driver;
        public ShoppingCartPage(IWebDriver webDriver) => driver = webDriver;

    }
}
