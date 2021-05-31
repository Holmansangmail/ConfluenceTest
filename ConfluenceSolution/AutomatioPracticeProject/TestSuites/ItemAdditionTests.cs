using AutomatioPracticeProject.PageObjects;
using AutomatioPracticeProject.TestSuites.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomatioPracticeProject.TestSuites
{
    [TestClass]
    public class ItemAdditionTests : BaseTest
    {
        [TestMethod]
        public void AddUniqueItems()
        {
            Pages.Home.OpenWomenPage();
            Pages.Women.OpenAdditionalDetails(1);
            Pages.AdditionalDetails.AddToCart("M", "Blue");

            const string Because = "the number of articles displayed on the web page is correct with the input data set.";
            Pages.AdditionalDetails.CorrectCartNumber(1).Should().BeTrue(Because);
        }
    }
}
