using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoqa.DotNet.Tests.PageObject
{
    public class StatusCodePage : BasePage
    {
        public StatusCodePage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.CssSelector, Using = "#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(2) > a:nth-child(14)")]
        public IWebElement SecondLinkBtn { get; set; }

        public void StatusCode()
        {
            SecondLinkBtn.Click();
            Thread.Sleep(5);
        }

    }
}
