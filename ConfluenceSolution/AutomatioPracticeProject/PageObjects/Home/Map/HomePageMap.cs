using AutomatioPracticeProject.PageObjects.Base;
using AutomatioPracticeProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.PageObjects.Home.Map
{
    public class HomePageMap : BasePage
    {
        public HomePageMap(IWebDriver driver) : base(driver)
        {
        }


        public By WomenResults => By.Id("center_column");

        public IWebElement WomenTab => Helper.LocateElement(Locators.Xpath, "//*[@id='block_top_menu']/ul/li[1]/a");
        //public IWebElement AcceptedUsernames => Helper.LocateElement(Locators.ID, "login_credentials");
        //public IWebElement AcceptedPasswords => Helper.LocateElement(Locators.ClassName, "login_password");
        //public IWebElement PasswordField => Helper.LocateElement(Locators.ID, "password");
        //public IWebElement LoginButton => Helper.LocateElement(Locators.ClassName, "btn_action");


    }
}
