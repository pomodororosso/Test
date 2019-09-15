using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace JustEat.Web.Tests
{
    [Binding]
    public class RestaurantPage
    {
        private IWebDriver _webDriver;

        public RestaurantPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void GoTo()
        {
            _webDriver.Navigate().GoToUrl("http://justeat-ddb-test.azurewebsites.net/");
        }

        public void EnterSearchText(string outcode)
        {
            var searchField = _webDriver.FindElement(By.Id("Outcode"));
            searchField.SendKeys(outcode);
        }

        public void PressFind()
        {
            var findButton = _webDriver.FindElement(By.Id("findButton"));
            findButton.Click();
        }

        public bool ResultsExist()
        {          
            return GetRestaurantResultsTable() != null;
        }

        public bool ResultsContainerHeaders(params string[] headers)
        {
            var containsHeaders = false;
            var table = GetRestaurantResultsTable();
            if (table != null)
            {
                var thead = table.FindElement(By.TagName("thead"));
                var columnHeaders = thead.FindElements(By.TagName("td"));
                containsHeaders = headers.Intersect(columnHeaders.Select(c => c.Text)).Count() == headers.Count();
            }
            return containsHeaders;
        }

        private IWebElement GetRestaurantResultsTable()
        {
            IWebElement table = null;
            try
            {
                // will throw an exception if not present 
                // TODO wrap in extension method
                table = _webDriver.FindElement(By.Id("restaurantsTable"));
            }
            catch
            {
            }
            return table;
        }
    }
}
