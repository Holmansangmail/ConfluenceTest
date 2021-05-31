using AutomatioPracticeProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomatioPracticeProject.TestSuites.Base
{
    public class BaseTest
    {
        private IWebDriver Driver { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            Driver = new ChromeDriver(chromeOptions);
            Pages.Init(Driver);
            Pages.Home.GoTo();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.Quit();
        }

    }
}
