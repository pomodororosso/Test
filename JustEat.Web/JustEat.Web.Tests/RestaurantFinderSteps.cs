using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace JustEat.Web.Tests
{
    [Binding]
    public class RestaurantFinderSteps
    {
        private RestaurantPage _restaurantPage;

        public RestaurantFinderSteps(RestaurantPage restaurantPage)
        {
            _restaurantPage = restaurantPage;
        }

        [Given(@"I go to the restaurant finder page")]
        public void GivenIGoToTheRestaurantFinderPage()
        {
            _restaurantPage.GoTo();
        }

        [Given(@"I enter ""(.*)"" into the search field")]
        public void GivenIEnterIntoTheSearchField(string outcode)
        {
            _restaurantPage.EnterSearchText(outcode);
        }

        [When(@"I press find")]
        public void WhenIPressFind()
        {
            _restaurantPage.PressFind();
        }

        [Then(@"the results (should|should not) be displayed")]
        public void ThenTheResultsShouldBeDisplayed(bool shouldExist)
        {
            Assert.True(_restaurantPage.ResultsExist() == shouldExist);
            if (shouldExist)
            {
                Assert.True(_restaurantPage.ResultsContainerHeaders("Name", "Cuisine Types", "Rating"));
            }
        }
    }
}
