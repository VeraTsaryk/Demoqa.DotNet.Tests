using Demoqa.DotNet.Tests.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Demoqa.DotNet.Tests.tests
{
    internal class BaseTest<TPage>
        where TPage : BasePage
    {
        protected TPage page;

        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
