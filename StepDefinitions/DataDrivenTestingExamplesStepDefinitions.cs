using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowEA.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingExamplesStepDefinitions
    {
        private IWebDriver driver;

        public DataDrivenTestingExamplesStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [When(@"I search with (.*)")]
        public void WhenISearchWithSpecFlowTalkByBakkappa(string searchText)
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(searchText);
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
        }


    }
}
