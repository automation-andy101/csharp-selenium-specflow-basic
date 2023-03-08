using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowEA.StepDefinitions
{
    [Binding]
    public class DataTableDataDrivenTestingExamplesStepDefinitions
    {
        private IWebDriver driver;

        public DataTableDataDrivenTestingExamplesStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [When(@"Enter search keyword in YouTube")]
        public void WhenEnterSearchKeywordInYouTube(Table table)
        {
            var searchCriteria = table.CreateSet<SearchKeyTestData>();

            foreach (var keyword in searchCriteria)
            {
                driver.FindElement(By.XPath("//*[@name='search_query']")).Clear();
                driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(keyword.searchKey);
                driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            }
        }


    }

    public class SearchKeyTestData
    {
        public string searchKey { get; set; }
    }
}
