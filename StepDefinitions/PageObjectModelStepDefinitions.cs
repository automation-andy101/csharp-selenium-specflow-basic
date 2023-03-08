using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowEA.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowEA.StepDefinitions
{
    [Binding]
    public class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;
        SearchPage searchPage;
        ResultPage resultPage;
        ChannelPage channelPage;

        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am on the YouTube home page")]
        public void GivenIAmOnTheYouTubeHomePage()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(4000);
        }

        [When(@"I search for Testers Talk in the search bar")]
        public void WhenISearchForTestersTalkInTheSearchBar()
        {
            searchPage = new SearchPage(driver);
            resultPage = searchPage.SearchText("Testers Talk");
            Thread.Sleep(4000);
        }

        [When(@"click on the Tester Talk channel in the search results")]
        public void WhenClickOnTheTesterTalkChannelInTheSearchResults()
        {
            channelPage = resultPage.clickOnChannel();
            Thread.Sleep(4000);
        }

        [Then(@"I am taken to the Testers Talk YouTube channel")]
        public void ThenIAmTakenToTheTestersTalkYouTubeChannel()
        {
            Assert.AreEqual("Testers Talk", channelPage.getTitle());
        }
    }
}
