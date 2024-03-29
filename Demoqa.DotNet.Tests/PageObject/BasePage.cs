using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace Demoqa.DotNet.Tests.PageObject
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void OpenPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        //public void AssertIsDisplayed(IWebElement element)
        //{
        //    Wait(element);
        //    Assert.That(element.Displayed);
        //}

        //public bool AssertIsDisplayed2(IWebElement element)
        //{
        //    Wait(element);
        //    return element.Displayed;
        //}

        public void WaitAlert()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public void Wait(IWebElement element)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
        }

        public void WaitUntilClickable(IWebElement element)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }
        public string GetTitle()
        {
            return driver.Title;
        }

        public bool IsElementVisible(IWebElement element, bool useWait = false)
        {
            try
            {
                if(useWait)
                {
                    Wait(element);
                }

                return element.Displayed;

            } catch(NoSuchElementException) 
            {
                return false;
            }
        }
    }
}
