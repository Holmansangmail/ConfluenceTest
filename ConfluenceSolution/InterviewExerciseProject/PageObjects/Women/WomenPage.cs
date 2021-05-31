using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.PageObjects.Women.Map;
using OpenQA.Selenium;

namespace InterviewExerciseProject.PageObjects
{

    // It contains all of the methods available for this page

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
