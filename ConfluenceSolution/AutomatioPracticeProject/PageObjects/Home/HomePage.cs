using AutomatioPracticeProject.PageObjects.Base;
using AutomatioPracticeProject.PageObjects.Home.Map;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects
{
    public class HomePage : BasePage
    {
        public readonly HomePageMap Map;
        public HomePage(IWebDriver driver) : base(driver)
        {
            Map = new HomePageMap(driver);
        }

        public void OpenWomenPage()
        {
            Map.WomenTab.Click();
            Helper.WaitForPageToLoad(Map.WomenResults);
        }
        public void GoTo()
        {
            Helper.GoToUrl("http://automationpractice.com/");
        }

    }
}
