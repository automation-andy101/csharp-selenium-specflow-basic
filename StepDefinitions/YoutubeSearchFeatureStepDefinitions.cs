using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowEA.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions
    {
        private IWebDriver driver;

        public YoutubeSearchFeatureStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am on the youtube search page")]
        public void GivenIAmOnTheYoutubeSearchPage()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

            driver.Url = "https://www.youtube.com/";
        }

        [When(@"I search for Tester Talk")]
        public void WhenISearchForTesterTalk()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Testers Talk");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);

            Thread.Sleep(5000);
        }

        [Then(@"I see results for Tester Talk")]
        public void ThenISeeResultsForTesterTalk()
        {
            //driver.Quit();
        }
    }
}
