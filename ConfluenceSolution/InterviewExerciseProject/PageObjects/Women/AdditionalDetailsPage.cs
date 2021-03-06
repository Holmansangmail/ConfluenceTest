using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.PageObjects.Women.Map;
using OpenQA.Selenium;
using System;

namespace InterviewExerciseProject.PageObjects.Women
{

    // It contains all of the methods available for this page

    public class AdditionalDetailsPage : BasePage
    {
        
        public readonly AdditionalDetailsPageMap Map;

        public AdditionalDetailsPage(IWebDriver driver) : base(driver)
        {
            Map = new AdditionalDetailsPageMap(driver);
        }

        private void SelectSize(string size)
        {
            Helper.SelectComboBoxValue(Map.Sizes, size);
        }

        private void SelectColor(string color)
        {
            if(color.Equals("Orange"))
            {
                Map.OrangeStyle.Click();
            }
            else if (color.Equals("Black"))
            {
                Map.BlackStyle.Click();
            }
            else if (color.Equals("White"))
            {
                Map.WhiteStyle.Click();
            }
            else
            {
                Map.BlueStyle.Click();
            }
        }

        private void ContinueShopping()
        {
            Map.ContinueShopping.Click();
            Helper.WaitForPageToLoad(Map.AddToCartBy);
        }

        public void AddToCart(string size, string color)
        {
            SelectSize(size);
            SelectColor(color);
            Helper.MoveToElement(Map.AddToCart);
            Map.AddToCart.Click();
            Helper.WaitForPageToLoad(Map.ProductAddedSuccessfully);
            ContinueShopping();
        }

        public bool CorrectCartNumber(int itemNumber)
        {
            bool correctResult = false;
            int webItemNumber = int.Parse(Map.ItemsInCart.Text);

            if(webItemNumber == itemNumber)
            {
                string value = $@"item {itemNumber} was added correclty.";
                ProductsInCart = itemNumber;
                Console.WriteLine(value);
                correctResult = true;
            }

            return correctResult;

        }

    }
}
