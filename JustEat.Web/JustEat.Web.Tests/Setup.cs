using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace JustEat.Web.Tests
{
    [Binding]
    public class Setup
    {
        private readonly IObjectContainer _objectContainer;

        public Setup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Before()
        {
            var chromeDriver = GetChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(chromeDriver);
        }

        [AfterScenario]
        public void After()
        {
            _objectContainer.Resolve<IWebDriver>().Dispose();
        }

        private ChromeDriver GetChromeDriver()
        {
            return new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
