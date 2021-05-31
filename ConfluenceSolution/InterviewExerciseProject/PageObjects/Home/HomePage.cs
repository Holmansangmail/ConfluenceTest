using InterviewExerciseProject.PageObjects.Base;
using InterviewExerciseProject.PageObjects.Home.Map;
using InterviewExerciseProject.Utilities;
using OpenQA.Selenium;

namespace InterviewExerciseProject.PageObjects
{

    // It contains all of the methods available for this page

    public class HomePage : BasePage
    {
        public readonly HomePageMap Map;
        public HomePage(IWebDriver driver) : base(driver)
        {
            Map = new HomePageMap(driver);
        }

        public void OpenWomenPage()
        {
            Map.WomenTab.Click();
            Helper.WaitForPageToLoad(Map.WomenResults);
        }
        public void OpenCartPage()
        {
            Map.CartBox.Click();
            Helper.WaitForPageToLoad(Map.CartResults);
        }

        public void GoTo()
        {
            string filePath = Properties.Settings.Default.UrlPath;
            string fileSheet = Properties.Settings.Default.UrlSheet;
            int rowNumber = Properties.Settings.Default.UrlRow;
            int columnNumber = Properties.Settings.Default.UrlColumn;
            string url = ExternalData.GetCellValueFromExcel(filePath,fileSheet,rowNumber,columnNumber);
            
            Helper.GoToUrl(url);
        }

    }
}
