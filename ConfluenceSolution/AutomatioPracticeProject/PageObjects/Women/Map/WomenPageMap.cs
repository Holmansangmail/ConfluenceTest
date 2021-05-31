using AutomatioPracticeProject.PageObjects.Base;
using AutomatioPracticeProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects.Women.Map
{
    public class WomenPageMap : BasePage
    {
        public WomenPageMap(IWebDriver driver) : base(driver)
        {
        }

        public By AdditionalDetailsResults => By.XPath("//*[@id='center_column']/div/div/div[3]");

        public IWebElement AdditionalDetails(int itemNumber) => Helper.LocateElement(Locators.Xpath, @$"//*[@id='center_column']/ul/li[{itemNumber}]/div/div[2]/div[2]/a[2]/span");

        public IWebElement ProductBox(int itemNumber) => Helper.LocateElement(Locators.Xpath, @$"//*[@id='center_column']/ul/li[{itemNumber}]");

    }
}
