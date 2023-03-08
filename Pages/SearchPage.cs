using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowEA.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By SearctTextBox = By.XPath("//*[@name='search_query']");

        public ResultPage SearchText(string text)
        {
            driver.FindElement(SearctTextBox).SendKeys(text);
            driver.FindElement(SearctTextBox).SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }

    }
}
