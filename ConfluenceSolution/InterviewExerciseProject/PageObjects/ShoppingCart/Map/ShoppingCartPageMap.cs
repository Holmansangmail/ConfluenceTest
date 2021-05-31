using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewExerciseProject.PageObjects.ShoppingCart.Map
{

    // It contains locators for this page

    public class ShoppingCartPageMap : BasePage
    {
        public ShoppingCartPageMap(IWebDriver driver) : base(driver)
        {
        }

        // Locators for sync

        public By EmptyCart => By.XPath("//*[@id='center_column']/p");

        // Locators for interaction

        public IWebElement ProductNumber => Helper.LocateElement(Locators.ID, "summary_products_quantity");
        public IWebElement EmptyCartMessage => Helper.LocateElement(Locators.Xpath, "//*[@id='center_column']/p");
        public IWebElement DeleteProduct(int productNumber) => Helper.LocateElement(Locators.Xpath, $@"//*[@id='cart_summary']/tbody/tr[{productNumber}]/td[7]");

    }
}
