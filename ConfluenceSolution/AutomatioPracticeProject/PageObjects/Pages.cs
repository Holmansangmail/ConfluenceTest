using AutomatioPracticeProject.PageObjects.Women;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects
{

    class Pages
    {
        public static HomePage Home;
        public static ShoppingCartPage ShoppingCart;
        public static WomenPage Women;
        public static AdditionalDetailsPage AdditionalDetails;

        public static void Init(IWebDriver driver)
        {
            Home = new HomePage(driver);
            ShoppingCart = new ShoppingCartPage(driver);
            Women = new WomenPage(driver);
            AdditionalDetails = new AdditionalDetailsPage(driver);
        }

    }
}
