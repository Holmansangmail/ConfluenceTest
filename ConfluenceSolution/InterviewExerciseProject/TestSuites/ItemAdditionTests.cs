using InterviewExerciseProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewExerciseProject.TestSuites.Base;
using FluentAssertions;
using System;
using InterviewExerciseProject.PageObjects.Base;

namespace InterviewExerciseProject.TestSuites
{
    // Test Suites for Adding Items

    [TestClass]
    public class ItemAdditionTests : BaseTest
    {
        public TestContext TestContext { get; set; }
        public static int id, itemNumber;
        private static string size, color, because;
        

        [TestMethod]
        [DataSource("GetItems")]
        public void AddUniqueItems()
        {
            size        = TestContext.DataRow["Size"].ToString();
            color       = TestContext.DataRow["Color"].ToString();
            id          = Int32.Parse(TestContext.DataRow["ID"].ToString());
            itemNumber  = Int32.Parse(TestContext.DataRow["Item Number"].ToString());
            because = "the number of articles displayed on the web page is correct with the input data set.";

            Pages.Home.OpenWomenPage();
            Pages.Women.OpenAdditionalDetails(itemNumber);
            Pages.AdditionalDetails.AddToCart(size, color);
            Pages.AdditionalDetails.CorrectCartNumber(id).Should().BeTrue(because);
        }

        [TestMethod]
        public void VerifyTotalNumberOfItems()
        {
            because = $@"the total number of items should be {BasePage.ProductsInCart}";

            Pages.Home.GoTo();
            Pages.Home.OpenCartPage();
            Pages.ShoppingCart.CorrectShoppingCartSummary().Should().BeTrue(because);
        }

    }
}
