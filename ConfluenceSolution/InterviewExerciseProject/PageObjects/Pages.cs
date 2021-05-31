using InterviewExerciseProject.PageObjects.Women;
using OpenQA.Selenium;

namespace InterviewExerciseProject.PageObjects
{

    // Create instances of the different pages in order to be used in the test suites

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
