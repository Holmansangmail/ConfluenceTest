using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.Utilities;
using OpenQA.Selenium;

namespace InterviewExerciseProject.PageObjects.Home.Map
{

    // It contains locators for this page

    public class HomePageMap : BasePage
    {
        public HomePageMap(IWebDriver driver) : base(driver)
        {
        }

        // Locators for sync
        public By WomenResults => By.Id("center_column");
        public By CartResults => By.Id("cart_title");

        // Locators for interaction
        public IWebElement WomenTab => Helper.LocateElement(Locators.Xpath, "//*[@id='block_top_menu']/ul/li[1]/a");
        public IWebElement CartBox => Helper.LocateElement(Locators.Xpath, "//*[@id='header']/div[3]/div/div/div[3]/div/a");
        


    }
}
