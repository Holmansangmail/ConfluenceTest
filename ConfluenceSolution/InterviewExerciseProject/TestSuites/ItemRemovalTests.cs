using FluentAssertions;
using InterviewExerciseProject.PageObjects;
using InterviewExerciseProject.TestSuites.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewExerciseProject.TestSuites
{

    // Test Suites for Removing Items

    [TestClass]
    public class ItemRemovalTests : BaseTest
    {
        public TestContext TestContext { get; set; }
        private static string because;

        [TestMethod]
        public void RemoveItems()
        {
            because = "the empty message should appear";

            Pages.Home.GoTo();
            Pages.Home.OpenCartPage();
            Pages.ShoppingCart.RemoveAllProducts().Should().BeTrue(because);
            
        }

    }
}
