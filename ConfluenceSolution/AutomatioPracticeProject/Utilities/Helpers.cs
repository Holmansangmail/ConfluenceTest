using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;


namespace AutomatioPracticeProject.Utilities
{
    public class Helpers
    {
        private IWebDriver Driver { get; }
        public Helpers(IWebDriver driver)
        {
            Driver = driver;
        }

        public void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void WaitForPageToLoad(By name, int duration = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(duration));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(name));
        }

        public void MoveToElement(IWebElement element)
        {
            Actions actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(element).Build().Perform();
        }

        public void SelectComboBoxValue(IWebElement list, string value)
        {
            SelectElement select = new SelectElement(list);
            select.SelectByText(value);
        }

        public IWebElement LocateElement(Locators type, string name)
        {
            return type switch
            {
                Locators.Xpath => Driver.FindElement(By.XPath(name)),
                Locators.CssSelector => Driver.FindElement(By.CssSelector(name)),
                Locators.ID => Driver.FindElement(By.Id(name)),
                Locators.Name => Driver.FindElement(By.Name(name)),
                Locators.LinkText => Driver.FindElement(By.LinkText(name)),
                Locators.ClassName => Driver.FindElement(By.ClassName(name)),
                Locators.PartialLinkText => Driver.FindElement(By.PartialLinkText(name)),
                Locators.TagName => Driver.FindElement(By.TagName(name)),
                _ => throw new ArgumentOutOfRangeException(type.ToString(), $"Invalid Type, {type.ToString()}")
            };
        }

    }
}
