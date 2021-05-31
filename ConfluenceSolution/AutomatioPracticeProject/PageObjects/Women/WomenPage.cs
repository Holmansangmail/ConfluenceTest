using AutomatioPracticeProject.PageObjects.Base;
using AutomatioPracticeProject.PageObjects.Women.Map;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects
{
    public class WomenPage : BasePage
    {
        public readonly WomenPageMap Map;

        public WomenPage(IWebDriver driver) : base(driver)
        {
            Map = new WomenPageMap(driver);
        }

        public void OpenAdditionalDetails(int itemNumber)
        {
            Helper.MoveToElement(Map.ProductBox(itemNumber));
            Map.AdditionalDetails(itemNumber).Click();
            Helper.WaitForPageToLoad(Map.AdditionalDetailsResults);
        }

    }
}
