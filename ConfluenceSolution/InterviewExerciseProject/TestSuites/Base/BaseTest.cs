using InterviewExerciseProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace InterviewExerciseProject.TestSuites.Base
{
    [TestClass]
    public class BaseTest
    {
        private static IWebDriver Driver { get; set; }

        [AssemblyInitialize]
        public static void SetupTest(TestContext context)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            Driver = new ChromeDriver(chromeOptions);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Pages.Init(Driver);
            Pages.Home.GoTo();
        }

        [AssemblyCleanup]
        public static void TeardownTest()
        {
            Driver.Quit();
        }
    }
}
