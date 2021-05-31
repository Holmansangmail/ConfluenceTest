using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.Utilities;
using OpenQA.Selenium;

namespace InterviewExerciseProject.PageObjects.Women.Map
{

    // It contains locators for this page

    public class WomenPageMap : BasePage
    {
        public WomenPageMap(IWebDriver driver) : base(driver)
        {
        }

        // Locators for sync

        public By AdditionalDetailsResults => By.XPath("//*[@id='center_column']/div/div/div[3]");


        // Locators for interaction

        public IWebElement AdditionalDetails(int itemNumber) => Helper.LocateElement(Locators.Xpath, $@"//*[@id='center_column']/ul/li[{itemNumber}]/div/div[2]/div[2]/a[2]/span");
        public IWebElement ProductBox(int itemNumber) => Helper.LocateElement(Locators.Xpath, $@"//*[@id='center_column']/ul/li[{itemNumber}]");

    }
}
