using AutomatioPracticeProject.PageObjects.Base;
using AutomatioPracticeProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects.Women.Map
{
    public class AdditionalDetailsPageMap : BasePage
    {

        public AdditionalDetailsPageMap(IWebDriver driver) : base(driver)
        {
        }

        private readonly string AddToCartXP = "//*[@id='add_to_cart']/button/span";

        public By AddToCartBy => By.XPath(AddToCartXP);
        public By ProductAddedSuccessfully => By.XPath("//*[@id='layer_cart']/div[1]/div[1]/h2");

        public IWebElement Sizes => Helper.LocateElement(Locators.ID, "group_1");

        public IWebElement WhiteStyle => Helper.LocateElement(Locators.ID, "color_8");
        public IWebElement BlackStyle => Helper.LocateElement(Locators.ID, "color_11");
        public IWebElement OrangeStyle => Helper.LocateElement(Locators.ID, "color_13");
        public IWebElement BlueStyle => Helper.LocateElement(Locators.ID, "color_14");
        public IWebElement AddToCart => Helper.LocateElement(Locators.Xpath, AddToCartXP);
        public IWebElement ContinueShopping => Helper.LocateElement(Locators.Xpath, "//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span");
        public IWebElement ItemsInCart => Helper.LocateElement(Locators.Xpath, "//*[@id='header']/div[3]/div/div/div[3]/div/a/span[1]");


        

    }
}
