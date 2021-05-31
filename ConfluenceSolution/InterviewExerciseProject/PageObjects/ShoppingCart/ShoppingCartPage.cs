using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.PageObjects.ShoppingCart.Map;
using OpenQA.Selenium;
using System;

namespace InterviewExerciseProject.PageObjects
{
    public class ShoppingCartPage : BasePage
    {
        // It contains all of the methods available for this page

        public readonly ShoppingCartPageMap Map;
        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {
            Map = new ShoppingCartPageMap(driver);
        }

        private int GetTotalNumberOfProducts()
        {
            string products = Map.ProductNumber.Text.Replace(" Products", "");
            int productNumber = int.Parse(products);

            return productNumber;
        }

        public bool RemoveAllProducts()
        {
            int productNumber = GetTotalNumberOfProducts();

            for (int counter = 1; counter <= productNumber; counter++)
            {
                Map.DeleteProduct(counter).Click();
            }

            Helper.WaitForPageToLoad(Map.EmptyCart);

            bool result = false;
            string finalMessage = "Your shopping cart is empty.";

            if(Map.EmptyCartMessage.Text.Equals(finalMessage))
            {
                string value = $@"{productNumber} products were deleted.";
                Console.WriteLine(value);
                result = true;
            }

            return result;
        }

        public bool CorrectShoppingCartSummary()
        {
            bool result = false;
            int productNumber = GetTotalNumberOfProducts();

            if(ProductsInCart == productNumber)
            {
                string value = $@"The shopping cart contains {productNumber} products.";
                Console.WriteLine(value);
                result = true;
            }

            return result;
        }

    }
}
