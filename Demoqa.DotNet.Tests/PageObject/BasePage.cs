using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace Demoqa.DotNet.Tests.PageObject
{
    public class BasePage
    {
        private readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void OpenPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void IsDisplayed(IWebElement element)
        {

        }

        public void Wait(By locator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void Wait(IWebElement element)
        {

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
        }

        public string GetText(IWebElement element)
        {
            return element.Text;
        }
    }
}
