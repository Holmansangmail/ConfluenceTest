using InterviewExerciseProject.Utilities;
using OpenQA.Selenium;

namespace InterviewExerciseProject.PageObjects.Base
{
    public class BasePage
    {
        public static int ProductsInCart;
        protected Helpers Helper { get; }

        protected BasePage(IWebDriver driver)
        {
            Helper = new Helpers(driver);
        }

    }
}
