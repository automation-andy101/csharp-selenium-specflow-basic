using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowEA.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;

        public DataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [When(@"I search for '([^']*)'")]
        public void WhenISearchFor(string searchText)
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchText);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
        }


    }
}
